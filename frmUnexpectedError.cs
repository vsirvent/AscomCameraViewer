//tabs=4
// --------------------------------------------------------------------------------
//
// ASCOM Video Driver - Video Client
//
// Description:	A form to show unexpected driver errors
//
// Author:		(HDP) Hristo Pavlov <hristo_dpavlov@yahoo.com>
//
// --------------------------------------------------------------------------------
//

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
	public partial class frmUnexpectedError : Form
	{
		private static frmUnexpectedError frmInstance = new frmUnexpectedError();

		public frmUnexpectedError()
		{
			InitializeComponent();
		}

		internal delegate void SetErrorMessageDelegate(string errorMessage);

		internal void SetErrorMessage(string errorMessage)
		{
			lblError.Text = errorMessage;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		public static void ShowErrorMessageInternal(string errorMessage)
		{
			if (!frmInstance.Visible)
			{
				frmInstance.SetErrorMessage(errorMessage);
				frmInstance.Show();
			}			
		}

		public static void ShowErrorMessage(string errorMessage)
		{
			if (frmInstance.InvokeRequired)
				frmInstance.Invoke(new SetErrorMessageDelegate(ShowErrorMessageInternal), new object[] {errorMessage});
			else
				ShowErrorMessageInternal(errorMessage);
		}

		public static void ShowErrorMessage(Exception error)
		{
			string message = string.Format("{0}: {1}", error.GetType(), error.Message);
			ShowErrorMessage(message);
		}

		private void frmUnexpectedError_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason != CloseReason.ApplicationExitCall &&
			    e.CloseReason != CloseReason.TaskManagerClosing &&
			    e.CloseReason != CloseReason.WindowsShutDown)
			{
				Hide();

				e.Cancel = true;
			}
		}
	}
}
