using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client
{
	public partial class frmCameraInfo : Form
	{
		private IVideoWrapper videoObject;

		public frmCameraInfo()
		{
			InitializeComponent();
		}

		internal void SetVideoObject(IVideoWrapper wrapper)
		{
			videoObject = wrapper;
		}

		private void frmCameraInfo_Load(object sender, EventArgs e)
		{
			gbxCameraInfo.Text = videoObject.DeviceName;

			lblSensorInfo.Text = videoObject.CameraSensorInfo;
			lblCCDCellSize.Text = videoObject.CameraCCDCellSize;
			lblCCDPixels.Text = videoObject.CameraCCDDimentionInPixels;
			lblFrameSize.Text = string.Format("{0} x {1}", videoObject.Width, videoObject.Height);

			lblIntegrationRange.Text = videoObject.ExposureRangeInfo;
			lblGainRange.Text = videoObject.GainRangeInfo;
			lblGammaRange.Text = videoObject.GammaRangeInfo;
		}
	}
}
