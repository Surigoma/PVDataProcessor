namespace PVDataProcessor
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.A_S_OutputDirectory = new System.Windows.Forms.CheckBox();
            this.A_S_ProcessingDirectory = new System.Windows.Forms.CheckBox();
            this.A_Calculation = new System.Windows.Forms.GroupBox();
            this.A_C_OutputDirectoryOpen = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.A_C_OutputDirectoryPath = new System.Windows.Forms.TextBox();
            this.A_C_DirectoryOpen = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.A_C_DirectoryPath = new System.Windows.Forms.TextBox();
            this.A_ValidCutter = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.A_V_Threshold = new System.Windows.Forms.TextBox();
            this.A_V_OverWrite = new System.Windows.Forms.CheckBox();
            this.A_V_OutputDirectoryOpen = new System.Windows.Forms.Button();
            this.A_V_DirectoryOpen = new System.Windows.Forms.Button();
            this.A_V_OutputDirectoryPath = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.A_V_DirectoryPath = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.A_FileCutter = new System.Windows.Forms.GroupBox();
            this.A_F_CSVFileOpen = new System.Windows.Forms.Button();
            this.A_F_StartDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.A_F_OutputDirectoryOpen = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.A_F_FileNamePattern = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.A_F_OutputDirectoryPath = new System.Windows.Forms.TextBox();
            this.A_F_CSVFilePath = new System.Windows.Forms.TextBox();
            this.A_Processing = new System.Windows.Forms.GroupBox();
            this.A_P_Calculation = new System.Windows.Forms.CheckBox();
            this.A_P_ValidCutter = new System.Windows.Forms.CheckBox();
            this.A_P_FileCutter = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.F_OutputDirectoryOpen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.F_FileNamePattern = new System.Windows.Forms.TextBox();
            this.F_OutputDirectroyPath = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.F_CSVFilePath = new System.Windows.Forms.TextBox();
            this.F_StartDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.F_CSVFileOpen = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.V_OutputDirecrotyOpen = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.V_OverWrite = new System.Windows.Forms.CheckBox();
            this.V_OutputDirectoryPath = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.V_DirectoryOpen = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.V_Threshold = new System.Windows.Forms.TextBox();
            this.V_DirectoryPath = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.C_OutputDirectoryOpen = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.C_OutputDirectoryPath = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.C_DirectoryOpen = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.C_DirectoryPath = new System.Windows.Forms.TextBox();
            this.Process = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.A_Calculation.SuspendLayout();
            this.A_ValidCutter.SuspendLayout();
            this.A_FileCutter.SuspendLayout();
            this.A_Processing.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(620, 472);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.A_Calculation);
            this.tabPage1.Controls.Add(this.A_ValidCutter);
            this.tabPage1.Controls.Add(this.A_FileCutter);
            this.tabPage1.Controls.Add(this.A_Processing);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(612, 446);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "AutoProcessing";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.A_S_OutputDirectory);
            this.groupBox1.Controls.Add(this.A_S_ProcessingDirectory);
            this.groupBox1.Location = new System.Drawing.Point(150, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 84);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sync";
            // 
            // A_S_OutputDirectory
            // 
            this.A_S_OutputDirectory.AutoSize = true;
            this.A_S_OutputDirectory.Location = new System.Drawing.Point(6, 40);
            this.A_S_OutputDirectory.Name = "A_S_OutputDirectory";
            this.A_S_OutputDirectory.Size = new System.Drawing.Size(136, 16);
            this.A_S_OutputDirectory.TabIndex = 18;
            this.A_S_OutputDirectory.Text = "Output Directory Path";
            this.A_S_OutputDirectory.UseVisualStyleBackColor = true;
            this.A_S_OutputDirectory.CheckedChanged += new System.EventHandler(this.A_S_OutputDirectory_CheckedChanged);
            // 
            // A_S_ProcessingDirectory
            // 
            this.A_S_ProcessingDirectory.AutoSize = true;
            this.A_S_ProcessingDirectory.Location = new System.Drawing.Point(6, 18);
            this.A_S_ProcessingDirectory.Name = "A_S_ProcessingDirectory";
            this.A_S_ProcessingDirectory.Size = new System.Drawing.Size(158, 16);
            this.A_S_ProcessingDirectory.TabIndex = 18;
            this.A_S_ProcessingDirectory.Text = "Processing Directory Path";
            this.A_S_ProcessingDirectory.UseVisualStyleBackColor = true;
            this.A_S_ProcessingDirectory.CheckedChanged += new System.EventHandler(this.A_S_ProcessingDirectory_CheckedChanged);
            // 
            // A_Calculation
            // 
            this.A_Calculation.Controls.Add(this.A_C_OutputDirectoryOpen);
            this.A_Calculation.Controls.Add(this.label15);
            this.A_Calculation.Controls.Add(this.A_C_OutputDirectoryPath);
            this.A_Calculation.Controls.Add(this.A_C_DirectoryOpen);
            this.A_Calculation.Controls.Add(this.label16);
            this.A_Calculation.Controls.Add(this.A_C_DirectoryPath);
            this.A_Calculation.Enabled = false;
            this.A_Calculation.Location = new System.Drawing.Point(6, 357);
            this.A_Calculation.Name = "A_Calculation";
            this.A_Calculation.Size = new System.Drawing.Size(600, 80);
            this.A_Calculation.TabIndex = 19;
            this.A_Calculation.TabStop = false;
            this.A_Calculation.Text = "Calculation";
            // 
            // A_C_OutputDirectoryOpen
            // 
            this.A_C_OutputDirectoryOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.A_C_OutputDirectoryOpen.Location = new System.Drawing.Point(552, 47);
            this.A_C_OutputDirectoryOpen.Name = "A_C_OutputDirectoryOpen";
            this.A_C_OutputDirectoryOpen.Size = new System.Drawing.Size(42, 23);
            this.A_C_OutputDirectoryOpen.TabIndex = 22;
            this.A_C_OutputDirectoryOpen.Text = "Save";
            this.A_C_OutputDirectoryOpen.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 12);
            this.label15.TabIndex = 20;
            this.label15.Text = "DirectoryPath";
            // 
            // A_C_OutputDirectoryPath
            // 
            this.A_C_OutputDirectoryPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.A_C_OutputDirectoryPath.Location = new System.Drawing.Point(98, 49);
            this.A_C_OutputDirectoryPath.Name = "A_C_OutputDirectoryPath";
            this.A_C_OutputDirectoryPath.Size = new System.Drawing.Size(448, 19);
            this.A_C_OutputDirectoryPath.TabIndex = 18;
            // 
            // A_C_DirectoryOpen
            // 
            this.A_C_DirectoryOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.A_C_DirectoryOpen.Location = new System.Drawing.Point(552, 18);
            this.A_C_DirectoryOpen.Name = "A_C_DirectoryOpen";
            this.A_C_DirectoryOpen.Size = new System.Drawing.Size(42, 23);
            this.A_C_DirectoryOpen.TabIndex = 21;
            this.A_C_DirectoryOpen.Text = "Open";
            this.A_C_DirectoryOpen.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 52);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 12);
            this.label16.TabIndex = 19;
            this.label16.Text = "OutputDirectory";
            // 
            // A_C_DirectoryPath
            // 
            this.A_C_DirectoryPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.A_C_DirectoryPath.Location = new System.Drawing.Point(98, 20);
            this.A_C_DirectoryPath.Name = "A_C_DirectoryPath";
            this.A_C_DirectoryPath.Size = new System.Drawing.Size(448, 19);
            this.A_C_DirectoryPath.TabIndex = 17;
            // 
            // A_ValidCutter
            // 
            this.A_ValidCutter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.A_ValidCutter.Controls.Add(this.label18);
            this.A_ValidCutter.Controls.Add(this.A_V_Threshold);
            this.A_ValidCutter.Controls.Add(this.A_V_OverWrite);
            this.A_ValidCutter.Controls.Add(this.A_V_OutputDirectoryOpen);
            this.A_ValidCutter.Controls.Add(this.A_V_DirectoryOpen);
            this.A_ValidCutter.Controls.Add(this.A_V_OutputDirectoryPath);
            this.A_ValidCutter.Controls.Add(this.label13);
            this.A_ValidCutter.Controls.Add(this.A_V_DirectoryPath);
            this.A_ValidCutter.Controls.Add(this.label14);
            this.A_ValidCutter.Enabled = false;
            this.A_ValidCutter.Location = new System.Drawing.Point(6, 225);
            this.A_ValidCutter.Name = "A_ValidCutter";
            this.A_ValidCutter.Size = new System.Drawing.Size(600, 126);
            this.A_ValidCutter.TabIndex = 18;
            this.A_ValidCutter.TabStop = false;
            this.A_ValidCutter.Text = "ValidCutter";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 50);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 12);
            this.label18.TabIndex = 20;
            this.label18.Text = "Threshold";
            // 
            // A_V_Threshold
            // 
            this.A_V_Threshold.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.A_V_Threshold.Location = new System.Drawing.Point(101, 47);
            this.A_V_Threshold.Name = "A_V_Threshold";
            this.A_V_Threshold.Size = new System.Drawing.Size(493, 19);
            this.A_V_Threshold.TabIndex = 19;
            this.A_V_Threshold.TextChanged += new System.EventHandler(this.A_V_Threshold_TextChanged);
            // 
            // A_V_OverWrite
            // 
            this.A_V_OverWrite.AutoSize = true;
            this.A_V_OverWrite.Location = new System.Drawing.Point(8, 74);
            this.A_V_OverWrite.Name = "A_V_OverWrite";
            this.A_V_OverWrite.Size = new System.Drawing.Size(74, 16);
            this.A_V_OverWrite.TabIndex = 18;
            this.A_V_OverWrite.Text = "OverWrite";
            this.A_V_OverWrite.UseVisualStyleBackColor = true;
            this.A_V_OverWrite.CheckedChanged += new System.EventHandler(this.A_V_OverWrite_CheckedChanged);
            // 
            // A_V_OutputDirectoryOpen
            // 
            this.A_V_OutputDirectoryOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.A_V_OutputDirectoryOpen.Location = new System.Drawing.Point(552, 94);
            this.A_V_OutputDirectoryOpen.Name = "A_V_OutputDirectoryOpen";
            this.A_V_OutputDirectoryOpen.Size = new System.Drawing.Size(42, 23);
            this.A_V_OutputDirectoryOpen.TabIndex = 16;
            this.A_V_OutputDirectoryOpen.Text = "Save";
            this.A_V_OutputDirectoryOpen.UseVisualStyleBackColor = true;
            this.A_V_OutputDirectoryOpen.Click += new System.EventHandler(this.A_V_OutputDirectoryOpen_Click);
            // 
            // A_V_DirectoryOpen
            // 
            this.A_V_DirectoryOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.A_V_DirectoryOpen.Location = new System.Drawing.Point(552, 18);
            this.A_V_DirectoryOpen.Name = "A_V_DirectoryOpen";
            this.A_V_DirectoryOpen.Size = new System.Drawing.Size(42, 23);
            this.A_V_DirectoryOpen.TabIndex = 17;
            this.A_V_DirectoryOpen.Text = "Open";
            this.A_V_DirectoryOpen.UseVisualStyleBackColor = true;
            this.A_V_DirectoryOpen.Click += new System.EventHandler(this.A_V_DirectoryOpen_Click);
            // 
            // A_V_OutputDirectoryPath
            // 
            this.A_V_OutputDirectoryPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.A_V_OutputDirectoryPath.Location = new System.Drawing.Point(101, 96);
            this.A_V_OutputDirectoryPath.Name = "A_V_OutputDirectoryPath";
            this.A_V_OutputDirectoryPath.Size = new System.Drawing.Size(445, 19);
            this.A_V_OutputDirectoryPath.TabIndex = 12;
            this.A_V_OutputDirectoryPath.TextChanged += new System.EventHandler(this.A_V_OutputDirectoryPath_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 12);
            this.label13.TabIndex = 14;
            this.label13.Text = "OutputDirectory";
            // 
            // A_V_DirectoryPath
            // 
            this.A_V_DirectoryPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.A_V_DirectoryPath.Location = new System.Drawing.Point(101, 20);
            this.A_V_DirectoryPath.Name = "A_V_DirectoryPath";
            this.A_V_DirectoryPath.Size = new System.Drawing.Size(445, 19);
            this.A_V_DirectoryPath.TabIndex = 13;
            this.A_V_DirectoryPath.TextChanged += new System.EventHandler(this.A_V_DirectoryPath_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 12);
            this.label14.TabIndex = 15;
            this.label14.Text = "DirectoryPath";
            // 
            // A_FileCutter
            // 
            this.A_FileCutter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.A_FileCutter.Controls.Add(this.A_F_CSVFileOpen);
            this.A_FileCutter.Controls.Add(this.A_F_StartDate);
            this.A_FileCutter.Controls.Add(this.label8);
            this.A_FileCutter.Controls.Add(this.A_F_OutputDirectoryOpen);
            this.A_FileCutter.Controls.Add(this.label7);
            this.A_FileCutter.Controls.Add(this.label6);
            this.A_FileCutter.Controls.Add(this.A_F_FileNamePattern);
            this.A_FileCutter.Controls.Add(this.label1);
            this.A_FileCutter.Controls.Add(this.A_F_OutputDirectoryPath);
            this.A_FileCutter.Controls.Add(this.A_F_CSVFilePath);
            this.A_FileCutter.Enabled = false;
            this.A_FileCutter.Location = new System.Drawing.Point(6, 96);
            this.A_FileCutter.Name = "A_FileCutter";
            this.A_FileCutter.Size = new System.Drawing.Size(600, 123);
            this.A_FileCutter.TabIndex = 17;
            this.A_FileCutter.TabStop = false;
            this.A_FileCutter.Text = "FileCutter";
            // 
            // A_F_CSVFileOpen
            // 
            this.A_F_CSVFileOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.A_F_CSVFileOpen.Location = new System.Drawing.Point(552, 18);
            this.A_F_CSVFileOpen.Name = "A_F_CSVFileOpen";
            this.A_F_CSVFileOpen.Size = new System.Drawing.Size(42, 23);
            this.A_F_CSVFileOpen.TabIndex = 15;
            this.A_F_CSVFileOpen.Text = "Open";
            this.A_F_CSVFileOpen.UseVisualStyleBackColor = true;
            this.A_F_CSVFileOpen.Click += new System.EventHandler(this.A_F_CSVFileOpen_Click);
            // 
            // A_F_StartDate
            // 
            this.A_F_StartDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.A_F_StartDate.Location = new System.Drawing.Point(101, 45);
            this.A_F_StartDate.Name = "A_F_StartDate";
            this.A_F_StartDate.Size = new System.Drawing.Size(493, 19);
            this.A_F_StartDate.TabIndex = 16;
            this.A_F_StartDate.ValueChanged += new System.EventHandler(this.A_F_StartDate_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "CSVFile";
            // 
            // A_F_OutputDirectoryOpen
            // 
            this.A_F_OutputDirectoryOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.A_F_OutputDirectoryOpen.Location = new System.Drawing.Point(552, 68);
            this.A_F_OutputDirectoryOpen.Name = "A_F_OutputDirectoryOpen";
            this.A_F_OutputDirectoryOpen.Size = new System.Drawing.Size(42, 23);
            this.A_F_OutputDirectoryOpen.TabIndex = 14;
            this.A_F_OutputDirectoryOpen.Text = "Save";
            this.A_F_OutputDirectoryOpen.UseVisualStyleBackColor = true;
            this.A_F_OutputDirectoryOpen.Click += new System.EventHandler(this.A_F_OutputDirectoryOpen_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "LoggingStartDay";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "OutputDirectory";
            // 
            // A_F_FileNamePattern
            // 
            this.A_F_FileNamePattern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.A_F_FileNamePattern.Location = new System.Drawing.Point(101, 95);
            this.A_F_FileNamePattern.Name = "A_F_FileNamePattern";
            this.A_F_FileNamePattern.Size = new System.Drawing.Size(493, 19);
            this.A_F_FileNamePattern.TabIndex = 7;
            this.A_F_FileNamePattern.TextChanged += new System.EventHandler(this.A_F_FileNamePattern_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "FileNamePattern";
            // 
            // A_F_OutputDirectoryPath
            // 
            this.A_F_OutputDirectoryPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.A_F_OutputDirectoryPath.Location = new System.Drawing.Point(101, 70);
            this.A_F_OutputDirectoryPath.Name = "A_F_OutputDirectoryPath";
            this.A_F_OutputDirectoryPath.Size = new System.Drawing.Size(445, 19);
            this.A_F_OutputDirectoryPath.TabIndex = 8;
            this.A_F_OutputDirectoryPath.TextChanged += new System.EventHandler(this.A_F_OutputDirectoryPath_TextChanged);
            // 
            // A_F_CSVFilePath
            // 
            this.A_F_CSVFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.A_F_CSVFilePath.Location = new System.Drawing.Point(101, 20);
            this.A_F_CSVFilePath.Name = "A_F_CSVFilePath";
            this.A_F_CSVFilePath.Size = new System.Drawing.Size(445, 19);
            this.A_F_CSVFilePath.TabIndex = 9;
            this.A_F_CSVFilePath.TextChanged += new System.EventHandler(this.A_F_CSVFilePath_TextChanged);
            // 
            // A_Processing
            // 
            this.A_Processing.Controls.Add(this.A_P_Calculation);
            this.A_Processing.Controls.Add(this.A_P_ValidCutter);
            this.A_Processing.Controls.Add(this.A_P_FileCutter);
            this.A_Processing.Location = new System.Drawing.Point(6, 6);
            this.A_Processing.Name = "A_Processing";
            this.A_Processing.Size = new System.Drawing.Size(138, 84);
            this.A_Processing.TabIndex = 0;
            this.A_Processing.TabStop = false;
            this.A_Processing.Text = "Processing";
            // 
            // A_P_Calculation
            // 
            this.A_P_Calculation.AutoSize = true;
            this.A_P_Calculation.Location = new System.Drawing.Point(6, 62);
            this.A_P_Calculation.Name = "A_P_Calculation";
            this.A_P_Calculation.Size = new System.Drawing.Size(81, 16);
            this.A_P_Calculation.TabIndex = 0;
            this.A_P_Calculation.Text = "Calculation";
            this.A_P_Calculation.UseVisualStyleBackColor = true;
            this.A_P_Calculation.CheckedChanged += new System.EventHandler(this.A_P_Calculation_CheckedChanged);
            // 
            // A_P_ValidCutter
            // 
            this.A_P_ValidCutter.AutoSize = true;
            this.A_P_ValidCutter.Location = new System.Drawing.Point(6, 40);
            this.A_P_ValidCutter.Name = "A_P_ValidCutter";
            this.A_P_ValidCutter.Size = new System.Drawing.Size(82, 16);
            this.A_P_ValidCutter.TabIndex = 0;
            this.A_P_ValidCutter.Text = "ValidCutter";
            this.A_P_ValidCutter.UseVisualStyleBackColor = true;
            this.A_P_ValidCutter.CheckedChanged += new System.EventHandler(this.A_P_ValidCutter_CheckedChanged);
            // 
            // A_P_FileCutter
            // 
            this.A_P_FileCutter.AutoSize = true;
            this.A_P_FileCutter.Location = new System.Drawing.Point(6, 18);
            this.A_P_FileCutter.Name = "A_P_FileCutter";
            this.A_P_FileCutter.Size = new System.Drawing.Size(75, 16);
            this.A_P_FileCutter.TabIndex = 0;
            this.A_P_FileCutter.Text = "FileCutter";
            this.A_P_FileCutter.UseVisualStyleBackColor = true;
            this.A_P_FileCutter.CheckedChanged += new System.EventHandler(this.A_P_FileCutter_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(612, 446);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "FileCutter";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.F_OutputDirectoryOpen);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.F_FileNamePattern);
            this.groupBox5.Controls.Add(this.F_OutputDirectroyPath);
            this.groupBox5.Location = new System.Drawing.Point(6, 88);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(600, 74);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Output";
            // 
            // F_OutputDirectoryOpen
            // 
            this.F_OutputDirectoryOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.F_OutputDirectoryOpen.Location = new System.Drawing.Point(552, 18);
            this.F_OutputDirectoryOpen.Name = "F_OutputDirectoryOpen";
            this.F_OutputDirectoryOpen.Size = new System.Drawing.Size(42, 23);
            this.F_OutputDirectoryOpen.TabIndex = 5;
            this.F_OutputDirectoryOpen.Text = "Save";
            this.F_OutputDirectoryOpen.UseVisualStyleBackColor = true;
            this.F_OutputDirectoryOpen.Click += new System.EventHandler(this.F_OutputDirectoryOpen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "OutputDirectory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "FileNamePattern";
            // 
            // F_FileNamePattern
            // 
            this.F_FileNamePattern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.F_FileNamePattern.Location = new System.Drawing.Point(98, 45);
            this.F_FileNamePattern.Name = "F_FileNamePattern";
            this.F_FileNamePattern.Size = new System.Drawing.Size(496, 19);
            this.F_FileNamePattern.TabIndex = 3;
            this.F_FileNamePattern.TextChanged += new System.EventHandler(this.F_FileNamePattern_TextChanged);
            // 
            // F_OutputDirectroyPath
            // 
            this.F_OutputDirectroyPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.F_OutputDirectroyPath.Location = new System.Drawing.Point(98, 20);
            this.F_OutputDirectroyPath.Name = "F_OutputDirectroyPath";
            this.F_OutputDirectroyPath.Size = new System.Drawing.Size(448, 19);
            this.F_OutputDirectroyPath.TabIndex = 3;
            this.F_OutputDirectroyPath.TextChanged += new System.EventHandler(this.F_OutputDirectoryPath_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.F_CSVFilePath);
            this.groupBox4.Controls.Add(this.F_StartDate);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.F_CSVFileOpen);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(600, 76);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Input";
            // 
            // F_CSVFilePath
            // 
            this.F_CSVFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.F_CSVFilePath.Location = new System.Drawing.Point(101, 20);
            this.F_CSVFilePath.Name = "F_CSVFilePath";
            this.F_CSVFilePath.Size = new System.Drawing.Size(445, 19);
            this.F_CSVFilePath.TabIndex = 3;
            this.F_CSVFilePath.TextChanged += new System.EventHandler(this.F_CSVFilePath_TextChanged);
            // 
            // F_StartDate
            // 
            this.F_StartDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.F_StartDate.Location = new System.Drawing.Point(101, 45);
            this.F_StartDate.Name = "F_StartDate";
            this.F_StartDate.Size = new System.Drawing.Size(493, 19);
            this.F_StartDate.TabIndex = 6;
            this.F_StartDate.ValueChanged += new System.EventHandler(this.F_StartDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "CSVFile";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "LoggingStartDay";
            // 
            // F_CSVFileOpen
            // 
            this.F_CSVFileOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.F_CSVFileOpen.Location = new System.Drawing.Point(552, 18);
            this.F_CSVFileOpen.Name = "F_CSVFileOpen";
            this.F_CSVFileOpen.Size = new System.Drawing.Size(42, 23);
            this.F_CSVFileOpen.TabIndex = 5;
            this.F_CSVFileOpen.Text = "Open";
            this.F_CSVFileOpen.UseVisualStyleBackColor = true;
            this.F_CSVFileOpen.Click += new System.EventHandler(this.F_CSVFileOpen_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox9);
            this.tabPage3.Controls.Add(this.groupBox8);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(612, 446);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ValidCutter";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.V_OutputDirecrotyOpen);
            this.groupBox9.Controls.Add(this.label9);
            this.groupBox9.Controls.Add(this.V_OverWrite);
            this.groupBox9.Controls.Add(this.V_OutputDirectoryPath);
            this.groupBox9.Location = new System.Drawing.Point(6, 89);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(600, 71);
            this.groupBox9.TabIndex = 13;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Output";
            // 
            // V_OutputDirecrotyOpen
            // 
            this.V_OutputDirecrotyOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.V_OutputDirecrotyOpen.Location = new System.Drawing.Point(552, 38);
            this.V_OutputDirecrotyOpen.Name = "V_OutputDirecrotyOpen";
            this.V_OutputDirecrotyOpen.Size = new System.Drawing.Size(42, 23);
            this.V_OutputDirecrotyOpen.TabIndex = 10;
            this.V_OutputDirecrotyOpen.Text = "Save";
            this.V_OutputDirecrotyOpen.UseVisualStyleBackColor = true;
            this.V_OutputDirecrotyOpen.Click += new System.EventHandler(this.V_OutputDirectoryOpen_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "OutputDirectory";
            // 
            // V_OverWrite
            // 
            this.V_OverWrite.AutoSize = true;
            this.V_OverWrite.Location = new System.Drawing.Point(6, 18);
            this.V_OverWrite.Name = "V_OverWrite";
            this.V_OverWrite.Size = new System.Drawing.Size(74, 16);
            this.V_OverWrite.TabIndex = 11;
            this.V_OverWrite.Text = "OverWrite";
            this.V_OverWrite.UseVisualStyleBackColor = true;
            this.V_OverWrite.CheckedChanged += new System.EventHandler(this.V_OverWrite_CheckedChanged);
            // 
            // V_OutputDirectoryPath
            // 
            this.V_OutputDirectoryPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.V_OutputDirectoryPath.Location = new System.Drawing.Point(96, 40);
            this.V_OutputDirectoryPath.Name = "V_OutputDirectoryPath";
            this.V_OutputDirectoryPath.Size = new System.Drawing.Size(450, 19);
            this.V_OutputDirectoryPath.TabIndex = 7;
            this.V_OutputDirectoryPath.TextChanged += new System.EventHandler(this.V_OutputDirectoryPath_TextChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label17);
            this.groupBox8.Controls.Add(this.V_DirectoryOpen);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Controls.Add(this.V_Threshold);
            this.groupBox8.Controls.Add(this.V_DirectoryPath);
            this.groupBox8.Location = new System.Drawing.Point(6, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(600, 77);
            this.groupBox8.TabIndex = 12;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Input";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 12);
            this.label17.TabIndex = 11;
            this.label17.Text = "Threshold";
            // 
            // V_DirectoryOpen
            // 
            this.V_DirectoryOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.V_DirectoryOpen.Location = new System.Drawing.Point(552, 18);
            this.V_DirectoryOpen.Name = "V_DirectoryOpen";
            this.V_DirectoryOpen.Size = new System.Drawing.Size(42, 23);
            this.V_DirectoryOpen.TabIndex = 10;
            this.V_DirectoryOpen.Text = "Open";
            this.V_DirectoryOpen.UseVisualStyleBackColor = true;
            this.V_DirectoryOpen.Click += new System.EventHandler(this.V_DirectoryOpen_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 12);
            this.label10.TabIndex = 9;
            this.label10.Text = "DirectoryPath";
            // 
            // V_Threshold
            // 
            this.V_Threshold.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.V_Threshold.Location = new System.Drawing.Point(87, 45);
            this.V_Threshold.Name = "V_Threshold";
            this.V_Threshold.Size = new System.Drawing.Size(507, 19);
            this.V_Threshold.TabIndex = 7;
            this.V_Threshold.TextChanged += new System.EventHandler(this.V_Threshold_TextChanged);
            // 
            // V_DirectoryPath
            // 
            this.V_DirectoryPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.V_DirectoryPath.Location = new System.Drawing.Point(87, 20);
            this.V_DirectoryPath.Name = "V_DirectoryPath";
            this.V_DirectoryPath.Size = new System.Drawing.Size(459, 19);
            this.V_DirectoryPath.TabIndex = 7;
            this.V_DirectoryPath.TextChanged += new System.EventHandler(this.V_DirectoryPath_TextChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox7);
            this.tabPage4.Controls.Add(this.groupBox6);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(612, 446);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Calculation";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.C_OutputDirectoryOpen);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.C_OutputDirectoryPath);
            this.groupBox7.Location = new System.Drawing.Point(6, 65);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(600, 49);
            this.groupBox7.TabIndex = 18;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Output";
            // 
            // C_OutputDirectoryOpen
            // 
            this.C_OutputDirectoryOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.C_OutputDirectoryOpen.Location = new System.Drawing.Point(552, 18);
            this.C_OutputDirectoryOpen.Name = "C_OutputDirectoryOpen";
            this.C_OutputDirectoryOpen.Size = new System.Drawing.Size(42, 23);
            this.C_OutputDirectoryOpen.TabIndex = 15;
            this.C_OutputDirectoryOpen.Text = "Save";
            this.C_OutputDirectoryOpen.UseVisualStyleBackColor = true;
            this.C_OutputDirectoryOpen.Click += new System.EventHandler(this.C_OutputDirectoryOpen_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 12);
            this.label11.TabIndex = 13;
            this.label11.Text = "OutputDirectory";
            // 
            // C_OutputDirectoryPath
            // 
            this.C_OutputDirectoryPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.C_OutputDirectoryPath.Location = new System.Drawing.Point(98, 20);
            this.C_OutputDirectoryPath.Name = "C_OutputDirectoryPath";
            this.C_OutputDirectoryPath.Size = new System.Drawing.Size(448, 19);
            this.C_OutputDirectoryPath.TabIndex = 11;
            this.C_OutputDirectoryPath.TextChanged += new System.EventHandler(this.C_OutputDirectoryPath_TextChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.C_DirectoryOpen);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.C_DirectoryPath);
            this.groupBox6.Location = new System.Drawing.Point(6, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(600, 53);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Input";
            // 
            // C_DirectoryOpen
            // 
            this.C_DirectoryOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.C_DirectoryOpen.Location = new System.Drawing.Point(552, 18);
            this.C_DirectoryOpen.Name = "C_DirectoryOpen";
            this.C_DirectoryOpen.Size = new System.Drawing.Size(42, 23);
            this.C_DirectoryOpen.TabIndex = 16;
            this.C_DirectoryOpen.Text = "Open";
            this.C_DirectoryOpen.UseVisualStyleBackColor = true;
            this.C_DirectoryOpen.Click += new System.EventHandler(this.C_DirectoryOpen_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 12);
            this.label12.TabIndex = 14;
            this.label12.Text = "DirectoryPath";
            // 
            // C_DirectoryPath
            // 
            this.C_DirectoryPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.C_DirectoryPath.Location = new System.Drawing.Point(87, 20);
            this.C_DirectoryPath.Name = "C_DirectoryPath";
            this.C_DirectoryPath.Size = new System.Drawing.Size(459, 19);
            this.C_DirectoryPath.TabIndex = 12;
            this.C_DirectoryPath.TextChanged += new System.EventHandler(this.C_DirectoryPath_TextChanged);
            // 
            // Process
            // 
            this.Process.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Process.Location = new System.Drawing.Point(12, 490);
            this.Process.Name = "Process";
            this.Process.Size = new System.Drawing.Size(620, 23);
            this.Process.TabIndex = 4;
            this.Process.Text = "Processing!!";
            this.Process.UseVisualStyleBackColor = true;
            this.Process.Click += new System.EventHandler(this.Process_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 525);
            this.Controls.Add(this.Process);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "PVDataProcessor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.A_Calculation.ResumeLayout(false);
            this.A_Calculation.PerformLayout();
            this.A_ValidCutter.ResumeLayout(false);
            this.A_ValidCutter.PerformLayout();
            this.A_FileCutter.ResumeLayout(false);
            this.A_FileCutter.PerformLayout();
            this.A_Processing.ResumeLayout(false);
            this.A_Processing.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox A_Processing;
        private System.Windows.Forms.CheckBox A_P_Calculation;
        private System.Windows.Forms.CheckBox A_P_ValidCutter;
        private System.Windows.Forms.CheckBox A_P_FileCutter;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button Process;
        private System.Windows.Forms.DateTimePicker F_StartDate;
        private System.Windows.Forms.Button F_OutputDirectoryOpen;
        private System.Windows.Forms.Button F_CSVFileOpen;
        private System.Windows.Forms.TextBox F_FileNamePattern;
        private System.Windows.Forms.TextBox F_OutputDirectroyPath;
        private System.Windows.Forms.TextBox F_CSVFilePath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker A_F_StartDate;
        private System.Windows.Forms.Button A_F_OutputDirectoryOpen;
        private System.Windows.Forms.Button A_F_CSVFileOpen;
        private System.Windows.Forms.TextBox A_F_FileNamePattern;
        private System.Windows.Forms.TextBox A_F_OutputDirectoryPath;
        private System.Windows.Forms.TextBox A_F_CSVFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox V_OverWrite;
        private System.Windows.Forms.Button V_DirectoryOpen;
        private System.Windows.Forms.TextBox V_DirectoryPath;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button V_OutputDirecrotyOpen;
        private System.Windows.Forms.TextBox V_OutputDirectoryPath;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox A_FileCutter;
        private System.Windows.Forms.Button C_OutputDirectoryOpen;
        private System.Windows.Forms.Button C_DirectoryOpen;
        private System.Windows.Forms.TextBox C_OutputDirectoryPath;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox C_DirectoryPath;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox A_ValidCutter;
        private System.Windows.Forms.CheckBox A_V_OverWrite;
        private System.Windows.Forms.Button A_V_OutputDirectoryOpen;
        private System.Windows.Forms.Button A_V_DirectoryOpen;
        private System.Windows.Forms.TextBox A_V_OutputDirectoryPath;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox A_V_DirectoryPath;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox A_Calculation;
        private System.Windows.Forms.Button A_C_OutputDirectoryOpen;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox A_C_OutputDirectoryPath;
        private System.Windows.Forms.Button A_C_DirectoryOpen;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox A_C_DirectoryPath;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox V_Threshold;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox A_S_OutputDirectory;
        private System.Windows.Forms.CheckBox A_S_ProcessingDirectory;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox A_V_Threshold;
    }
}

