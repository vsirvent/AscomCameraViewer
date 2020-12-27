using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ASCOM.DeviceInterface;

namespace Client
{
	public interface IVideoWrapper
	{
		bool Connected { get; set; }
		void Disconnect();
		bool IsConnected { get; }
		bool SupporstFreeStyleGain { get; }
		void SetFreeRangeGainIntervals(short numIntervals);
		int Width { get; }
		int Height { get; }
		bool HasSupportedActions { get; }
		string[] SupportedActions { get; }
		CameraStates State { get; }
		bool CanConfigureDeviceProperties { get; }
		string CameraFrameRate { get; }
		string CameraBitDepth { get; }
		string CameraVideoFormat { get; }
		string BufferingInfo { get; }
		string DeviceName { get; }
		string VideoCaptureDeviceName { get; }
		string ExecuteAction(string actionName, string actionParameters);
		IVideoFrame LastVideoFrame { get; }
		SensorType SensorType { get; }
		string Gamma { get; }
		bool CanIncreaseGamma { get; }
		bool CanDecreaseGamma { get; }
		string Gain { get; }
		bool CanIncreaseGain { get; }
		bool CanDecreaseGain { get; }
		string Integration { get; }
		bool CanIncreaseIntegration { get; }
		bool CanDecreaseIntegration { get; }
		string StartRecording(string fileName);
		void StopRecording();
		void IncreaseGamma();
		void DecreaseGamma();
		void DecreaseGain();
		void IncreaseGain();
		void DecreaseIntegration();
		void IncreaseIntegration();
		void ConfigureDeviceProperties();
		void SetupDialog();

		string InterfaceVersion { get; }
		string DriverVersion { get; }
		string DeviceDescription { get; }
		string DriverInfo { get; }
		string CameraSensorInfo { get; }
		string CameraCCDCellSize { get; }
		string CameraCCDDimentionInPixels { get; }
		string ExposureRangeInfo { get; }
		string GainRangeInfo { get; }
		string GammaRangeInfo { get; }
	}
}
