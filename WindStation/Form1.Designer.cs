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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPortSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tabMeasurements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPortSettings);
            this.tabControl1.Controls.Add(this.tabSettings);
            this.tabControl1.Controls.Add(this.tabCalibration);
            this.tabControl1.Controls.Add(this.tabMeasurements);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(657, 298);
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
            this.tabPortSettings.Size = new System.Drawing.Size(649, 272);
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
            this.tabSettings.Size = new System.Drawing.Size(486, 272);
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
            this.tabCalibration.Size = new System.Drawing.Size(486, 272);
            this.tabCalibration.TabIndex = 1;
            this.tabCalibration.Text = "Sensor Calibration";
            this.tabCalibration.UseVisualStyleBackColor = true;
            // 
            // tabMeasurements
            // 
            this.tabMeasurements.Controls.Add(this.label7);
            this.tabMeasurements.Controls.Add(this.chart1);
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
            this.tabMeasurements.Size = new System.Drawing.Size(649, 272);
            this.tabMeasurements.TabIndex = 2;
            this.tabMeasurements.Text = "Measurements";
            this.tabMeasurements.UseVisualStyleBackColor = true;
            // 
            // labelTOF1
            // 
            this.labelTOF1.AutoSize = true;
            this.labelTOF1.Location = new System.Drawing.Point(73, 119);
            this.labelTOF1.Name = "labelTOF1";
            this.labelTOF1.Size = new System.Drawing.Size(13, 13);
            this.labelTOF1.TabIndex = 21;
            this.labelTOF1.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 119);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "TOF 1:";
            // 
            // labelTOF2
            // 
            this.labelTOF2.AutoSize = true;
            this.labelTOF2.Location = new System.Drawing.Point(73, 138);
            this.labelTOF2.Name = "labelTOF2";
            this.labelTOF2.Size = new System.Drawing.Size(13, 13);
            this.labelTOF2.TabIndex = 19;
            this.labelTOF2.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 138);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "TOF 2:";
            // 
            // labelTOF3
            // 
            this.labelTOF3.AutoSize = true;
            this.labelTOF3.Location = new System.Drawing.Point(73, 157);
            this.labelTOF3.Name = "labelTOF3";
            this.labelTOF3.Size = new System.Drawing.Size(13, 13);
            this.labelTOF3.TabIndex = 17;
            this.labelTOF3.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "TOF 3:";
            // 
            // labelTOF0
            // 
            this.labelTOF0.AutoSize = true;
            this.labelTOF0.Location = new System.Drawing.Point(73, 100);
            this.labelTOF0.Name = "labelTOF0";
            this.labelTOF0.Size = new System.Drawing.Size(13, 13);
            this.labelTOF0.TabIndex = 15;
            this.labelTOF0.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 100);
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chart1
            // 
            chartArea1.AxisX.Interval = 10D;
            chartArea1.AxisX.Maximum = 60D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(140, 20);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Wind Speed";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(501, 236);
            this.chart1.TabIndex = 22;
            this.chart1.Text = "chart1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "-----";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 298);
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
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label7;
    }
}

