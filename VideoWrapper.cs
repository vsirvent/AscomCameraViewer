//tabs=4
// --------------------------------------------------------------------------------
//
// ASCOM Video Driver - Video Client
//
// Description:	A wrapper of the IVideo COM object instance
//
// Author:		(HDP) Hristo Pavlov <hristo_dpavlov@yahoo.com>
//
// --------------------------------------------------------------------------------
//

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ASCOM;
using ASCOM.DeviceInterface;
using ASCOM.DriverAccess;
using Client.Properties;

namespace Client
{
	internal class VideoWrapper : IVideoWrapper
	{
		private ICameraV2 video;
	
		public static IVideoWrapper CreateVideoWrapper(string progId)
		{
			return new VideoWrapper(new Camera(progId));
		}

		internal VideoWrapper(ICameraV2 video)
		{
			this.video = video;
		}

		public void SetFreeRangeGainIntervals(short numIntervals)
		{
	
		}

        private double expTime = 1.0;
        public double ExposureTime {
            get
            {
                return expTime;
            }
            set {
                expTime = value;
            }
        }

        public void Disconnect()
		{
			if (video != null)
			{
				video.Connected = false;
				video = null;

				pixelSizeX = null;
				pixelSizeY = null;
				sensorName = null;
			}
		}

		public bool IsConnected
		{
			get
			{
				return
					ShieldedCall(
						() =>
							video != null &&
							video.Connected,
						false);
			}
		}

		public bool Connected
		{
			get { return video.Connected; }
			set { video.Connected = true; }
		}

		public bool CanConfigureDeviceProperties
		{
			get
			{
				return
					ShieldedCall(
						() =>
							video != null &&
							false,
						false);
			}
		}

		public void ConfigureDeviceProperties()
		{
			ConfigureDevicePropertiesInternal(null);
		}

		private void ConfigureDevicePropertiesInternal(object state)
		{
			if (video != null)
			{
				ShieldedCall(
					delegate()
					{
						//video.ConfigureDeviceProperties();
						return true;
					},
					false);
			}
		}

		public void SetupDialog()
		{
			SetupDialogInternal(null);
		}

		private void SetupDialogInternal(object state)
		{
			if (video != null)
			{
				ShieldedCall(
					delegate()
					{
						video.SetupDialog();
						return true;
					},
					false);
			}
		}
		public CameraStates State
		{
			get
			{
				if (video != null && video.Connected)
				{
					return video.CameraState;
				}

				return CameraStates.cameraError;
			}
		}

	    public SensorType SensorType
	    {
	        get
	        {
               return video.SensorType;
	        }
	    }

		public bool SupportsGamma
		{
			get
			{
				return false;
			}
		}

		public bool CanDecreaseGamma
		{
			get
			{
				return false;
			}	
		}

		public bool CanIncreaseGamma
		{
			get
			{
				return false;
			}
		}

		public string Gamma
		{
			get
			{
				return "N/A";
			}

		}

		public void IncreaseGamma()
		{
			
		}

		public void DecreaseGamma()
		{
			
		}


		public bool SupporstFreeStyleGain
		{
			get
			{
                return false;	
			}
		}

		public bool SupporstDiscreteGain
		{
			get
			{
					return false;
			}
		}

		public bool CanDecreaseGain
		{
			get
			{
				return false;
			}
		}

		public bool CanIncreaseGain
		{
			get
			{
				return false;
			}
		}

		public int Gain
		{
            get
            {
                try
                {
                    return video.Gain;
                }
                catch (Exception)
                {
                    return 0;
                }
            }
            set
            {
                try
                {
                    video.Gain = (short)value;
                }catch(Exception) {

                }
            }
		}

        public int GainMin
        {
            get
            {
                int ret = 0;
                try
                {
                    ret = video.GainMin;
                }catch(Exception)
                {
                    ret = 0;
                }
                return ret;
            }

        }

        public int GainMax
        {
            get
            {
                int ret = 0;
                try
                {
                    ret = video.GainMax;
                }
                catch (Exception)
                {
                    ret = 0;
                }
                return ret;
            }
        }

        public void IncreaseGain()
		{
			
		}

		public void DecreaseGain()
		{
			
		}

		public bool CanIncreaseIntegration
		{
			get
			{
				return false;
			}
		}

		public bool CanDecreaseIntegration
		{
			get
			{
				return false;
			}
		}

		private bool SupportsIntegrationRates
		{
			get
			{
    			return false;
			}
		}

		public string Integration
		{
			get
			{
				return "N/A";
			}

		}

		public void DecreaseIntegration()
		{
		}

		public void IncreaseIntegration()
		{
		}

		public bool HasSupportedActions
		{
			get
			{
				return 
					ShieldedCall(
						() =>
				             video != null &&
				             video.SupportedActions.Count > 0, 
						false);
			}
		}

		public string[] SupportedActions
		{
			get
			{
				if (video != null)
				{
					return
						ShieldedCall(
							() => video.SupportedActions.Cast<string>().ToArray(),
							new string[0]);	
				}
				else
					return new string[0];
			}
		}

		public string ExecuteAction(string actionName, string actionParameters)
		{
			return video.Action(actionName, actionParameters);
		}

        private class VideoFrame: IVideoFrame
        {
            public object frame = null;
            public int frameNumber = 0;
            public double expDuration = 0.0;
            public string expStartTime = "";
            public ArrayList extra = new ArrayList();

            public object ImageArray { get { return frame; } }

            public byte[] PreviewBitmap { get { return (byte[])frame; } }

            public long FrameNumber { get { return frameNumber; } }

            public double ExposureDuration { get { return expDuration; } }

            public string ExposureStartTime { get { return expStartTime; } }
            public ArrayList ImageMetadata { get { return extra; } }
        }

        private async void StartExposure() {
            await Task.Run(() => {
                
                });
        }

        private VideoFrame vframe = new VideoFrame();
        private bool init = false;
		public IVideoFrame LastVideoFrame
		{
			get
			{
                IVideoFrame ret = null;
                if (video != null)
                {
                    if (!init)
                    {
                        video.StartExposure(expTime, true);
                        init = true;
                    }
                    if (video.ImageReady)
                    {
                        Stopwatch sw = Stopwatch.StartNew();
                        vframe.frame = video.ImageArray;
                        vframe.expDuration = expTime;
                        vframe.expStartTime = video.LastExposureStartTime;
                        vframe.frameNumber++;
                        ret = vframe;
                        video.StartExposure(expTime, true);
                        sw.Stop();
                    }
                    else
                    {
                        //System.Console.Out.WriteLine("Show image not ready");
                    }
                }
                return ret;
    		}
		}

		public string CameraFrameRate
		{
			get
			{
				return string.Empty;
			}
		}

		public string CameraBitDepth
		{
			get
			{
				return string.Empty;
			}
		}

		private string sensorName = null;
		private string SensorName
		{
			get
			{
				if (sensorName == null)
				{
					try
					{
						sensorName = video.SensorName;
					}
					catch (PropertyNotImplementedException)
					{
						sensorName = "Unknown";
					}
				}

				return sensorName;
			}
		}


		public string CameraSensorInfo
		{
			get
			{
				if (video != null)
				{
					string sensorType = ShieldedCall(() => video.Name, null, false);

					if (sensorName != null)
						return string.Format("{0}{1}\r\n", SensorName ?? "Unknown", sensorType != null ? " " + sensorType : string.Empty);
					else
						return "Unknown";
				}

				return "N/A";
			}
		}

		public string CameraCCDCellSize
		{
			get
			{
				if (video != null)
				{
					string pixelSizeX = PixelSizeX.ToString(CultureInfo.CurrentCulture);
					string pixelSizeY = PixelSizeY.ToString(CultureInfo.CurrentCulture);

					if (pixelSizeX != null && pixelSizeY != null)
						return string.Format("{0}um x {1}um", pixelSizeX, pixelSizeY);
					else
						return "Unknown";
				}

				return "N/A";
			}
		}

		private double? pixelSizeX = null;
		private double PixelSizeX
		{
			get
			{
				if (pixelSizeX == null)
				{
					try
					{
						pixelSizeX = video.PixelSizeX;	
					}
					catch (PropertyNotImplementedException)
					{
						pixelSizeX = 0;
					}					
				}

				return pixelSizeX.Value;
			}
		}

		private double? pixelSizeY = null;
		private double PixelSizeY
		{
			get
			{
				if (pixelSizeY == null)
				{
					try
					{
						pixelSizeY = video.PixelSizeY;
					}
					catch (PropertyNotImplementedException)
					{
						pixelSizeY = 0;
					}
				}

				return pixelSizeY.Value;
			}
		}

		public string CameraCCDDimentionInPixels
		{
			get
			{
				if (video != null)
				{
					string pixelsX = PixelSizeX.ToString(CultureInfo.CurrentCulture);
					string pixelsY = PixelSizeY.ToString(CultureInfo.CurrentCulture);

					if (pixelsX != null && pixelsY != null)
						return string.Format("{0} x {1}", pixelsX, pixelsY);
					else
						return "Unknown";
				}

				return "N/A";
			}
		}

		public int Width
		{
			get
			{
				if (video != null)
				{
					return ShieldedCall(() => video.CameraXSize, 0, false);
				}
				else
					return 0;
			}
		}

		public int Height
		{
			get
			{
				if (video != null)
				{
					return ShieldedCall(() => video.CameraYSize, 0, false);
				}
				else
					return 0;
			}
		}

		public string ExposureRangeInfo
		{
			get
			{
				if (video != null)
				{
					string expMin = ShieldedCall(() => video.ExposureMin.ToString("0.000", CultureInfo.CurrentCulture), null, false);
					string expMax = ShieldedCall(() => video.ExposureMax.ToString("0.000", CultureInfo.CurrentCulture), null, false);

					if (expMin != null && expMax != null)
					{
						if (expMin == expMax)
							return string.Format("Fixed {0} sec", expMin);
						else
							return string.Format("{0} sec - {1} sec", expMin, expMax);
					}						
					else
						return "Unknown";
				}
				else
					return "N/A";
			}
		}

		public string GainRangeInfo
		{
			get
			{
				if (video != null)
				{
					string gainMin = ShieldedCall(() => video.GainMin.ToString(CultureInfo.CurrentCulture), null, false);
					string gainMax = ShieldedCall(() => video.GainMax.ToString(CultureInfo.CurrentCulture), null, false);
					int numFixedGains = ShieldedCall(() => video.Gains.Count, -1, false);

					if (gainMin != null && gainMax != null)
						return string.Format("{0} - {1}", gainMin, gainMax);
					else if (numFixedGains > 0)
					{
						return string.Format("{0} - {1}", video.Gains[0], video.Gains[numFixedGains - 1]);
					}
					else
						return "Unknown";
				}
				else
					return "N/A";
			}
		}

		public string GammaRangeInfo
		{
			get
			{
				return "N/A";
			}
		}

		public string BufferingInfo
		{
			get
			{
				return "N/A";
			}
		}

		public string CameraVideoFormat
		{
			get
			{
				return string.Empty;
			}
		}

		public string InterfaceVersion
		{
			get
			{
				if (video != null)
				{
					return ShieldedCall(() => video.InterfaceVersion.ToString(CultureInfo.CurrentCulture), string.Empty, false);
				}

				return string.Empty;
			}
		}

		public string DriverInfo
		{
			get
			{
				if (video != null)
				{
					return ShieldedCall(() => video.DriverInfo, string.Empty, false);
				}

				return string.Empty;
			}
		}

		public string DriverVersion
		{
			get
			{
				if (video != null)
				{
					return ShieldedCall(() => video.DriverVersion, string.Empty, false);
				}

				return string.Empty;
			}
		}

		public string DeviceName
		{
			get
			{
				if (video != null)
				{
					return ShieldedCall(() => video.Name, string.Empty);
				}

				return string.Empty;
			}
		}

		public string DeviceDescription
		{
			get
			{
				if (video != null)
				{
					return ShieldedCall(() => video.Description, string.Empty, false);
				}

				return string.Empty;
			}
		}

		public string VideoCaptureDeviceName
		{
			get
			{
				if (video != null)
				{
					return ShieldedCall(() => video.Name, string.Empty, false);
				}

				return string.Empty;
			}
		}

		private T ShieldedCall<T>(Func<T> method, T errorValue)
		{
			return ShieldedCall(method, errorValue, true);
		}

		private T ShieldedCall<T>(Func<T> method, T errorValue, bool showError)
		{
			try
			{
				return method();
			}
			catch(ASCOM.DriverException dex)
			{
				if (showError)
					frmUnexpectedError.ShowErrorMessage(dex);

				return errorValue;
			}
		}

		private T ShieldedCall<T, TException>(Func<T> method, T errorValue, bool showError) where TException : Exception 
		{
			try
			{
				return method();
			}
			catch (TException tex)
			{
				if (showError)
					frmUnexpectedError.ShowErrorMessage(tex);

				return errorValue;
			}
			catch (ASCOM.DriverException dex)
			{
				frmUnexpectedError.ShowErrorMessage(dex);

				return errorValue;
			}
		}

		public string StartRecording(string fileName)
		{
			return String.Empty;
		}

		public void StopRecording()
		{
			
		}
	}
}
