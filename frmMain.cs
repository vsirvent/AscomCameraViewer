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

		private int renderedFrameCounter = 0;
		private long startTicks = 0;
		private long endTicks = 0;

		private double renderFps = double.NaN;
		private long currentFrameNo = 0;

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


		private void DisplayVideoFrames(object state)
		{
			while(running)
			{
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
							lastDisplayedVideoFrameNumber = frame.FrameNumber;
                           
                            if (true)
                            {
                                System.Object[,] bayer = (System.Object[,])frame.ImageArray;
                                byte[] data = new byte[imageWidth * imageHeight * 3];

                                float cfactor = (259.0f * ((float)nContrast.Value + 255.0f)) / (255.0f * (259.0f - (float)nContrast.Value));
                                for (int y = 0; y < imageHeight - 1; y += 2)
                                {
                                    for (int x = 0; x < imageWidth - 1; x += 2)
                                    {
                                        float r, g0, g1, b;
                                        float nblack = (float)nBlack.Value;
                                        float nwhite = (float)nWhite.Value;
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

                                        r = b00;
                                        g0 = b01;
                                        g1 = b10;
                                        b = b11;

                                        r = Math.Max(Math.Min((r - nblack) * 256.0f / nwhite, 255.0f), 0.0f);
                                        g0 = Math.Max(Math.Min((g0 - nblack) * 256.0f / nwhite, 255.0f), 0.0f);
                                        g1 = Math.Max(Math.Min((g1 - nblack) * 256.0f / nwhite, 255.0f), 0.0f);
                                        b = Math.Max(Math.Min((b - nblack) * 256.0f / nwhite, 255.0f), 0.0f);

                                        r /= 256.0f;
                                        g0 /= 256.0f;
                                        g1 /= 256.0f;
                                        b /= 256.0f;

                                        float gamma = ((float)nGamma.Value + 5.0f) / 5.0f;
                                        if (gamma != 1.0)
                                        {
                                            r = (float)Math.Pow(r, 1.0f / gamma);
                                            g0 = (float)Math.Pow(g0, 1.0f / gamma);
                                            g1 = (float)Math.Pow(g1, 1.0f / gamma);
                                            b = (float)Math.Pow(b, 1.0f / gamma);
                                        }

                                        r = Math.Max(Math.Min((int)((cfactor * (r * 256.0f - 128.0f) + 128.0f) * (float)nBright.Value) / 10, 255), 0);
                                        b = Math.Max(Math.Min((int)((cfactor * (b * 256.0f - 128.0f) + 128.0f) * (float)nBright.Value) / 10, 255), 0);
                                        g0 = Math.Max(Math.Min((int)((cfactor * (g0 * 256.0f - 128.0f) + 128.0f) * (float)nBright.Value) / 10, 255), 0);
                                        g1 = Math.Max(Math.Min((int)((cfactor * (g1 * 256.0f - 128.0f) + 128.0f) * (float)nBright.Value) / 10, 255), 0);

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
                            }
                            PaintVideoFrame(frame, bmp);
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
                            PaintVideoFrame(null, errorBmp);
                        }
                        catch (InvalidOperationException)
						{
							// InvalidOperationException could be thrown when closing down the app i.e. when the form has been already disposed
						}
					}
				}
				Thread.Sleep(10);
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

                if (!double.IsNaN(renderFps))
                {
                    tssDisplayRate.Text = renderFps.ToString("Display Rate: 0.00 fps");
                }
                else
                {
                    tssDisplayRate.Text = "Display Rate: N/A";
                }
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
                videoObject.ExposureTime = (double)expTime.Value;
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
    }
}
