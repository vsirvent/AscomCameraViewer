namespace Client
{
	partial class frmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tssCameraState = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssFrameNo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssDisplayRate = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssRecordingFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.miDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.miCameraInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.miDriverInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miVideoSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.miSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlClient = new System.Windows.Forms.Panel();
            this.pnlVideoFrames = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.pnlVideoControls = new System.Windows.Forms.Panel();
            this.nBright = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sharpSigma = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.sharpKernel = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.bSharp = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.noisePower = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.noiseColor = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.noiseSpatial = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.noiseKernel = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.cbNoiseActive = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFrameFetcher = new System.Windows.Forms.CheckBox();
            this.nContrast = new System.Windows.Forms.NumericUpDown();
            this.nGamma = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.nBlack = new System.Windows.Forms.NumericUpDown();
            this.nWhite = new System.Windows.Forms.NumericUpDown();
            this.cbHistoEq = new System.Windows.Forms.CheckBox();
            this.statusStrip.SuspendLayout();
            this.msMain.SuspendLayout();
            this.pnlClient.SuspendLayout();
            this.pnlVideoFrames.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.pnlVideoControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nBright)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sharpSigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharpKernel)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noisePower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiseColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiseSpatial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiseKernel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGamma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWhite)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssCameraState,
            this.tssFrameNo,
            this.tssDisplayRate,
            this.tssRecordingFile});
            this.statusStrip.Location = new System.Drawing.Point(0, 506);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(873, 24);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tssCameraState
            // 
            this.tssCameraState.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tssCameraState.Name = "tssCameraState";
            this.tssCameraState.Size = new System.Drawing.Size(83, 19);
            this.tssCameraState.Text = "Disconnected";
            // 
            // tssFrameNo
            // 
            this.tssFrameNo.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tssFrameNo.Name = "tssFrameNo";
            this.tssFrameNo.Size = new System.Drawing.Size(63, 19);
            this.tssFrameNo.Text = "Frame No";
            this.tssFrameNo.Visible = false;
            // 
            // tssDisplayRate
            // 
            this.tssDisplayRate.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tssDisplayRate.Name = "tssDisplayRate";
            this.tssDisplayRate.Size = new System.Drawing.Size(75, 19);
            this.tssDisplayRate.Text = "Display Rate";
            this.tssDisplayRate.Visible = false;
            // 
            // tssRecordingFile
            // 
            this.tssRecordingFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tssRecordingFile.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tssRecordingFile.Name = "tssRecordingFile";
            this.tssRecordingFile.Size = new System.Drawing.Size(76, 19);
            this.tssRecordingFile.Text = "File (xxx Mb)";
            this.tssRecordingFile.Visible = false;
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.miVideoSetup,
            this.miSettings});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(873, 24);
            this.msMain.TabIndex = 2;
            this.msMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miConnect,
            this.miDisconnect,
            this.toolStripSeparator2,
            this.miCameraInfo,
            this.miDriverInfo,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.fileToolStripMenuItem.Text = "&Video Camera";
            // 
            // miConnect
            // 
            this.miConnect.Name = "miConnect";
            this.miConnect.Size = new System.Drawing.Size(139, 22);
            this.miConnect.Text = "&Connect";
            this.miConnect.Click += new System.EventHandler(this.miConnect_Click);
            // 
            // miDisconnect
            // 
            this.miDisconnect.Enabled = false;
            this.miDisconnect.Name = "miDisconnect";
            this.miDisconnect.Size = new System.Drawing.Size(139, 22);
            this.miDisconnect.Text = "&Disconnect";
            this.miDisconnect.Click += new System.EventHandler(this.miDisconnect_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(136, 6);
            // 
            // miCameraInfo
            // 
            this.miCameraInfo.Enabled = false;
            this.miCameraInfo.Name = "miCameraInfo";
            this.miCameraInfo.Size = new System.Drawing.Size(139, 22);
            this.miCameraInfo.Text = "Ca&mera Info";
            this.miCameraInfo.Click += new System.EventHandler(this.miCameraInfo_Click);
            // 
            // miDriverInfo
            // 
            this.miDriverInfo.Enabled = false;
            this.miDriverInfo.Name = "miDriverInfo";
            this.miDriverInfo.Size = new System.Drawing.Size(139, 22);
            this.miDriverInfo.Text = "Dri&ver Info";
            this.miDriverInfo.Click += new System.EventHandler(this.miDriverInfo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(136, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // miVideoSetup
            // 
            this.miVideoSetup.Enabled = false;
            this.miVideoSetup.Name = "miVideoSetup";
            this.miVideoSetup.Size = new System.Drawing.Size(82, 20);
            this.miVideoSetup.Text = "Video Setup";
            this.miVideoSetup.Click += new System.EventHandler(this.miVideoSetup_Click);
            // 
            // miSettings
            // 
            this.miSettings.Name = "miSettings";
            this.miSettings.Size = new System.Drawing.Size(61, 20);
            this.miSettings.Text = "&Settings";
            this.miSettings.Click += new System.EventHandler(this.miConfigure_Click);
            // 
            // pnlClient
            // 
            this.pnlClient.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlClient.Controls.Add(this.pnlVideoFrames);
            this.pnlClient.Controls.Add(this.pnlVideoControls);
            this.pnlClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlClient.Location = new System.Drawing.Point(0, 24);
            this.pnlClient.Name = "pnlClient";
            this.pnlClient.Size = new System.Drawing.Size(873, 482);
            this.pnlClient.TabIndex = 4;
            // 
            // pnlVideoFrames
            // 
            this.pnlVideoFrames.Controls.Add(this.pictureBox);
            this.pnlVideoFrames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlVideoFrames.Location = new System.Drawing.Point(0, 0);
            this.pnlVideoFrames.Name = "pnlVideoFrames";
            this.pnlVideoFrames.Size = new System.Drawing.Size(647, 482);
            this.pnlVideoFrames.TabIndex = 2;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(647, 484);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // pnlVideoControls
            // 
            this.pnlVideoControls.AutoScroll = true;
            this.pnlVideoControls.BackColor = System.Drawing.SystemColors.Control;
            this.pnlVideoControls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlVideoControls.Controls.Add(this.cbHistoEq);
            this.pnlVideoControls.Controls.Add(this.nWhite);
            this.pnlVideoControls.Controls.Add(this.nBlack);
            this.pnlVideoControls.Controls.Add(this.nGamma);
            this.pnlVideoControls.Controls.Add(this.label11);
            this.pnlVideoControls.Controls.Add(this.nContrast);
            this.pnlVideoControls.Controls.Add(this.nBright);
            this.pnlVideoControls.Controls.Add(this.groupBox3);
            this.pnlVideoControls.Controls.Add(this.groupBox1);
            this.pnlVideoControls.Controls.Add(this.label6);
            this.pnlVideoControls.Controls.Add(this.label5);
            this.pnlVideoControls.Controls.Add(this.label4);
            this.pnlVideoControls.Controls.Add(this.label3);
            this.pnlVideoControls.Controls.Add(this.label2);
            this.pnlVideoControls.Controls.Add(this.label1);
            this.pnlVideoControls.Controls.Add(this.cbFrameFetcher);
            this.pnlVideoControls.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlVideoControls.Enabled = false;
            this.pnlVideoControls.Location = new System.Drawing.Point(647, 0);
            this.pnlVideoControls.Name = "pnlVideoControls";
            this.pnlVideoControls.Size = new System.Drawing.Size(226, 482);
            this.pnlVideoControls.TabIndex = 1;
            // 
            // nBright
            // 
            this.nBright.Location = new System.Drawing.Point(128, 148);
            this.nBright.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nBright.Name = "nBright";
            this.nBright.Size = new System.Drawing.Size(58, 20);
            this.nBright.TabIndex = 20;
            this.nBright.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sharpSigma);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.sharpKernel);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.bSharp);
            this.groupBox3.Location = new System.Drawing.Point(15, 384);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(178, 91);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sharpen";
            // 
            // sharpSigma
            // 
            this.sharpSigma.Location = new System.Drawing.Point(113, 63);
            this.sharpSigma.Name = "sharpSigma";
            this.sharpSigma.Size = new System.Drawing.Size(58, 20);
            this.sharpSigma.TabIndex = 14;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 66);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 13);
            this.label17.TabIndex = 13;
            this.label17.Text = "Sigma:";
            // 
            // sharpKernel
            // 
            this.sharpKernel.Location = new System.Drawing.Point(113, 36);
            this.sharpKernel.Name = "sharpKernel";
            this.sharpKernel.Size = new System.Drawing.Size(58, 20);
            this.sharpKernel.TabIndex = 12;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 39);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 13);
            this.label18.TabIndex = 11;
            this.label18.Text = "Kernel Size:";
            // 
            // bSharp
            // 
            this.bSharp.AutoSize = true;
            this.bSharp.Location = new System.Drawing.Point(8, 19);
            this.bSharp.Name = "bSharp";
            this.bSharp.Size = new System.Drawing.Size(56, 17);
            this.bSharp.TabIndex = 10;
            this.bSharp.Text = "Active";
            this.bSharp.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.noisePower);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.noiseColor);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.noiseSpatial);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.noiseKernel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbNoiseActive);
            this.groupBox1.Location = new System.Drawing.Point(15, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 155);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Noise reduction";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // noisePower
            // 
            this.noisePower.Location = new System.Drawing.Point(113, 118);
            this.noisePower.Name = "noisePower";
            this.noisePower.Size = new System.Drawing.Size(58, 20);
            this.noisePower.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Color Power:";
            // 
            // noiseColor
            // 
            this.noiseColor.Location = new System.Drawing.Point(113, 91);
            this.noiseColor.Name = "noiseColor";
            this.noiseColor.Size = new System.Drawing.Size(58, 20);
            this.noiseColor.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Color Factor:";
            // 
            // noiseSpatial
            // 
            this.noiseSpatial.Location = new System.Drawing.Point(113, 63);
            this.noiseSpatial.Name = "noiseSpatial";
            this.noiseSpatial.Size = new System.Drawing.Size(58, 20);
            this.noiseSpatial.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Spatial Factor:";
            // 
            // noiseKernel
            // 
            this.noiseKernel.Location = new System.Drawing.Point(113, 36);
            this.noiseKernel.Name = "noiseKernel";
            this.noiseKernel.Size = new System.Drawing.Size(58, 20);
            this.noiseKernel.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Kernel Size:";
            // 
            // cbNoiseActive
            // 
            this.cbNoiseActive.AutoSize = true;
            this.cbNoiseActive.Location = new System.Drawing.Point(8, 19);
            this.cbNoiseActive.Name = "cbNoiseActive";
            this.cbNoiseActive.Size = new System.Drawing.Size(56, 17);
            this.cbNoiseActive.TabIndex = 10;
            this.cbNoiseActive.Text = "Active";
            this.cbNoiseActive.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Brightness [0,50]:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Contrast [-255,255]:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "White Level:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Black Level:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Gain:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Exposure Time:";
            // 
            // cbFrameFetcher
            // 
            this.cbFrameFetcher.AutoSize = true;
            this.cbFrameFetcher.Checked = true;
            this.cbFrameFetcher.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFrameFetcher.Location = new System.Drawing.Point(15, 11);
            this.cbFrameFetcher.Name = "cbFrameFetcher";
            this.cbFrameFetcher.Size = new System.Drawing.Size(64, 17);
            this.cbFrameFetcher.TabIndex = 3;
            this.cbFrameFetcher.Text = "Preview";
            this.cbFrameFetcher.UseVisualStyleBackColor = true;
            this.cbFrameFetcher.CheckedChanged += new System.EventHandler(this.cbFrameFetcher_CheckedChanged);
            // 
            // nContrast
            // 
            this.nContrast.Location = new System.Drawing.Point(128, 124);
            this.nContrast.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nContrast.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.nContrast.Name = "nContrast";
            this.nContrast.Size = new System.Drawing.Size(58, 20);
            this.nContrast.TabIndex = 21;
            // 
            // nGamma
            // 
            this.nGamma.Location = new System.Drawing.Point(128, 172);
            this.nGamma.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nGamma.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.nGamma.Name = "nGamma";
            this.nGamma.Size = new System.Drawing.Size(58, 20);
            this.nGamma.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Gamma [-5,5]:";
            // 
            // nBlack
            // 
            this.nBlack.Location = new System.Drawing.Point(128, 76);
            this.nBlack.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nBlack.Name = "nBlack";
            this.nBlack.Size = new System.Drawing.Size(58, 20);
            this.nBlack.TabIndex = 24;
            // 
            // nWhite
            // 
            this.nWhite.Location = new System.Drawing.Point(128, 100);
            this.nWhite.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nWhite.Name = "nWhite";
            this.nWhite.Size = new System.Drawing.Size(58, 20);
            this.nWhite.TabIndex = 25;
            this.nWhite.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // cbHistoEq
            // 
            this.cbHistoEq.AutoSize = true;
            this.cbHistoEq.Location = new System.Drawing.Point(22, 200);
            this.cbHistoEq.Name = "cbHistoEq";
            this.cbHistoEq.Size = new System.Drawing.Size(92, 17);
            this.cbHistoEq.TabIndex = 26;
            this.cbHistoEq.Text = "Histogram Eq.";
            this.cbHistoEq.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 530);
            this.Controls.Add(this.pnlClient);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.msMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMain;
            this.Name = "frmMain";
            this.Text = "ASCOM Video Client";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.pnlClient.ResumeLayout(false);
            this.pnlVideoFrames.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.pnlVideoControls.ResumeLayout(false);
            this.pnlVideoControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nBright)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sharpSigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharpKernel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noisePower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiseColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiseSpatial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiseKernel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGamma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWhite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.MenuStrip msMain;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.Panel pnlClient;
		private System.Windows.Forms.Panel pnlVideoControls;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.ToolStripMenuItem miSettings;
		private System.Windows.Forms.ToolStripMenuItem miConnect;
		private System.Windows.Forms.ToolStripMenuItem miDisconnect;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripStatusLabel tssDisplayRate;
		private System.Windows.Forms.ToolStripStatusLabel tssFrameNo;
		private System.Windows.Forms.CheckBox cbFrameFetcher;
		private System.Windows.Forms.ToolStripStatusLabel tssCameraState;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem miCameraInfo;
		private System.Windows.Forms.ToolStripMenuItem miDriverInfo;
		private System.Windows.Forms.Panel pnlVideoFrames;
		private System.Windows.Forms.ToolStripStatusLabel tssRecordingFile;
		private System.Windows.Forms.ToolStripMenuItem miVideoSetup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown noiseSpatial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown noiseKernel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbNoiseActive;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown noisePower;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown noiseColor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown sharpSigma;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown sharpKernel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox bSharp;
        private System.Windows.Forms.NumericUpDown nBright;
        private System.Windows.Forms.NumericUpDown nContrast;
        private System.Windows.Forms.NumericUpDown nGamma;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nWhite;
        private System.Windows.Forms.NumericUpDown nBlack;
        private System.Windows.Forms.CheckBox cbHistoEq;
    }
}

