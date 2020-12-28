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
            this.toolStripSizeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssDisplayRate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProcessTime = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.meanAmount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.trackWL = new System.Windows.Forms.TrackBar();
            this.trackBL = new System.Windows.Forms.TrackBar();
            this.histogram = new System.Windows.Forms.PictureBox();
            this.lgain = new System.Windows.Forms.Label();
            this.trackGain = new System.Windows.Forms.TrackBar();
            this.expTime = new System.Windows.Forms.NumericUpDown();
            this.cbHistoEq = new System.Windows.Forms.CheckBox();
            this.nGamma = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.nContrast = new System.Windows.Forms.NumericUpDown();
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
            this.lWL = new System.Windows.Forms.Label();
            this.lBL = new System.Windows.Forms.Label();
            this.labelGain = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFrameFetcher = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sensorType = new System.Windows.Forms.ComboBox();
            this.statusStrip.SuspendLayout();
            this.msMain.SuspendLayout();
            this.pnlClient.SuspendLayout();
            this.pnlVideoFrames.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.pnlVideoControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meanAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackWL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGamma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBright)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sharpSigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharpKernel)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noisePower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiseColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiseSpatial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiseKernel)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssCameraState,
            this.tssFrameNo,
            this.toolStripSizeLabel,
            this.tssDisplayRate,
            this.toolStripProcessTime});
            this.statusStrip.Location = new System.Drawing.Point(0, 667);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1121, 24);
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
            // toolStripSizeLabel
            // 
            this.toolStripSizeLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripSizeLabel.Name = "toolStripSizeLabel";
            this.toolStripSizeLabel.Size = new System.Drawing.Size(31, 19);
            this.toolStripSizeLabel.Text = "Size";
            this.toolStripSizeLabel.Visible = false;
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
            // toolStripProcessTime
            // 
            this.toolStripProcessTime.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripProcessTime.Name = "toolStripProcessTime";
            this.toolStripProcessTime.Size = new System.Drawing.Size(78, 19);
            this.toolStripProcessTime.Text = "Process time";
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.miVideoSetup,
            this.miSettings});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(1121, 24);
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
            this.miSettings.Visible = false;
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
            this.pnlClient.Size = new System.Drawing.Size(1121, 643);
            this.pnlClient.TabIndex = 4;
            // 
            // pnlVideoFrames
            // 
            this.pnlVideoFrames.Controls.Add(this.pictureBox);
            this.pnlVideoFrames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlVideoFrames.Location = new System.Drawing.Point(0, 0);
            this.pnlVideoFrames.Name = "pnlVideoFrames";
            this.pnlVideoFrames.Size = new System.Drawing.Size(895, 643);
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
            this.pictureBox.Size = new System.Drawing.Size(895, 645);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.SizeChanged += new System.EventHandler(this.OnWindowSizeChanged);
            // 
            // pnlVideoControls
            // 
            this.pnlVideoControls.AutoScroll = true;
            this.pnlVideoControls.BackColor = System.Drawing.SystemColors.Control;
            this.pnlVideoControls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlVideoControls.Controls.Add(this.sensorType);
            this.pnlVideoControls.Controls.Add(this.label3);
            this.pnlVideoControls.Controls.Add(this.meanAmount);
            this.pnlVideoControls.Controls.Add(this.label2);
            this.pnlVideoControls.Controls.Add(this.trackWL);
            this.pnlVideoControls.Controls.Add(this.trackBL);
            this.pnlVideoControls.Controls.Add(this.histogram);
            this.pnlVideoControls.Controls.Add(this.lgain);
            this.pnlVideoControls.Controls.Add(this.trackGain);
            this.pnlVideoControls.Controls.Add(this.expTime);
            this.pnlVideoControls.Controls.Add(this.cbHistoEq);
            this.pnlVideoControls.Controls.Add(this.nGamma);
            this.pnlVideoControls.Controls.Add(this.label11);
            this.pnlVideoControls.Controls.Add(this.nContrast);
            this.pnlVideoControls.Controls.Add(this.nBright);
            this.pnlVideoControls.Controls.Add(this.groupBox3);
            this.pnlVideoControls.Controls.Add(this.groupBox1);
            this.pnlVideoControls.Controls.Add(this.label6);
            this.pnlVideoControls.Controls.Add(this.label5);
            this.pnlVideoControls.Controls.Add(this.lWL);
            this.pnlVideoControls.Controls.Add(this.lBL);
            this.pnlVideoControls.Controls.Add(this.labelGain);
            this.pnlVideoControls.Controls.Add(this.label1);
            this.pnlVideoControls.Controls.Add(this.cbFrameFetcher);
            this.pnlVideoControls.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlVideoControls.Enabled = false;
            this.pnlVideoControls.Location = new System.Drawing.Point(895, 0);
            this.pnlVideoControls.Name = "pnlVideoControls";
            this.pnlVideoControls.Size = new System.Drawing.Size(226, 643);
            this.pnlVideoControls.TabIndex = 1;
            // 
            // meanAmount
            // 
            this.meanAmount.Location = new System.Drawing.Point(128, 127);
            this.meanAmount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.meanAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.meanAmount.Name = "meanAmount";
            this.meanAmount.Size = new System.Drawing.Size(58, 20);
            this.meanAmount.TabIndex = 34;
            this.meanAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Mean exposures:";
            // 
            // trackWL
            // 
            this.trackWL.AutoSize = false;
            this.trackWL.Location = new System.Drawing.Point(15, 343);
            this.trackWL.Maximum = 255;
            this.trackWL.Name = "trackWL";
            this.trackWL.Size = new System.Drawing.Size(190, 22);
            this.trackWL.TabIndex = 32;
            this.trackWL.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackWL.Value = 255;
            this.trackWL.Scroll += new System.EventHandler(this.trackWL_Scroll);
            // 
            // trackBL
            // 
            this.trackBL.AutoSize = false;
            this.trackBL.Location = new System.Drawing.Point(15, 293);
            this.trackBL.Maximum = 255;
            this.trackBL.Name = "trackBL";
            this.trackBL.Size = new System.Drawing.Size(190, 22);
            this.trackBL.TabIndex = 31;
            this.trackBL.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBL.Scroll += new System.EventHandler(this.trackBL_Scroll);
            // 
            // histogram
            // 
            this.histogram.BackColor = System.Drawing.SystemColors.ControlDark;
            this.histogram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.histogram.Location = new System.Drawing.Point(15, 152);
            this.histogram.Name = "histogram";
            this.histogram.Size = new System.Drawing.Size(187, 114);
            this.histogram.TabIndex = 30;
            this.histogram.TabStop = false;
            // 
            // lgain
            // 
            this.lgain.AutoSize = true;
            this.lgain.Location = new System.Drawing.Point(192, 58);
            this.lgain.Name = "lgain";
            this.lgain.Size = new System.Drawing.Size(13, 13);
            this.lgain.TabIndex = 29;
            this.lgain.Text = "0";
            // 
            // trackGain
            // 
            this.trackGain.AutoSize = false;
            this.trackGain.Location = new System.Drawing.Point(89, 55);
            this.trackGain.Maximum = 100;
            this.trackGain.Name = "trackGain";
            this.trackGain.Size = new System.Drawing.Size(97, 22);
            this.trackGain.TabIndex = 28;
            this.trackGain.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackGain.Scroll += new System.EventHandler(this.trackGain_Scroll);
            // 
            // expTime
            // 
            this.expTime.DecimalPlaces = 3;
            this.expTime.Location = new System.Drawing.Point(128, 33);
            this.expTime.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.expTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.expTime.Name = "expTime";
            this.expTime.Size = new System.Drawing.Size(58, 20);
            this.expTime.TabIndex = 27;
            this.expTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.expTime.ValueChanged += new System.EventHandler(this.OnExposureTimeChanged);
            // 
            // cbHistoEq
            // 
            this.cbHistoEq.AutoSize = true;
            this.cbHistoEq.Location = new System.Drawing.Point(22, 448);
            this.cbHistoEq.Name = "cbHistoEq";
            this.cbHistoEq.Size = new System.Drawing.Size(92, 17);
            this.cbHistoEq.TabIndex = 26;
            this.cbHistoEq.Text = "Histogram Eq.";
            this.cbHistoEq.UseVisualStyleBackColor = true;
            // 
            // nGamma
            // 
            this.nGamma.Location = new System.Drawing.Point(128, 415);
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
            this.label11.Location = new System.Drawing.Point(15, 417);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Gamma [-5,5]:";
            // 
            // nContrast
            // 
            this.nContrast.Location = new System.Drawing.Point(128, 369);
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
            // nBright
            // 
            this.nBright.Location = new System.Drawing.Point(128, 392);
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
            this.groupBox3.Location = new System.Drawing.Point(15, 635);
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
            this.groupBox1.Location = new System.Drawing.Point(15, 474);
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
            this.label6.Location = new System.Drawing.Point(15, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Brightness [0,50]:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Contrast [-255,255]:";
            // 
            // lWL
            // 
            this.lWL.AutoSize = true;
            this.lWL.Location = new System.Drawing.Point(15, 327);
            this.lWL.Name = "lWL";
            this.lWL.Size = new System.Drawing.Size(48, 13);
            this.lWL.TabIndex = 7;
            this.lWL.Text = "WL: 255";
            // 
            // lBL
            // 
            this.lBL.AutoSize = true;
            this.lBL.Location = new System.Drawing.Point(15, 277);
            this.lBL.Name = "lBL";
            this.lBL.Size = new System.Drawing.Size(32, 13);
            this.lBL.TabIndex = 6;
            this.lBL.Text = "BL: 0";
            // 
            // labelGain
            // 
            this.labelGain.AutoSize = true;
            this.labelGain.Location = new System.Drawing.Point(15, 58);
            this.labelGain.Name = "labelGain";
            this.labelGain.Size = new System.Drawing.Size(32, 13);
            this.labelGain.TabIndex = 5;
            this.labelGain.Text = "Gain:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Exposure Time (sec.):";
            // 
            // cbFrameFetcher
            // 
            this.cbFrameFetcher.AutoSize = true;
            this.cbFrameFetcher.Checked = true;
            this.cbFrameFetcher.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFrameFetcher.Location = new System.Drawing.Point(15, 11);
            this.cbFrameFetcher.Name = "cbFrameFetcher";
            this.cbFrameFetcher.Size = new System.Drawing.Size(59, 17);
            this.cbFrameFetcher.TabIndex = 3;
            this.cbFrameFetcher.Text = "Enable";
            this.cbFrameFetcher.UseVisualStyleBackColor = true;
            this.cbFrameFetcher.CheckedChanged += new System.EventHandler(this.cbFrameFetcher_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Sensor:";
            // 
            // sensorType
            // 
            this.sensorType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sensorType.FormattingEnabled = true;
            this.sensorType.Items.AddRange(new object[] {
            "RGGB",
            "BGGR",
            "Monochrome"});
            this.sensorType.Location = new System.Drawing.Point(65, 80);
            this.sensorType.Name = "sensorType";
            this.sensorType.Size = new System.Drawing.Size(121, 21);
            this.sensorType.TabIndex = 36;
            this.sensorType.SelectedIndexChanged += new System.EventHandler(this.sensorType_SelectedIndexChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 691);
            this.Controls.Add(this.pnlClient);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.msMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMain;
            this.Name = "frmMain";
            this.Text = "ASCOM Video Client";
            this.SizeChanged += new System.EventHandler(this.OnWindowSizeChanged);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.pnlClient.ResumeLayout(false);
            this.pnlVideoFrames.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.pnlVideoControls.ResumeLayout(false);
            this.pnlVideoControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meanAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackWL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGamma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nContrast)).EndInit();
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
		private System.Windows.Forms.ToolStripMenuItem miVideoSetup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown noiseSpatial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown noiseKernel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbNoiseActive;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lWL;
        private System.Windows.Forms.Label lBL;
        private System.Windows.Forms.Label labelGain;
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
        private System.Windows.Forms.CheckBox cbHistoEq;
        private System.Windows.Forms.ToolStripStatusLabel toolStripSizeLabel;
        private System.Windows.Forms.TrackBar trackGain;
        private System.Windows.Forms.NumericUpDown expTime;
        private System.Windows.Forms.Label lgain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripProcessTime;
        private System.Windows.Forms.PictureBox histogram;
        private System.Windows.Forms.TrackBar trackWL;
        private System.Windows.Forms.TrackBar trackBL;
        private System.Windows.Forms.NumericUpDown meanAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sensorType;
        private System.Windows.Forms.Label label3;
    }
}

