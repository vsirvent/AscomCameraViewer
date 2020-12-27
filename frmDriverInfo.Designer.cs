namespace Client
{
	partial class frmDriverInfo
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDriverInfo));
			this.gbxDriverInfo = new System.Windows.Forms.GroupBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lblDriverVersion = new System.Windows.Forms.Label();
			this.lblInterfaceVersion = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbxDeviceDescription = new System.Windows.Forms.TextBox();
			this.tbxDriverInfo = new System.Windows.Forms.TextBox();
			this.gbxDriverInfo.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbxDriverInfo
			// 
			this.gbxDriverInfo.Controls.Add(this.tbxDriverInfo);
			this.gbxDriverInfo.Controls.Add(this.tbxDeviceDescription);
			this.gbxDriverInfo.Controls.Add(this.label2);
			this.gbxDriverInfo.Controls.Add(this.label4);
			this.gbxDriverInfo.Controls.Add(this.lblInterfaceVersion);
			this.gbxDriverInfo.Controls.Add(this.label3);
			this.gbxDriverInfo.Controls.Add(this.lblDriverVersion);
			this.gbxDriverInfo.Controls.Add(this.label1);
			this.gbxDriverInfo.Location = new System.Drawing.Point(13, 8);
			this.gbxDriverInfo.Name = "gbxDriverInfo";
			this.gbxDriverInfo.Size = new System.Drawing.Size(325, 258);
			this.gbxDriverInfo.TabIndex = 0;
			this.gbxDriverInfo.TabStop = false;
			// 
			// btnClose
			// 
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnClose.Location = new System.Drawing.Point(262, 277);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 8;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Driver Version:";
			// 
			// lblDriverVersion
			// 
			this.lblDriverVersion.AutoSize = true;
			this.lblDriverVersion.ForeColor = System.Drawing.Color.Navy;
			this.lblDriverVersion.Location = new System.Drawing.Point(158, 43);
			this.lblDriverVersion.Name = "lblDriverVersion";
			this.lblDriverVersion.Size = new System.Drawing.Size(99, 13);
			this.lblDriverVersion.TabIndex = 1;
			this.lblDriverVersion.Text = "DRIVER VERSION";
			// 
			// lblInterfaceVersion
			// 
			this.lblInterfaceVersion.AutoSize = true;
			this.lblInterfaceVersion.ForeColor = System.Drawing.Color.Navy;
			this.lblInterfaceVersion.Location = new System.Drawing.Point(158, 21);
			this.lblInterfaceVersion.Name = "lblInterfaceVersion";
			this.lblInterfaceVersion.Size = new System.Drawing.Size(118, 13);
			this.lblInterfaceVersion.TabIndex = 3;
			this.lblInterfaceVersion.Text = "INTERFACE VERSION";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(18, 21);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Interface Version:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(18, 66);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Device Description:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(18, 149);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Driver Info:";
			// 
			// tbxDeviceDescription
			// 
			this.tbxDeviceDescription.BackColor = System.Drawing.SystemColors.Info;
			this.tbxDeviceDescription.Location = new System.Drawing.Point(21, 84);
			this.tbxDeviceDescription.Multiline = true;
			this.tbxDeviceDescription.Name = "tbxDeviceDescription";
			this.tbxDeviceDescription.ReadOnly = true;
			this.tbxDeviceDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbxDeviceDescription.Size = new System.Drawing.Size(283, 52);
			this.tbxDeviceDescription.TabIndex = 6;
			// 
			// tbxDriverInfo
			// 
			this.tbxDriverInfo.BackColor = System.Drawing.SystemColors.Info;
			this.tbxDriverInfo.Location = new System.Drawing.Point(21, 165);
			this.tbxDriverInfo.Multiline = true;
			this.tbxDriverInfo.Name = "tbxDriverInfo";
			this.tbxDriverInfo.ReadOnly = true;
			this.tbxDriverInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbxDriverInfo.Size = new System.Drawing.Size(283, 78);
			this.tbxDriverInfo.TabIndex = 7;
			// 
			// frmDriverInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(349, 312);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.gbxDriverInfo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmDriverInfo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Video Driver Info";
			this.Load += new System.EventHandler(this.frmDriverInfo_Load);
			this.gbxDriverInfo.ResumeLayout(false);
			this.gbxDriverInfo.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbxDriverInfo;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label lblInterfaceVersion;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblDriverVersion;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbxDriverInfo;
		private System.Windows.Forms.TextBox tbxDeviceDescription;
		private System.Windows.Forms.Label label2;
	}
}