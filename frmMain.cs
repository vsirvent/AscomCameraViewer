//tabs=4
// --------------------------------------------------------------------------------
//
// ASCOM Video Driver - Video Client
//
// Description:	The main form of the Video Client
//
// Author:		(HDP) Hristo Pavlov <hristo_dpavlov@yahoo.com>
//
// --------------------------------------------------------------------------------
//

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Accord.Imaging.Filters;
using ASCOM.DeviceInterface;
using ASCOM.DriverAccess;
using ASCOM.Utilities.Video;
using Client.Properties;

namespace Client
{
	public partial class frmMain : Form
	{
		private IVideoWrapper videoObject;
        private ICameraImage cameraImage;

        private bool running = false;

		private int imageWidth;
		private int imageHeight;
        private float nwhite = 255.0f;
        private float nblack = 0.0f;
	 
		public frmMain()
		{
			InitializeComponent();

			running = true;
			previewOn = cbFrameFetcher.Checked;

		    cameraImage = new CameraImage();

			ThreadPool.QueueUserWorkItem(new WaitCallback(DisplayVideoFrames));

            toolStripSizeLabel.Text = "Size: N/A";

        }

        protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);

			DisconnectFromCamera();
			running = false;
		}

		private void ConnectToCamera()
		{
			var chooser = new ASCOM.Utilities.Chooser { DeviceType = "Camera" };
            string progId = chooser.Choose();

			if (!string.IsNullOrEmpty(progId))
			{
				videoObject = VideoWrapper.CreateVideoWrapper(progId);
				
				try
				{
					Cursor = Cursors.WaitCursor;
					videoObject.Connected = true;

					if (videoObject.Connected)
					{
						imageWidth = videoObject.Width;
						imageHeight = videoObject.Height;
						pictureBox.Image = new Bitmap(imageWidth, imageHeight);
					}
				}
				finally
				{
					Cursor = Cursors.Default;
				}
                
				UpdateCameraState(true);
			}
		}

		private void DisconnectFromCamera()
		{
			if (videoObject != null)
			{
				videoObject.Disconnect();
				videoObject = null;
			}

			UpdateCameraState(false);
		}

		private void UpdateCameraState(bool connected)
		{
			pnlVideoControls.Enabled = connected;
			miConnect.Enabled = !connected;
			miDisconnect.Enabled = connected;
			miCameraInfo.Enabled = connected;
			miDriverInfo.Enabled = connected;
			miSettings.Enabled = !connected;
		
			
			miVideoSetup.Enabled = connected && videoObject != null;

			UpdateState();
            bool was_enabled = pnlVideoControls.Enabled;

		
			if (videoObject != null)
			{
                pnlVideoControls.Enabled = connected;

                Text = string.Format("ASCOM Video Client - {0}{1}", 
						videoObject.DeviceName, 
						videoObject.VideoCaptureDeviceName != null
							? string.Format(" ({0})", videoObject.VideoCaptureDeviceName) 
							: string.Empty);
                trackGain.Minimum = videoObject.GainMin;
                trackGain.Maximum = videoObject.GainMax;
                trackGain.Enabled = (trackGain.Maximum != 0);
                labelGain.Text = "Gain [" + videoObject.GainMin + ", " + videoObject.GainMax + "]:";
            }
			else
			{
				Text = "ASCOM Video Client";
			}
       
        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DisconnectFromCamera();
			Close();
		}

		private void miConfigure_Click(object sender, EventArgs e)
		{
			var frmSettings = new frmSettings();
			if (frmSettings.ShowDialog(this) == DialogResult.OK)
			{
				//TODO: Do things after configuration
			}
		}

		private void miConnect_Click(object sender, EventArgs e)
		{
			ConnectToCamera();
		}

		private void miDisconnect_Click(object sender, EventArgs e)
		{
			DisconnectFromCamera();
		}

		private static Font debugTextFont = new Font(FontFamily.GenericMonospace, 10);

		private long lastDisplayedVideoFrameNumber = -1;
		private bool previewOn = true;

		private delegate void PaintVideoFrameDelegate(IVideoFrame frame, Bitmap bmp);
        private delegate void PaintToolStripTextDelegate(ToolStripItem c, String text);
        private delegate void PaintHistogramDelegate(PictureBox p, SortedDictionary<int, int> values);

        private int renderedFrameCounter = 0;
		private long startTicks = 0;
		private long endTicks = 0;

		private double renderFps = double.NaN;
		private long currentFrameNo = 0;

        private void PaintHistogram(PictureBox p, SortedDictionary<int, int> values)
        {
            //Normalize
            int max = 0;
            foreach (var v in values) {
                if (v.Value > max)
                {
                    max = v.Value;
                }
            }

            Bitmap b = new Bitmap(p.Width, p.Height, PixelFormat.Format24bppRgb);
            using (Graphics g = Graphics.FromImage(b))
            {
                Pen pen = new Pen(Color.White);
                foreach (var v in values)
                {
                    g.DrawLine(pen, v.Key, p.Height - 1, v.Key, p.Height - 1 - (v.Value * p.Height) / max);
                }
                Pen pen2 = new Pen(Color.Yellow);
                int nblack_pos = (int)nblack * p.Width / 256;
                int nwhite_pos = (int)nwhite * p.Width / 256;

                g.DrawLine(pen2, nblack_pos, p.Height - 1, nblack_pos, 0);
                g.DrawLine(pen2, nwhite_pos, p.Height - 1, nwhite_pos, 0);

            }
            p.Image = b;
        }

        private void PaintToolStripText(ToolStripItem c, String t)
        {
            c.Text = t;
        }

        private void PaintVideoFrame(object frame, Bitmap bmp)
        {
            bool isEmptyFrame = frame == null;
            if (!isEmptyFrame)
                isEmptyFrame = frame == null;

            if (isEmptyFrame)
            {
                pictureBox.Image = bmp;
                return;
            }

            currentFrameNo++;
            UpdateState();
            renderedFrameCounter++;

            if (renderedFrameCounter == 20)
            {
                renderedFrameCounter = 0;
                endTicks = DateTime.Now.Ticks;
                if (startTicks != 0)
                {
                    renderFps = 20.0 / new TimeSpan(endTicks - startTicks).TotalSeconds;
                }
                startTicks = DateTime.Now.Ticks;
            }
            pictureBox.Image = bmp;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            if (toolStripSizeLabel.Visible == false)
            {
                toolStripSizeLabel.Visible = true;
            }
            toolStripSizeLabel.Text = "Size: " + bmp.Width + "x" + bmp.Height;
        }
		
		internal class FakeFrame : IVideoFrame
		{
			private static int s_Counter = -1;

			public object ImageArray
			{
				get { return new object(); }
			}

			public object ImageArrayVariant
			{
				get { return null; }
			}

			public byte[] PreviewBitmap
			{
				get { return null; }
			}

			public long FrameNumber
			{
				get
				{
					s_Counter++;
					return s_Counter;
				}
			}

			public double ExposureDuration
			{
				get { return 0; }
			}

			public string ExposureStartTime
			{
				get { return null; }
			}

			public ArrayList ImageMetadata

            {
				get { return new ArrayList(); }
			}
		}

        private SortedDictionary<int, int> histogramVals = new SortedDictionary<int, int>();
        private System.Int32[,] meanbayer = null;
        private void DisplayVideoFrames(object state)
		{
			while(running)
			{
                bool process = false;
                
                Stopwatch sw = Stopwatch.StartNew();
				if (videoObject != null &&
					videoObject.IsConnected &&
					previewOn)
				{
					try
					{
						IVideoFrame frame = videoObject.LastVideoFrame;
                        Bitmap bmp = null;
                        if (frame != null && frame.ImageArray != null)
						{
                            histogramVals.Clear();
							lastDisplayedVideoFrameNumber = frame.FrameNumber;
                           
                            System.Int32[,] bayer = (System.Int32[,])frame.ImageArray;

                            if (meanAmount.Value > 1)
                            {
                                float alpha = 1.0f/(float)meanAmount.Value;
                                if (meanbayer == null || meanbayer.Length != bayer.Length)
                                {
                                    meanbayer = new System.Int32[imageWidth, imageHeight];
                                    alpha = 1.0f;
                                }

                                float beta = 1.0f - alpha;
                                for (int y = 0; y < imageHeight; y++)
                                {
                                    for (int x = 0; x < imageWidth; x++)
                                    {
                                        meanbayer[x, y] = (int)((float)meanbayer[x, y] * beta + (float)bayer[x, y] * alpha);
                                    }
                                }
                                bayer = meanbayer;
                            }

                            byte[] data = new byte[imageWidth * imageHeight * 3];

                            float cfactor = (259.0f * ((float)nContrast.Value + 255.0f)) / (255.0f * (259.0f - (float)nContrast.Value));
                            for (int y = 0; y < imageHeight - 1; y += 2)
                            {
                                for (int x = 0; x < imageWidth - 1; x += 2)
                                {
                                    float r, g0, g1, b;
                                   
                                    /*
                                    int b00 = (((int)bayer[x, y]) & 0xff);
                                    int b01 = (((int)bayer[x, y]) >> 8 & 0xff);
                                    int b10 = (((int)bayer[x, y+1]) & 0xff);
                                    int b11 = (((int)bayer[x, y+1]) >> 8 & 0xff);
                                    */
                                    int b00 = (((int)bayer[x, y]));
                                    int b01 = (((int)bayer[x + 1, y]));
                                    int b10 = (((int)bayer[x, y + 1]));
                                    int b11 = (((int)bayer[x + 1, y + 1]));
                                    int lum = (b00 + b01 + b10 + b11)*histogram.Width/(4*256);
                                    var curr_val = 0;
                                    if (histogramVals.TryGetValue(lum, out curr_val))
                                    {
                                        histogramVals.Remove(lum);
                                    }
                                    histogramVals.Add(lum, curr_val + 1);

                                    r = b00;
                                    g0 = b01;
                                    g1 = b10;
                                    b = b11;

                                    if (nblack != 0 || nwhite != 0)
                                    {
                                        r = Math.Max(Math.Min((r - nblack) * 256.0f / nwhite, 255.0f), 0.0f);
                                        g0 = Math.Max(Math.Min((g0 - nblack) * 256.0f / nwhite, 255.0f), 0.0f);
                                        g1 = Math.Max(Math.Min((g1 - nblack) * 256.0f / nwhite, 255.0f), 0.0f);
                                        b = Math.Max(Math.Min((b - nblack) * 256.0f / nwhite, 255.0f), 0.0f);
                                    }
                                    

                                    float gamma = ((float)nGamma.Value + 5.0f) / 5.0f;
                                    if (gamma != 1.0)
                                    {
                                        r /= 256.0f;
                                        g0 /= 256.0f;
                                        g1 /= 256.0f;
                                        b /= 256.0f;

                                        r = (float)Math.Pow(r, 1.0f / gamma);
                                        g0 = (float)Math.Pow(g0, 1.0f / gamma);
                                        g1 = (float)Math.Pow(g1, 1.0f / gamma);
                                        b = (float)Math.Pow(b, 1.0f / gamma);

                                        r *= 256.0f;
                                        g0 *= 256.0f;
                                        g1 *= 256.0f;
                                        b *= 256.0f;
                                    }

                                    r = Math.Max(Math.Min((int)((cfactor * (r - 128.0f) + 128.0f) * (float)nBright.Value) / 10, 255), 0);
                                    b = Math.Max(Math.Min((int)((cfactor * (b - 128.0f) + 128.0f) * (float)nBright.Value) / 10, 255), 0);
                                    g0 = Math.Max(Math.Min((int)((cfactor * (g0 - 128.0f) + 128.0f) * (float)nBright.Value) / 10, 255), 0);
                                    g1 = Math.Max(Math.Min((int)((cfactor * (g1 - 128.0f) + 128.0f) * (float)nBright.Value) / 10, 255), 0);

                                    byte br = (byte)r;
                                    byte bg0 = (byte)g0;
                                    byte bg1 = (byte)g1;
                                    byte bb = (byte)b;
                                    data[(y * imageWidth * 3) + x * 3 + 0] = (bb);
                                    data[(y * imageWidth * 3) + x * 3 + 1] = (bg0);
                                    data[(y * imageWidth * 3) + x * 3 + 2] = (br);
                                    data[(y * imageWidth * 3) + x * 3 + 3] = (bb);
                                    data[(y * imageWidth * 3) + x * 3 + 4] = (bg0);
                                    data[(y * imageWidth * 3) + x * 3 + 5] = (br);

                                    data[(y + 1) * imageWidth * 3 + x * 3 + 0] = (bb);
                                    data[(y + 1) * imageWidth * 3 + x * 3 + 1] = (bg1);
                                    data[(y + 1) * imageWidth * 3 + x * 3 + 2] = (br);
                                    data[(y + 1) * imageWidth * 3 + x * 3 + 3] = (bb);
                                    data[(y + 1) * imageWidth * 3 + x * 3 + 4] = (bg1);
                                    data[(y + 1) * imageWidth * 3 + x * 3 + 5] = (br);
                                }
                            }

                            unsafe
                            {
                                fixed (byte* pdata = data)
                                {
                                    IntPtr p = new IntPtr((void*)pdata);
                                    bmp = new Bitmap(imageWidth, imageHeight, imageWidth * 3, PixelFormat.Format24bppRgb, p);
                                    if (cbHistoEq.Checked)
                                    {
                                        // create filter
                                        ContrastStretch hfilter = new ContrastStretch();
                                        // process image
                                        hfilter.ApplyInPlace(bmp);
                                    }
                                    if (cbNoiseActive.Checked)
                                    {
                                        BilateralSmoothing nfilter = new BilateralSmoothing();
                                        nfilter.KernelSize = (int)noiseKernel.Value;
                                        nfilter.SpatialFactor = (double)noiseSpatial.Value;
                                        nfilter.ColorFactor = (double)noiseColor.Value;
                                        nfilter.ColorPower = (double)noisePower.Value;
                                        nfilter.ApplyInPlace(bmp);
                                    }
                                    if (bSharp.Checked)
                                    {
                                        GaussianSharpen sfilter = new GaussianSharpen((int)sharpKernel.Value, (int)sharpSigma.Value);
                                        sfilter.ApplyInPlace(bmp);
                                    }
                                }
                            }
                            
                            Invoke(new PaintVideoFrameDelegate(PaintVideoFrame), new object[] { frame, bmp });
                            Invoke(new PaintHistogramDelegate(PaintHistogram), new object[] { histogram, histogramVals });
                            process = true;

                         }
					}
					catch(ObjectDisposedException){ }
					catch(Exception ex)
					{
						Trace.WriteLine(ex);

						Bitmap errorBmp = new Bitmap(pictureBox.Width, pictureBox.Height);
						using (Graphics g = Graphics.FromImage(errorBmp))
						{
							g.Clear(Color.Tomato);
							g.DrawString(ex.Message, debugTextFont, Brushes.Black, 10, 10);
							g.Save();
						}
						try
						{
                            Invoke(new PaintVideoFrameDelegate(PaintVideoFrame), new object[] { null, errorBmp });                            
                        }
                        catch (InvalidOperationException)
						{
							// InvalidOperationException could be thrown when closing down the app i.e. when the form has been already disposed
						}
					}
                }
                sw.Stop();
                long sleep_time = 100;
                if (videoObject != null)
                {
                    sleep_time = (long)(videoObject.ExposureTime * 1000.0) - sw.ElapsedMilliseconds;
                    System.Console.Out.WriteLine("Loop time " + sw.ElapsedMilliseconds + " msec");
                    if (process)
                    {
                        Invoke(new PaintToolStripTextDelegate(PaintToolStripText), new object[] { toolStripProcessTime, "Process time: " + sw.ElapsedMilliseconds + " msec." });
                    }
                }
                if (sleep_time > 0)
                {
                    System.Console.Out.WriteLine("Sleep => " + sleep_time);
                    Thread.Sleep((int)sleep_time);
                }
                Application.DoEvents();
			}
		}

		private void cbFrameFetcher_CheckedChanged(object sender, EventArgs e)
		{
			previewOn = cbFrameFetcher.Checked;
		}

		private void UpdateState()
		{
			if (videoObject == null)
			{
				tssCameraState.Text = "Disconnected";
				tssFrameNo.Text = string.Empty;
				tssDisplayRate.Text = string.Empty;
				tssFrameNo.Visible = false;
				tssDisplayRate.Visible = false;
                toolStripSizeLabel.Visible = false;
                toolStripProcessTime.Visible = false;
                histogram.Image = null;
                histogram.BackColor = SystemColors.ControlDark;
            }
			else
			{
				if (videoObject.State == CameraStates.cameraError) 
				{
				    tssCameraState.Text = "Error";
                } else {
                    tssCameraState.Text = "Connected";
                }

                if (!tssFrameNo.Visible) tssFrameNo.Visible = true;				

				tssFrameNo.Text = currentFrameNo.ToString("Current Frame: 0", CultureInfo.InvariantCulture);
                if (!tssDisplayRate.Visible) tssDisplayRate.Visible = true;
                if (!toolStripProcessTime.Visible) toolStripProcessTime.Visible = true;
                if (!double.IsNaN(renderFps))
                {
                    tssDisplayRate.Text = renderFps.ToString("Display Rate: 0.00 fps");
                }
                else
                {
                    tssDisplayRate.Text = "Display Rate: N/A";
                }
                histogram.Image = null;
                histogram.BackColor = Color.Black;
            }
        }

        private void miDriverInfo_Click(object sender, EventArgs e)
		{
			if (videoObject != null)
			{
				var frm = new frmDriverInfo();
				frm.SetVideoObject(videoObject);

				frm.ShowDialog(this);
			}
		}

		private void miCameraInfo_Click(object sender, EventArgs e)
		{
			if (videoObject != null)
			{
				var frm = new frmCameraInfo();
				frm.SetVideoObject(videoObject);

				frm.ShowDialog(this);
			}
		}

		private void ResizeVideoFrameTo(int imageWidth, int imageHeight)
		{
			Width = Math.Max(800, (imageWidth - pictureBox.Width) + this.Width);
			Height = Math.Max(600, (imageHeight - pictureBox.Height) + this.Height);
		}

		private void miVideoSetup_Click(object sender, EventArgs e)
		{
			if (videoObject != null)
				videoObject.SetupDialog();
		}

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void OnWindowSizeChanged(object sender, EventArgs e)
        {

        }

        private void OnExposureTimeChanged(object sender, EventArgs e)
        {
            if (videoObject != null)
            {
                double time = (double)expTime.Value;
                if (time > 0.0 && time != videoObject.ExposureTime)
                {
                    videoObject.ExposureTime = time;
                    expTime.Value = (decimal)time;
                }            
            }
        }

        private void trackGain_Scroll(object sender, EventArgs e)
        {
            if (videoObject != null)
            {
                if (trackGain.Value != videoObject.Gain)
                {
                    videoObject.Gain = trackGain.Value;
                    lgain.Text = videoObject.Gain.ToString();
                    trackGain.Value = videoObject.Gain;
                }
            }
        }

        private void trackBL_Scroll(object sender, EventArgs e)
        {
            lBL.Text = "BL: " + trackBL.Value;
            nblack = trackBL.Value;
        }

        private void trackWL_Scroll(object sender, EventArgs e)
        {
            lWL.Text = "WL: " + trackWL.Value;
            nwhite = trackWL.Value;
        }
    }
}
