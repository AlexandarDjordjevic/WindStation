namespace WindStation
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPortSettings = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelModbusClientConnected = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPortOpened = new System.Windows.Forms.Label();
            this.listBoxAvailablePorts = new System.Windows.Forms.ListBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxBaudrate = new System.Windows.Forms.ComboBox();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.labelReg2 = new System.Windows.Forms.Label();
            this.labelReg3 = new System.Windows.Forms.Label();
            this.labelReg1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tabCalibration = new System.Windows.Forms.TabPage();
            this.tabMeasurements = new System.Windows.Forms.TabPage();
            this.labelClockCount = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.labelTime2 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.labelCalibration1 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.labelCalibration2 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.labelTime1 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.labelMeasureErrors = new System.Windows.Forms.Label();
            this.labelComErrors = new System.Windows.Forms.Label();
            this.labelTOF1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labelTOF2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labelTOF3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelTOF0 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelWindDirection = new System.Windows.Forms.Label();
            this.labelWindSpeed = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabTDC1000 = new System.Windows.Forms.TabPage();
            this.cbDirection4 = new System.Windows.Forms.CheckBox();
            this.cbDirection3 = new System.Windows.Forms.CheckBox();
            this.cbDirection2 = new System.Windows.Forms.CheckBox();
            this.cbDirection1 = new System.Windows.Forms.CheckBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonSet = new System.Windows.Forms.Button();
            this.checkBoxAutoRefresh = new System.Windows.Forms.CheckBox();
            this.labelDirection = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.numericTOF0 = new System.Windows.Forms.NumericUpDown();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.comboBoxFreqDivider = new System.Windows.Forms.ComboBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.numNumOfTxInBurst = new System.Windows.Forms.NumericUpDown();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.checkedListBoxErrorFlags = new System.Windows.Forms.CheckedListBox();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.comboBoxNumOfMeasToAverageStw = new System.Windows.Forms.ComboBox();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.numericNumOfExpReciEvent = new System.Windows.Forms.NumericUpDown();
            this.groupBox29 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxTofTimeoutCtrl = new System.Windows.Forms.ComboBox();
            this.comboBoxShortTOFBlankPeriod = new System.Windows.Forms.ComboBox();
            this.label70 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.checkBoxForceShortTOF = new System.Windows.Forms.CheckBox();
            this.checkBoxEchoTimeout = new System.Windows.Forms.CheckBox();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.checkListBoxConfig4 = new System.Windows.Forms.CheckedListBox();
            this.numericTxPhShiftPos = new System.Windows.Forms.NumericUpDown();
            this.label48 = new System.Windows.Forms.Label();
            this.groupBox25 = new System.Windows.Forms.GroupBox();
            this.comboBoxPGAGain = new System.Windows.Forms.ComboBox();
            this.checkBoxLNAFb = new System.Windows.Forms.CheckBox();
            this.checkBoxLnaCtrl = new System.Windows.Forms.CheckBox();
            this.numericTimingReg = new System.Windows.Forms.NumericUpDown();
            this.checkBoxPgaCtrl = new System.Windows.Forms.CheckBox();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.groupBox26 = new System.Windows.Forms.GroupBox();
            this.comboBoxEchoQualThld = new System.Windows.Forms.ComboBox();
            this.checkListBoxConfig3 = new System.Windows.Forms.CheckedListBox();
            this.label61 = new System.Windows.Forms.Label();
            this.groupBox27 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxAutozeroPeriod = new System.Windows.Forms.ComboBox();
            this.checkBoxClockDiv = new System.Windows.Forms.CheckBox();
            this.label64 = new System.Windows.Forms.Label();
            this.groupBox28 = new System.Windows.Forms.GroupBox();
            this.numericTOFMeasMode = new System.Windows.Forms.NumericUpDown();
            this.checkListBoxConfig2 = new System.Windows.Forms.CheckedListBox();
            this.label67 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericPeriod = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPortSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tabMeasurements.SuspendLayout();
            this.tabTDC1000.SuspendLayout();
            this.groupBox20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTOF0)).BeginInit();
            this.groupBox21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumOfTxInBurst)).BeginInit();
            this.groupBox22.SuspendLayout();
            this.groupBox23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumOfExpReciEvent)).BeginInit();
            this.groupBox29.SuspendLayout();
            this.groupBox24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTxPhShiftPos)).BeginInit();
            this.groupBox25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimingReg)).BeginInit();
            this.groupBox26.SuspendLayout();
            this.groupBox27.SuspendLayout();
            this.groupBox28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTOFMeasMode)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPeriod)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPortSettings);
            this.tabControl1.Controls.Add(this.tabSettings);
            this.tabControl1.Controls.Add(this.tabCalibration);
            this.tabControl1.Controls.Add(this.tabMeasurements);
            this.tabControl1.Controls.Add(this.tabTDC1000);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(648, 411);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.Enter += new System.EventHandler(this.tabControl1_Enter);
            // 
            // tabPortSettings
            // 
            this.tabPortSettings.Controls.Add(this.groupBox1);
            this.tabPortSettings.Controls.Add(this.listBoxAvailablePorts);
            this.tabPortSettings.Controls.Add(this.buttonConnect);
            this.tabPortSettings.Controls.Add(this.button1);
            this.tabPortSettings.Controls.Add(this.label1);
            this.tabPortSettings.Controls.Add(this.comboBoxBaudrate);
            this.tabPortSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPortSettings.Name = "tabPortSettings";
            this.tabPortSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPortSettings.Size = new System.Drawing.Size(640, 329);
            this.tabPortSettings.TabIndex = 0;
            this.tabPortSettings.Text = "Port Settings";
            this.tabPortSettings.UseVisualStyleBackColor = true;
            this.tabPortSettings.Click += new System.EventHandler(this.tabPortSettings_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelModbusClientConnected);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelPortOpened);
            this.groupBox1.Location = new System.Drawing.Point(197, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 88);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status:";
            // 
            // labelModbusClientConnected
            // 
            this.labelModbusClientConnected.AutoSize = true;
            this.labelModbusClientConnected.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModbusClientConnected.ForeColor = System.Drawing.Color.Red;
            this.labelModbusClientConnected.Location = new System.Drawing.Point(147, 40);
            this.labelModbusClientConnected.Name = "labelModbusClientConnected";
            this.labelModbusClientConnected.Size = new System.Drawing.Size(24, 29);
            this.labelModbusClientConnected.TabIndex = 19;
            this.labelModbusClientConnected.Text = "x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Port open";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Client Connected";
            // 
            // labelPortOpened
            // 
            this.labelPortOpened.AutoSize = true;
            this.labelPortOpened.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPortOpened.ForeColor = System.Drawing.Color.Red;
            this.labelPortOpened.Location = new System.Drawing.Point(147, 12);
            this.labelPortOpened.Name = "labelPortOpened";
            this.labelPortOpened.Size = new System.Drawing.Size(24, 29);
            this.labelPortOpened.TabIndex = 14;
            this.labelPortOpened.Text = "x";
            // 
            // listBoxAvailablePorts
            // 
            this.listBoxAvailablePorts.FormattingEnabled = true;
            this.listBoxAvailablePorts.Location = new System.Drawing.Point(8, 6);
            this.listBoxAvailablePorts.Name = "listBoxAvailablePorts";
            this.listBoxAvailablePorts.Size = new System.Drawing.Size(65, 69);
            this.listBoxAvailablePorts.TabIndex = 9;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(8, 81);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(147, 23);
            this.buttonConnect.TabIndex = 12;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 24);
            this.button1.TabIndex = 8;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Baudrate:";
            // 
            // comboBoxBaudrate
            // 
            this.comboBoxBaudrate.FormattingEnabled = true;
            this.comboBoxBaudrate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBoxBaudrate.Location = new System.Drawing.Point(82, 54);
            this.comboBoxBaudrate.Name = "comboBoxBaudrate";
            this.comboBoxBaudrate.Size = new System.Drawing.Size(73, 21);
            this.comboBoxBaudrate.TabIndex = 10;
            this.comboBoxBaudrate.Text = "115200";
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.labelReg2);
            this.tabSettings.Controls.Add(this.labelReg3);
            this.tabSettings.Controls.Add(this.labelReg1);
            this.tabSettings.Controls.Add(this.label6);
            this.tabSettings.Controls.Add(this.label5);
            this.tabSettings.Controls.Add(this.label2);
            this.tabSettings.Controls.Add(this.button2);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(640, 329);
            this.tabSettings.TabIndex = 3;
            this.tabSettings.Text = "Sensor Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // labelReg2
            // 
            this.labelReg2.AutoSize = true;
            this.labelReg2.Location = new System.Drawing.Point(228, 69);
            this.labelReg2.Name = "labelReg2";
            this.labelReg2.Size = new System.Drawing.Size(13, 13);
            this.labelReg2.TabIndex = 6;
            this.labelReg2.Text = "0";
            // 
            // labelReg3
            // 
            this.labelReg3.AutoSize = true;
            this.labelReg3.Location = new System.Drawing.Point(228, 93);
            this.labelReg3.Name = "labelReg3";
            this.labelReg3.Size = new System.Drawing.Size(13, 13);
            this.labelReg3.TabIndex = 5;
            this.labelReg3.Text = "0";
            // 
            // labelReg1
            // 
            this.labelReg1.AutoSize = true;
            this.labelReg1.Location = new System.Drawing.Point(228, 45);
            this.labelReg1.Name = "labelReg1";
            this.labelReg1.Size = new System.Drawing.Size(13, 13);
            this.labelReg1.TabIndex = 4;
            this.labelReg1.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Register 3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Register 2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Register 1:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 37);
            this.button2.TabIndex = 0;
            this.button2.Text = "Read Settings";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabCalibration
            // 
            this.tabCalibration.Location = new System.Drawing.Point(4, 22);
            this.tabCalibration.Name = "tabCalibration";
            this.tabCalibration.Padding = new System.Windows.Forms.Padding(3);
            this.tabCalibration.Size = new System.Drawing.Size(640, 329);
            this.tabCalibration.TabIndex = 1;
            this.tabCalibration.Text = "Sensor Calibration";
            this.tabCalibration.UseVisualStyleBackColor = true;
            // 
            // tabMeasurements
            // 
            this.tabMeasurements.Controls.Add(this.labelClockCount);
            this.tabMeasurements.Controls.Add(this.label19);
            this.tabMeasurements.Controls.Add(this.labelTime2);
            this.tabMeasurements.Controls.Add(this.label18);
            this.tabMeasurements.Controls.Add(this.labelCalibration1);
            this.tabMeasurements.Controls.Add(this.label20);
            this.tabMeasurements.Controls.Add(this.labelCalibration2);
            this.tabMeasurements.Controls.Add(this.label22);
            this.tabMeasurements.Controls.Add(this.labelTime1);
            this.tabMeasurements.Controls.Add(this.label24);
            this.tabMeasurements.Controls.Add(this.labelMeasureErrors);
            this.tabMeasurements.Controls.Add(this.labelComErrors);
            this.tabMeasurements.Controls.Add(this.labelTOF1);
            this.tabMeasurements.Controls.Add(this.label16);
            this.tabMeasurements.Controls.Add(this.labelTOF2);
            this.tabMeasurements.Controls.Add(this.label14);
            this.tabMeasurements.Controls.Add(this.labelTOF3);
            this.tabMeasurements.Controls.Add(this.label10);
            this.tabMeasurements.Controls.Add(this.labelTOF0);
            this.tabMeasurements.Controls.Add(this.label8);
            this.tabMeasurements.Controls.Add(this.labelWindDirection);
            this.tabMeasurements.Controls.Add(this.labelWindSpeed);
            this.tabMeasurements.Controls.Add(this.label11);
            this.tabMeasurements.Controls.Add(this.label12);
            this.tabMeasurements.Location = new System.Drawing.Point(4, 22);
            this.tabMeasurements.Name = "tabMeasurements";
            this.tabMeasurements.Padding = new System.Windows.Forms.Padding(3);
            this.tabMeasurements.Size = new System.Drawing.Size(640, 329);
            this.tabMeasurements.TabIndex = 2;
            this.tabMeasurements.Text = "Measurements";
            this.tabMeasurements.UseVisualStyleBackColor = true;
            this.tabMeasurements.Click += new System.EventHandler(this.tabMeasurements_Click);
            // 
            // labelClockCount
            // 
            this.labelClockCount.AutoSize = true;
            this.labelClockCount.Location = new System.Drawing.Point(327, 94);
            this.labelClockCount.Name = "labelClockCount";
            this.labelClockCount.Size = new System.Drawing.Size(13, 13);
            this.labelClockCount.TabIndex = 34;
            this.labelClockCount.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(228, 94);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(68, 13);
            this.label19.TabIndex = 33;
            this.label19.Text = "Clock Count:";
            // 
            // labelTime2
            // 
            this.labelTime2.AutoSize = true;
            this.labelTime2.Location = new System.Drawing.Point(327, 39);
            this.labelTime2.Name = "labelTime2";
            this.labelTime2.Size = new System.Drawing.Size(13, 13);
            this.labelTime2.TabIndex = 32;
            this.labelTime2.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(228, 39);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 13);
            this.label18.TabIndex = 31;
            this.label18.Text = "Time 2:";
            // 
            // labelCalibration1
            // 
            this.labelCalibration1.AutoSize = true;
            this.labelCalibration1.Location = new System.Drawing.Point(327, 58);
            this.labelCalibration1.Name = "labelCalibration1";
            this.labelCalibration1.Size = new System.Drawing.Size(13, 13);
            this.labelCalibration1.TabIndex = 30;
            this.labelCalibration1.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(228, 58);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(68, 13);
            this.label20.TabIndex = 29;
            this.label20.Text = "Calibration 1:";
            // 
            // labelCalibration2
            // 
            this.labelCalibration2.AutoSize = true;
            this.labelCalibration2.Location = new System.Drawing.Point(327, 77);
            this.labelCalibration2.Name = "labelCalibration2";
            this.labelCalibration2.Size = new System.Drawing.Size(13, 13);
            this.labelCalibration2.TabIndex = 28;
            this.labelCalibration2.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(228, 77);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(68, 13);
            this.label22.TabIndex = 27;
            this.label22.Text = "Calibration 2:";
            // 
            // labelTime1
            // 
            this.labelTime1.AutoSize = true;
            this.labelTime1.Location = new System.Drawing.Point(327, 20);
            this.labelTime1.Name = "labelTime1";
            this.labelTime1.Size = new System.Drawing.Size(13, 13);
            this.labelTime1.TabIndex = 26;
            this.labelTime1.Text = "0";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(228, 20);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(42, 13);
            this.label24.TabIndex = 25;
            this.label24.Text = "Time 1:";
            // 
            // labelMeasureErrors
            // 
            this.labelMeasureErrors.AutoSize = true;
            this.labelMeasureErrors.Location = new System.Drawing.Point(18, 68);
            this.labelMeasureErrors.Name = "labelMeasureErrors";
            this.labelMeasureErrors.Size = new System.Drawing.Size(22, 13);
            this.labelMeasureErrors.TabIndex = 24;
            this.labelMeasureErrors.Text = "-----";
            // 
            // labelComErrors
            // 
            this.labelComErrors.AutoSize = true;
            this.labelComErrors.Location = new System.Drawing.Point(18, 167);
            this.labelComErrors.Name = "labelComErrors";
            this.labelComErrors.Size = new System.Drawing.Size(22, 13);
            this.labelComErrors.TabIndex = 23;
            this.labelComErrors.Text = "-----";
            // 
            // labelTOF1
            // 
            this.labelTOF1.AutoSize = true;
            this.labelTOF1.Location = new System.Drawing.Point(73, 110);
            this.labelTOF1.Name = "labelTOF1";
            this.labelTOF1.Size = new System.Drawing.Size(13, 13);
            this.labelTOF1.TabIndex = 21;
            this.labelTOF1.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 110);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "TOF 1:";
            // 
            // labelTOF2
            // 
            this.labelTOF2.AutoSize = true;
            this.labelTOF2.Location = new System.Drawing.Point(73, 129);
            this.labelTOF2.Name = "labelTOF2";
            this.labelTOF2.Size = new System.Drawing.Size(13, 13);
            this.labelTOF2.TabIndex = 19;
            this.labelTOF2.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 129);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "TOF 2:";
            // 
            // labelTOF3
            // 
            this.labelTOF3.AutoSize = true;
            this.labelTOF3.Location = new System.Drawing.Point(73, 148);
            this.labelTOF3.Name = "labelTOF3";
            this.labelTOF3.Size = new System.Drawing.Size(13, 13);
            this.labelTOF3.TabIndex = 17;
            this.labelTOF3.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "TOF 3:";
            // 
            // labelTOF0
            // 
            this.labelTOF0.AutoSize = true;
            this.labelTOF0.Location = new System.Drawing.Point(73, 91);
            this.labelTOF0.Name = "labelTOF0";
            this.labelTOF0.Size = new System.Drawing.Size(13, 13);
            this.labelTOF0.TabIndex = 15;
            this.labelTOF0.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "TOF 0:";
            // 
            // labelWindDirection
            // 
            this.labelWindDirection.AutoSize = true;
            this.labelWindDirection.Location = new System.Drawing.Point(104, 44);
            this.labelWindDirection.Name = "labelWindDirection";
            this.labelWindDirection.Size = new System.Drawing.Size(13, 13);
            this.labelWindDirection.TabIndex = 13;
            this.labelWindDirection.Text = "0";
            // 
            // labelWindSpeed
            // 
            this.labelWindSpeed.AutoSize = true;
            this.labelWindSpeed.Location = new System.Drawing.Point(104, 20);
            this.labelWindSpeed.Name = "labelWindSpeed";
            this.labelWindSpeed.Size = new System.Drawing.Size(13, 13);
            this.labelWindSpeed.TabIndex = 11;
            this.labelWindSpeed.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Wind Direction:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Wind Speed:";
            // 
            // tabTDC1000
            // 
            this.tabTDC1000.Controls.Add(this.groupBox4);
            this.tabTDC1000.Controls.Add(this.buttonRefresh);
            this.tabTDC1000.Controls.Add(this.buttonSet);
            this.tabTDC1000.Controls.Add(this.checkBoxAutoRefresh);
            this.tabTDC1000.Controls.Add(this.groupBox20);
            this.tabTDC1000.Controls.Add(this.groupBox21);
            this.tabTDC1000.Controls.Add(this.groupBox22);
            this.tabTDC1000.Controls.Add(this.groupBox23);
            this.tabTDC1000.Controls.Add(this.groupBox29);
            this.tabTDC1000.Controls.Add(this.groupBox24);
            this.tabTDC1000.Controls.Add(this.groupBox25);
            this.tabTDC1000.Controls.Add(this.groupBox26);
            this.tabTDC1000.Controls.Add(this.groupBox27);
            this.tabTDC1000.Controls.Add(this.groupBox28);
            this.tabTDC1000.Location = new System.Drawing.Point(4, 22);
            this.tabTDC1000.Name = "tabTDC1000";
            this.tabTDC1000.Padding = new System.Windows.Forms.Padding(3);
            this.tabTDC1000.Size = new System.Drawing.Size(640, 385);
            this.tabTDC1000.TabIndex = 4;
            this.tabTDC1000.Text = "TDC1000";
            this.tabTDC1000.UseVisualStyleBackColor = true;
            // 
            // cbDirection4
            // 
            this.cbDirection4.AutoSize = true;
            this.cbDirection4.Location = new System.Drawing.Point(75, 60);
            this.cbDirection4.Name = "cbDirection4";
            this.cbDirection4.Size = new System.Drawing.Size(68, 17);
            this.cbDirection4.TabIndex = 95;
            this.cbDirection4.Text = "Enable 4";
            this.cbDirection4.UseVisualStyleBackColor = true;
            // 
            // cbDirection3
            // 
            this.cbDirection3.AutoSize = true;
            this.cbDirection3.Location = new System.Drawing.Point(6, 60);
            this.cbDirection3.Name = "cbDirection3";
            this.cbDirection3.Size = new System.Drawing.Size(68, 17);
            this.cbDirection3.TabIndex = 94;
            this.cbDirection3.Text = "Enable 3";
            this.cbDirection3.UseVisualStyleBackColor = true;
            // 
            // cbDirection2
            // 
            this.cbDirection2.AutoSize = true;
            this.cbDirection2.Location = new System.Drawing.Point(75, 37);
            this.cbDirection2.Name = "cbDirection2";
            this.cbDirection2.Size = new System.Drawing.Size(68, 17);
            this.cbDirection2.TabIndex = 93;
            this.cbDirection2.Text = "Enable 2";
            this.cbDirection2.UseVisualStyleBackColor = true;
            // 
            // cbDirection1
            // 
            this.cbDirection1.AutoSize = true;
            this.cbDirection1.Location = new System.Drawing.Point(6, 37);
            this.cbDirection1.Name = "cbDirection1";
            this.cbDirection1.Size = new System.Drawing.Size(68, 17);
            this.cbDirection1.TabIndex = 92;
            this.cbDirection1.Text = "Enable 1";
            this.cbDirection1.UseVisualStyleBackColor = true;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(452, 271);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(85, 23);
            this.buttonRefresh.TabIndex = 91;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonSet
            // 
            this.buttonSet.Location = new System.Drawing.Point(543, 271);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(89, 23);
            this.buttonSet.TabIndex = 35;
            this.buttonSet.Text = "Set";
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // checkBoxAutoRefresh
            // 
            this.checkBoxAutoRefresh.AutoSize = true;
            this.checkBoxAutoRefresh.Location = new System.Drawing.Point(452, 297);
            this.checkBoxAutoRefresh.Name = "checkBoxAutoRefresh";
            this.checkBoxAutoRefresh.Size = new System.Drawing.Size(85, 17);
            this.checkBoxAutoRefresh.TabIndex = 90;
            this.checkBoxAutoRefresh.Text = "AutoRefresh";
            this.checkBoxAutoRefresh.UseVisualStyleBackColor = true;
            this.checkBoxAutoRefresh.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // labelDirection
            // 
            this.labelDirection.AutoSize = true;
            this.labelDirection.Location = new System.Drawing.Point(64, 15);
            this.labelDirection.Name = "labelDirection";
            this.labelDirection.Size = new System.Drawing.Size(13, 13);
            this.labelDirection.TabIndex = 89;
            this.labelDirection.Text = "--";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 88;
            this.label7.Text = "Current:";
            // 
            // groupBox20
            // 
            this.groupBox20.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox20.Controls.Add(this.numericTOF0);
            this.groupBox20.Location = new System.Drawing.Point(158, 206);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(132, 42);
            this.groupBox20.TabIndex = 54;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "TOF 0";
            // 
            // numericTOF0
            // 
            this.numericTOF0.Location = new System.Drawing.Point(6, 14);
            this.numericTOF0.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericTOF0.Name = "numericTOF0";
            this.numericTOF0.Size = new System.Drawing.Size(52, 20);
            this.numericTOF0.TabIndex = 19;
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.comboBoxFreqDivider);
            this.groupBox21.Controls.Add(this.label35);
            this.groupBox21.Controls.Add(this.label37);
            this.groupBox21.Controls.Add(this.numNumOfTxInBurst);
            this.groupBox21.Location = new System.Drawing.Point(8, 6);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(143, 67);
            this.groupBox21.TabIndex = 47;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "Config 0";
            // 
            // comboBoxFreqDivider
            // 
            this.comboBoxFreqDivider.FormattingEnabled = true;
            this.comboBoxFreqDivider.Items.AddRange(new object[] {
            "2",
            "4",
            "8",
            "16",
            "32",
            "64",
            "128",
            "256"});
            this.comboBoxFreqDivider.Location = new System.Drawing.Point(95, 11);
            this.comboBoxFreqDivider.Name = "comboBoxFreqDivider";
            this.comboBoxFreqDivider.Size = new System.Drawing.Size(39, 21);
            this.comboBoxFreqDivider.TabIndex = 87;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(6, 40);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(84, 13);
            this.label35.TabIndex = 5;
            this.label35.Text = "Num Tx in burst:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(6, 16);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(63, 13);
            this.label37.TabIndex = 4;
            this.label37.Text = "Freq div Tx:";
            // 
            // numNumOfTxInBurst
            // 
            this.numNumOfTxInBurst.Location = new System.Drawing.Point(94, 38);
            this.numNumOfTxInBurst.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numNumOfTxInBurst.Name = "numNumOfTxInBurst";
            this.numNumOfTxInBurst.Size = new System.Drawing.Size(40, 20);
            this.numNumOfTxInBurst.TabIndex = 2;
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.checkedListBoxErrorFlags);
            this.groupBox22.Location = new System.Drawing.Point(295, 163);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(134, 72);
            this.groupBox22.TabIndex = 53;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "Error flags";
            // 
            // checkedListBoxErrorFlags
            // 
            this.checkedListBoxErrorFlags.FormattingEnabled = true;
            this.checkedListBoxErrorFlags.Items.AddRange(new object[] {
            "Err sig weak",
            "Err no signal",
            "Err sig high"});
            this.checkedListBoxErrorFlags.Location = new System.Drawing.Point(5, 15);
            this.checkedListBoxErrorFlags.Name = "checkedListBoxErrorFlags";
            this.checkedListBoxErrorFlags.Size = new System.Drawing.Size(121, 49);
            this.checkedListBoxErrorFlags.TabIndex = 94;
            // 
            // groupBox23
            // 
            this.groupBox23.Controls.Add(this.comboBoxNumOfMeasToAverageStw);
            this.groupBox23.Controls.Add(this.label46);
            this.groupBox23.Controls.Add(this.label47);
            this.groupBox23.Controls.Add(this.numericNumOfExpReciEvent);
            this.groupBox23.Location = new System.Drawing.Point(158, 5);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new System.Drawing.Size(273, 68);
            this.groupBox23.TabIndex = 48;
            this.groupBox23.TabStop = false;
            this.groupBox23.Text = "Config 1";
            // 
            // comboBoxNumOfMeasToAverageStw
            // 
            this.comboBoxNumOfMeasToAverageStw.FormattingEnabled = true;
            this.comboBoxNumOfMeasToAverageStw.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "8",
            "16",
            "32",
            "64",
            "128"});
            this.comboBoxNumOfMeasToAverageStw.Location = new System.Drawing.Point(211, 13);
            this.comboBoxNumOfMeasToAverageStw.Name = "comboBoxNumOfMeasToAverageStw";
            this.comboBoxNumOfMeasToAverageStw.Size = new System.Drawing.Size(54, 21);
            this.comboBoxNumOfMeasToAverageStw.TabIndex = 88;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(6, 40);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(179, 13);
            this.label46.TabIndex = 5;
            this.label46.Text = "Number of expected receive events:";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(6, 16);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(204, 13);
            this.label47.TabIndex = 4;
            this.label47.Text = "Number of meas to average in stopwatch:";
            // 
            // numericNumOfExpReciEvent
            // 
            this.numericNumOfExpReciEvent.Location = new System.Drawing.Point(211, 39);
            this.numericNumOfExpReciEvent.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericNumOfExpReciEvent.Name = "numericNumOfExpReciEvent";
            this.numericNumOfExpReciEvent.Size = new System.Drawing.Size(54, 20);
            this.numericNumOfExpReciEvent.TabIndex = 2;
            // 
            // groupBox29
            // 
            this.groupBox29.Controls.Add(this.label13);
            this.groupBox29.Controls.Add(this.label9);
            this.groupBox29.Controls.Add(this.comboBoxTofTimeoutCtrl);
            this.groupBox29.Controls.Add(this.comboBoxShortTOFBlankPeriod);
            this.groupBox29.Controls.Add(this.label70);
            this.groupBox29.Controls.Add(this.label71);
            this.groupBox29.Controls.Add(this.checkBoxForceShortTOF);
            this.groupBox29.Controls.Add(this.checkBoxEchoTimeout);
            this.groupBox29.Location = new System.Drawing.Point(436, 105);
            this.groupBox29.Name = "groupBox29";
            this.groupBox29.Size = new System.Drawing.Size(197, 84);
            this.groupBox29.TabIndex = 52;
            this.groupBox29.TabStop = false;
            this.groupBox29.Text = "Timeout";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(154, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 13);
            this.label13.TabIndex = 91;
            this.label13.Text = "xT0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(154, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 90;
            this.label9.Text = "xT0";
            // 
            // comboBoxTofTimeoutCtrl
            // 
            this.comboBoxTofTimeoutCtrl.FormattingEnabled = true;
            this.comboBoxTofTimeoutCtrl.Items.AddRange(new object[] {
            "128",
            "256",
            "512",
            "1024"});
            this.comboBoxTofTimeoutCtrl.Location = new System.Drawing.Point(91, 35);
            this.comboBoxTofTimeoutCtrl.Name = "comboBoxTofTimeoutCtrl";
            this.comboBoxTofTimeoutCtrl.Size = new System.Drawing.Size(60, 21);
            this.comboBoxTofTimeoutCtrl.TabIndex = 89;
            // 
            // comboBoxShortTOFBlankPeriod
            // 
            this.comboBoxShortTOFBlankPeriod.FormattingEnabled = true;
            this.comboBoxShortTOFBlankPeriod.Items.AddRange(new object[] {
            "8",
            "16",
            "32",
            "64",
            "128",
            "256",
            "512",
            "1024"});
            this.comboBoxShortTOFBlankPeriod.Location = new System.Drawing.Point(91, 11);
            this.comboBoxShortTOFBlankPeriod.Name = "comboBoxShortTOFBlankPeriod";
            this.comboBoxShortTOFBlankPeriod.Size = new System.Drawing.Size(60, 21);
            this.comboBoxShortTOFBlankPeriod.TabIndex = 88;
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(2, 16);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(89, 13);
            this.label70.TabIndex = 25;
            this.label70.Text = "Short TOF b. per:";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(2, 38);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(85, 13);
            this.label71.TabIndex = 23;
            this.label71.Text = "TOF timeout ctrl:";
            // 
            // checkBoxForceShortTOF
            // 
            this.checkBoxForceShortTOF.AutoSize = true;
            this.checkBoxForceShortTOF.Location = new System.Drawing.Point(90, 61);
            this.checkBoxForceShortTOF.Name = "checkBoxForceShortTOF";
            this.checkBoxForceShortTOF.Size = new System.Drawing.Size(103, 17);
            this.checkBoxForceShortTOF.TabIndex = 17;
            this.checkBoxForceShortTOF.Text = "Force short TOF";
            this.checkBoxForceShortTOF.UseVisualStyleBackColor = true;
            // 
            // checkBoxEchoTimeout
            // 
            this.checkBoxEchoTimeout.AutoSize = true;
            this.checkBoxEchoTimeout.Location = new System.Drawing.Point(6, 61);
            this.checkBoxEchoTimeout.Name = "checkBoxEchoTimeout";
            this.checkBoxEchoTimeout.Size = new System.Drawing.Size(72, 17);
            this.checkBoxEchoTimeout.TabIndex = 21;
            this.checkBoxEchoTimeout.Text = "Echo tout";
            this.checkBoxEchoTimeout.UseVisualStyleBackColor = true;
            // 
            // groupBox24
            // 
            this.groupBox24.Controls.Add(this.checkListBoxConfig4);
            this.groupBox24.Controls.Add(this.numericTxPhShiftPos);
            this.groupBox24.Controls.Add(this.label48);
            this.groupBox24.Location = new System.Drawing.Point(296, 79);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Size = new System.Drawing.Size(133, 80);
            this.groupBox24.TabIndex = 49;
            this.groupBox24.TabStop = false;
            this.groupBox24.Text = "Config 4";
            // 
            // checkListBoxConfig4
            // 
            this.checkListBoxConfig4.FormattingEnabled = true;
            this.checkListBoxConfig4.Items.AddRange(new object[] {
            "Receive mode",
            "Trgi edge polarity"});
            this.checkListBoxConfig4.Location = new System.Drawing.Point(6, 17);
            this.checkListBoxConfig4.Name = "checkListBoxConfig4";
            this.checkListBoxConfig4.Size = new System.Drawing.Size(120, 34);
            this.checkListBoxConfig4.TabIndex = 92;
            // 
            // numericTxPhShiftPos
            // 
            this.numericTxPhShiftPos.Location = new System.Drawing.Point(86, 52);
            this.numericTxPhShiftPos.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericTxPhShiftPos.Name = "numericTxPhShiftPos";
            this.numericTxPhShiftPos.Size = new System.Drawing.Size(40, 20);
            this.numericTxPhShiftPos.TabIndex = 19;
            this.numericTxPhShiftPos.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(6, 54);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(76, 13);
            this.label48.TabIndex = 20;
            this.label48.Text = "Tx ph shift pos";
            // 
            // groupBox25
            // 
            this.groupBox25.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox25.Controls.Add(this.comboBoxPGAGain);
            this.groupBox25.Controls.Add(this.checkBoxLNAFb);
            this.groupBox25.Controls.Add(this.checkBoxLnaCtrl);
            this.groupBox25.Controls.Add(this.numericTimingReg);
            this.groupBox25.Controls.Add(this.checkBoxPgaCtrl);
            this.groupBox25.Controls.Add(this.label57);
            this.groupBox25.Controls.Add(this.label58);
            this.groupBox25.Location = new System.Drawing.Point(436, 6);
            this.groupBox25.Name = "groupBox25";
            this.groupBox25.Size = new System.Drawing.Size(197, 91);
            this.groupBox25.TabIndex = 46;
            this.groupBox25.TabStop = false;
            this.groupBox25.Text = "TOF 1";
            // 
            // comboBoxPGAGain
            // 
            this.comboBoxPGAGain.FormattingEnabled = true;
            this.comboBoxPGAGain.Items.AddRange(new object[] {
            "0 dB",
            "3 dB",
            "6 dB",
            "9 dB",
            "12 dB",
            "15 dB",
            "18 dB",
            "21 dB"});
            this.comboBoxPGAGain.Location = new System.Drawing.Point(84, 12);
            this.comboBoxPGAGain.Name = "comboBoxPGAGain";
            this.comboBoxPGAGain.Size = new System.Drawing.Size(67, 21);
            this.comboBoxPGAGain.TabIndex = 88;
            // 
            // checkBoxLNAFb
            // 
            this.checkBoxLNAFb.AutoSize = true;
            this.checkBoxLNAFb.Location = new System.Drawing.Point(71, 66);
            this.checkBoxLNAFb.Name = "checkBoxLNAFb";
            this.checkBoxLNAFb.Size = new System.Drawing.Size(66, 17);
            this.checkBoxLNAFb.TabIndex = 27;
            this.checkBoxLNAFb.Text = "Lna Res";
            this.checkBoxLNAFb.UseVisualStyleBackColor = true;
            // 
            // checkBoxLnaCtrl
            // 
            this.checkBoxLnaCtrl.AutoSize = true;
            this.checkBoxLnaCtrl.Location = new System.Drawing.Point(137, 66);
            this.checkBoxLnaCtrl.Name = "checkBoxLnaCtrl";
            this.checkBoxLnaCtrl.Size = new System.Drawing.Size(61, 17);
            this.checkBoxLnaCtrl.TabIndex = 26;
            this.checkBoxLnaCtrl.Text = "Lna ctrl";
            this.checkBoxLnaCtrl.UseVisualStyleBackColor = true;
            // 
            // numericTimingReg
            // 
            this.numericTimingReg.Location = new System.Drawing.Point(84, 37);
            this.numericTimingReg.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericTimingReg.Name = "numericTimingReg";
            this.numericTimingReg.Size = new System.Drawing.Size(67, 20);
            this.numericTimingReg.TabIndex = 24;
            // 
            // checkBoxPgaCtrl
            // 
            this.checkBoxPgaCtrl.AutoSize = true;
            this.checkBoxPgaCtrl.Location = new System.Drawing.Point(6, 66);
            this.checkBoxPgaCtrl.Name = "checkBoxPgaCtrl";
            this.checkBoxPgaCtrl.Size = new System.Drawing.Size(62, 17);
            this.checkBoxPgaCtrl.TabIndex = 21;
            this.checkBoxPgaCtrl.Text = "Pga ctrl";
            this.checkBoxPgaCtrl.UseVisualStyleBackColor = true;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(6, 39);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(56, 13);
            this.label57.TabIndex = 25;
            this.label57.Text = "Timing reg";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(6, 17);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(52, 13);
            this.label58.TabIndex = 20;
            this.label58.Text = "PGA gain";
            // 
            // groupBox26
            // 
            this.groupBox26.Controls.Add(this.comboBoxEchoQualThld);
            this.groupBox26.Controls.Add(this.checkListBoxConfig3);
            this.groupBox26.Controls.Add(this.label61);
            this.groupBox26.Location = new System.Drawing.Point(157, 79);
            this.groupBox26.Name = "groupBox26";
            this.groupBox26.Size = new System.Drawing.Size(133, 124);
            this.groupBox26.TabIndex = 55;
            this.groupBox26.TabStop = false;
            this.groupBox26.Text = "Config 3";
            // 
            // comboBoxEchoQualThld
            // 
            this.comboBoxEchoQualThld.FormattingEnabled = true;
            this.comboBoxEchoQualThld.Items.AddRange(new object[] {
            "–35 mV",
            "–50 mV",
            "–75 mV",
            "–125 mV",
            "–220 mV",
            "–410 mV",
            "–775 mV",
            "–1500 mV"});
            this.comboBoxEchoQualThld.Location = new System.Drawing.Point(68, 84);
            this.comboBoxEchoQualThld.Name = "comboBoxEchoQualThld";
            this.comboBoxEchoQualThld.Size = new System.Drawing.Size(58, 21);
            this.comboBoxEchoQualThld.TabIndex = 88;
            // 
            // checkListBoxConfig3
            // 
            this.checkListBoxConfig3.FormattingEnabled = true;
            this.checkListBoxConfig3.Items.AddRange(new object[] {
            "Temp mode",
            "Temp RTD Sel",
            "Temp clk div",
            "Blanking"});
            this.checkListBoxConfig3.Location = new System.Drawing.Point(6, 16);
            this.checkListBoxConfig3.Name = "checkListBoxConfig3";
            this.checkListBoxConfig3.Size = new System.Drawing.Size(121, 64);
            this.checkListBoxConfig3.TabIndex = 90;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(3, 87);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(61, 13);
            this.label61.TabIndex = 23;
            this.label61.Text = "Ech qul thd";
            // 
            // groupBox27
            // 
            this.groupBox27.Controls.Add(this.label15);
            this.groupBox27.Controls.Add(this.comboBoxAutozeroPeriod);
            this.groupBox27.Controls.Add(this.checkBoxClockDiv);
            this.groupBox27.Controls.Add(this.label64);
            this.groupBox27.Location = new System.Drawing.Point(436, 195);
            this.groupBox27.Name = "groupBox27";
            this.groupBox27.Size = new System.Drawing.Size(197, 63);
            this.groupBox27.TabIndex = 50;
            this.groupBox27.TabStop = false;
            this.groupBox27.Text = "Clock rate";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(154, 41);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 13);
            this.label15.TabIndex = 92;
            this.label15.Text = "xT0";
            // 
            // comboBoxAutozeroPeriod
            // 
            this.comboBoxAutozeroPeriod.FormattingEnabled = true;
            this.comboBoxAutozeroPeriod.Items.AddRange(new object[] {
            "64",
            "128",
            "256",
            "512"});
            this.comboBoxAutozeroPeriod.Location = new System.Drawing.Point(92, 37);
            this.comboBoxAutozeroPeriod.Name = "comboBoxAutozeroPeriod";
            this.comboBoxAutozeroPeriod.Size = new System.Drawing.Size(59, 21);
            this.comboBoxAutozeroPeriod.TabIndex = 97;
            // 
            // checkBoxClockDiv
            // 
            this.checkBoxClockDiv.AutoSize = true;
            this.checkBoxClockDiv.Location = new System.Drawing.Point(7, 19);
            this.checkBoxClockDiv.Name = "checkBoxClockDiv";
            this.checkBoxClockDiv.Size = new System.Drawing.Size(74, 17);
            this.checkBoxClockDiv.TabIndex = 17;
            this.checkBoxClockDiv.Text = "Clock DIV";
            this.checkBoxClockDiv.UseVisualStyleBackColor = true;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(6, 40);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(84, 13);
            this.label64.TabIndex = 20;
            this.label64.Text = "Autozero period:";
            // 
            // groupBox28
            // 
            this.groupBox28.Controls.Add(this.numericTOFMeasMode);
            this.groupBox28.Controls.Add(this.checkListBoxConfig2);
            this.groupBox28.Controls.Add(this.label67);
            this.groupBox28.Location = new System.Drawing.Point(6, 79);
            this.groupBox28.Name = "groupBox28";
            this.groupBox28.Size = new System.Drawing.Size(143, 144);
            this.groupBox28.TabIndex = 51;
            this.groupBox28.TabStop = false;
            this.groupBox28.Text = "Config 2";
            // 
            // numericTOFMeasMode
            // 
            this.numericTOFMeasMode.Location = new System.Drawing.Point(97, 116);
            this.numericTOFMeasMode.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericTOFMeasMode.Name = "numericTOFMeasMode";
            this.numericTOFMeasMode.Size = new System.Drawing.Size(40, 20);
            this.numericTOFMeasMode.TabIndex = 22;
            // 
            // checkListBoxConfig2
            // 
            this.checkListBoxConfig2.FormattingEnabled = true;
            this.checkListBoxConfig2.Items.AddRange(new object[] {
            "Vcom select",
            "Measure mode",
            "Damping",
            "Channel swap",
            "External channel sel",
            "Channel select"});
            this.checkListBoxConfig2.Location = new System.Drawing.Point(6, 16);
            this.checkListBoxConfig2.Name = "checkListBoxConfig2";
            this.checkListBoxConfig2.Size = new System.Drawing.Size(131, 94);
            this.checkListBoxConfig2.TabIndex = 28;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(3, 119);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(88, 13);
            this.label67.TabIndex = 23;
            this.label67.Text = "TOF meas mode:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.cbDirection1);
            this.groupBox2.Controls.Add(this.cbDirection4);
            this.groupBox2.Controls.Add(this.cbDirection2);
            this.groupBox2.Controls.Add(this.cbDirection3);
            this.groupBox2.Controls.Add(this.labelDirection);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 82);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Direction";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.numericPeriod);
            this.groupBox3.Location = new System.Drawing.Point(165, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(70, 82);
            this.groupBox3.TabIndex = 55;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Period";
            // 
            // numericPeriod
            // 
            this.numericPeriod.Location = new System.Drawing.Point(6, 16);
            this.numericPeriod.Maximum = new decimal(new int[] {
            4095,
            0,
            0,
            0});
            this.numericPeriod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericPeriod.Name = "numericPeriod";
            this.numericPeriod.Size = new System.Drawing.Size(52, 20);
            this.numericPeriod.TabIndex = 19;
            this.numericPeriod.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 41);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 13);
            this.label17.TabIndex = 20;
            this.label17.Text = "x100 ms";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Location = new System.Drawing.Point(6, 254);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(250, 117);
            this.groupBox4.TabIndex = 96;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Trigger";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 411);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPortSettings.ResumeLayout(false);
            this.tabPortSettings.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.tabMeasurements.ResumeLayout(false);
            this.tabMeasurements.PerformLayout();
            this.tabTDC1000.ResumeLayout(false);
            this.tabTDC1000.PerformLayout();
            this.groupBox20.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericTOF0)).EndInit();
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumOfTxInBurst)).EndInit();
            this.groupBox22.ResumeLayout(false);
            this.groupBox23.ResumeLayout(false);
            this.groupBox23.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumOfExpReciEvent)).EndInit();
            this.groupBox29.ResumeLayout(false);
            this.groupBox29.PerformLayout();
            this.groupBox24.ResumeLayout(false);
            this.groupBox24.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTxPhShiftPos)).EndInit();
            this.groupBox25.ResumeLayout(false);
            this.groupBox25.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTimingReg)).EndInit();
            this.groupBox26.ResumeLayout(false);
            this.groupBox26.PerformLayout();
            this.groupBox27.ResumeLayout(false);
            this.groupBox27.PerformLayout();
            this.groupBox28.ResumeLayout(false);
            this.groupBox28.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTOFMeasMode)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPeriod)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPortSettings;
        private System.Windows.Forms.ListBox listBoxAvailablePorts;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxBaudrate;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.TabPage tabCalibration;
        private System.Windows.Forms.TabPage tabMeasurements;
        private System.Windows.Forms.Label labelPortOpened;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelModbusClientConnected;
        private System.Windows.Forms.Label labelReg2;
        private System.Windows.Forms.Label labelReg3;
        private System.Windows.Forms.Label labelReg1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelWindDirection;
        private System.Windows.Forms.Label labelWindSpeed;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelTOF1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelTOF2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelTOF3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelTOF0;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelComErrors;
        private System.Windows.Forms.Label labelMeasureErrors;
        private System.Windows.Forms.TabPage tabTDC1000;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.NumericUpDown numericTOF0;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.ComboBox comboBoxFreqDivider;
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.NumericUpDown numNumOfTxInBurst;
        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.CheckedListBox checkedListBoxErrorFlags;
        private System.Windows.Forms.GroupBox groupBox23;
        private System.Windows.Forms.ComboBox comboBoxNumOfMeasToAverageStw;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.NumericUpDown numericNumOfExpReciEvent;
        private System.Windows.Forms.GroupBox groupBox29;
        private System.Windows.Forms.ComboBox comboBoxTofTimeoutCtrl;
        private System.Windows.Forms.ComboBox comboBoxShortTOFBlankPeriod;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.CheckBox checkBoxForceShortTOF;
        private System.Windows.Forms.CheckBox checkBoxEchoTimeout;
        private System.Windows.Forms.GroupBox groupBox24;
        private System.Windows.Forms.CheckedListBox checkListBoxConfig4;
        private System.Windows.Forms.NumericUpDown numericTxPhShiftPos;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.GroupBox groupBox25;
        private System.Windows.Forms.ComboBox comboBoxPGAGain;
        private System.Windows.Forms.CheckBox checkBoxLNAFb;
        private System.Windows.Forms.CheckBox checkBoxLnaCtrl;
        private System.Windows.Forms.NumericUpDown numericTimingReg;
        private System.Windows.Forms.CheckBox checkBoxPgaCtrl;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.GroupBox groupBox26;
        private System.Windows.Forms.ComboBox comboBoxEchoQualThld;
        private System.Windows.Forms.CheckedListBox checkListBoxConfig3;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.GroupBox groupBox27;
        private System.Windows.Forms.ComboBox comboBoxAutozeroPeriod;
        private System.Windows.Forms.CheckBox checkBoxClockDiv;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.GroupBox groupBox28;
        private System.Windows.Forms.NumericUpDown numericTOFMeasMode;
        private System.Windows.Forms.CheckedListBox checkListBoxConfig2;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label labelDirection;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.CheckBox checkBoxAutoRefresh;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelTime2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label labelCalibration1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label labelCalibration2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label labelTime1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label labelClockCount;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox cbDirection3;
        private System.Windows.Forms.CheckBox cbDirection2;
        private System.Windows.Forms.CheckBox cbDirection1;
        private System.Windows.Forms.CheckBox cbDirection4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown numericPeriod;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

