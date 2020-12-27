using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Client.Properties;

namespace Client
{
	public partial class frmSettings : Form
	{
		public frmSettings()
		{
			InitializeComponent();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			Settings.Default.Save();

			DialogResult = DialogResult.OK;
			Close();
		}

		private void btnBrowseOutputFolder_Click(object sender, EventArgs e)
		{
		}
	}
}
