using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindStation
{
    public partial class Form1 : Form
    {
        Modbus modbus = new Modbus();
        public Form1()
        {
            InitializeComponent();
            ScanAvailablePorts();
        }

        private void ScanAvailablePorts()
        {
            listBoxAvailablePorts.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
            {
                listBoxAvailablePorts.Items.Add(s);
                listBoxAvailablePorts.SelectedIndex = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ScanAvailablePorts();
        }

        private void tabPortSettings_Click(object sender, EventArgs e)
        {

        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {

                Int32 baudRate;
                Int32.TryParse(comboBoxBaudrate.Text, out baudRate);
                modbus.Open(listBoxAvailablePorts.SelectedItem.ToString(), baudRate, 8, Parity.None, StopBits.One);
            }
            catch
            {

            }
            UInt16[] registerValues = new UInt16[20];
            modbus.ReadRegisters(0, 0, 10,ref registerValues);
            labelPortOpened.Text = "✓";
            labelPortOpened.ForeColor = Color.Green;

            labelModbusClientConnected.Text = "✓";
            labelModbusClientConnected.ForeColor = Color.Green;
            Debug.WriteLine(modbus.modbusStatus);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UInt16[] regs = new UInt16[3];
            modbus.ReadRegisters(1, 1, 3, ref regs);
            Debug.WriteLine($"Modbus status: {modbus.modbusStatus}");
            labelReg1.Text = regs[0].ToString("X4");
            labelReg2.Text = regs[1].ToString("X4");
            labelReg3.Text = regs[2].ToString("X4");
        }
        static float ToFloat(byte[] input, int index)
        {
            byte[] newArray = new[] { input[index + 2], input[index + 3], input[index + 0], input[index + 1] };
            return BitConverter.ToSingle(newArray, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {

        }
        void TDC1000RefreshRegisters()
        {
            UInt16[] regs = new UInt16[100];
            modbus.ReadRegisters(1, 14, 6, ref regs);

            #region Confg 0
            byte temp = (byte)(regs[0] / 256);
            switch ((temp & 0xe0) >> 5)
            {
                case 0:
                    comboBoxFreqDivider.Text = "2";
                    break;
                case 1:
                    comboBoxFreqDivider.Text = "4";
                    break;
                case 2:
                    comboBoxFreqDivider.Text = "8";
                    break;
                case 3:
                    comboBoxFreqDivider.Text = "16";
                    break;
                case 4:
                    comboBoxFreqDivider.Text = "32";
                    break;
                case 5:
                    comboBoxFreqDivider.Text = "64";
                    break;
                case 6:
                    comboBoxFreqDivider.Text = "128";
                    break;
                case 7:
                    comboBoxFreqDivider.Text = "256";
                    break;
            }
            numNumOfTxInBurst.Value = temp & 0x1F;
            #endregion

            #region Config 1

            temp = (byte)(regs[0] % 256);
            switch ((temp & 0x38) >> 3)
            {
                case 0:
                    comboBoxNumOfMeasToAverageStw.Text = "1";
                    break;
                case 1:
                    comboBoxNumOfMeasToAverageStw.Text = "2";
                    break;
                case 2:
                    comboBoxNumOfMeasToAverageStw.Text = "4";
                    break;
                case 3:
                    comboBoxNumOfMeasToAverageStw.Text = "8";
                    break;
                case 4:
                    comboBoxNumOfMeasToAverageStw.Text = "16";
                    break;
                case 5:
                    comboBoxNumOfMeasToAverageStw.Text = "32";
                    break;
                case 6:
                    comboBoxNumOfMeasToAverageStw.Text = "64";
                    break;
                case 7:
                    comboBoxNumOfMeasToAverageStw.Text = "128";
                    break;
            }
            numericNumOfExpReciEvent.Value = temp & 0x07;

            #endregion

            #region Config 2

            temp = (byte)(regs[1] / 256);
            for (int i = 0; i < checkListBoxConfig2.Items.Count; i++)
            {
                checkListBoxConfig2.SetItemChecked(i, (0x80 >> i & temp) == 0x80 >> i);
            }
            numericTOFMeasMode.Value = temp & 0x03;
            #endregion

            #region Config 3

            temp = (byte)(regs[1] % 256);
            for (int i = 0; i < checkListBoxConfig3.Items.Count; i++)
            {
                checkListBoxConfig3.SetItemChecked(i, ((0x40 >> i & temp) == 0x40 >> i));
            }
            switch (temp & 0x07)
            {
                case 0:
                    comboBoxEchoQualThld.Text = "-35 mV";
                    break;
                case 1:
                    comboBoxEchoQualThld.Text = "-50 mV";
                    break;
                case 2:
                    comboBoxEchoQualThld.Text = "-75 mV";
                    break;
                case 3:
                    comboBoxEchoQualThld.Text = "-125 mV";
                    break;
                case 4:
                    comboBoxEchoQualThld.Text = "-220 mV";
                    break;
                case 5:
                    comboBoxEchoQualThld.Text = "-410 mV";
                    break;
                case 6:
                    comboBoxEchoQualThld.Text = "-775 mV";
                    break;
                case 7:
                    comboBoxEchoQualThld.Text = "-1500 mV";
                    break;
            }
            #endregion

            #region Config 4

            temp = (byte)(regs[2] / 256);
            for (int i = 0; i < checkListBoxConfig4.Items.Count; i++)
            {
                checkListBoxConfig4.SetItemChecked(i, (0x40 >> i & temp) == 0x40 >> i);
            }
            numericTxPhShiftPos.Value = temp & 0x1F;

            #endregion

            #region TOF 1
            temp = (byte)(regs[2] % 256);
            switch (temp >> 5)
            {
                case 0:
                    comboBoxPGAGain.Text = "0 dB";
                    break;
                case 1:
                    comboBoxPGAGain.Text = "3 dB";
                    break;
                case 2:
                    comboBoxPGAGain.Text = "6 dB";
                    break;
                case 3:
                    comboBoxPGAGain.Text = "9 dB";
                    break;
                case 4:
                    comboBoxPGAGain.Text = "12 dB";
                    break;
                case 5:
                    comboBoxPGAGain.Text = "15 dB";
                    break;
                case 6:
                    comboBoxPGAGain.Text = "18 dB";
                    break;
                case 7:
                    comboBoxPGAGain.Text = "21 dB";
                    break;
            }
            checkBoxPgaCtrl.Checked = (temp & 0x10) == 0x0;
            checkBoxLnaCtrl.Checked = (temp & 0x08) == 0x00;
            checkBoxLNAFb.Checked = (temp & 0x04) == 0x04;
            numericTimingReg.Value = temp & 0x03;
            #endregion

            #region TOF 0

            numericTOF0.Value = (byte)(regs[3] / 256);

            #endregion

            #region Error Flags
            temp = (byte)(regs[3] % 256);
            for (int i = 0; i < checkedListBoxErrorFlags.Items.Count; i++)
            {
                checkedListBoxErrorFlags.SetItemChecked(i, (0x04 >> i & temp) == 0x04 >> i);
            }
            #endregion

            #region Timeout

            temp = (byte)(regs[4] / 256);
            checkBoxForceShortTOF.Checked = (temp & 0x40) == 0x40;
            checkBoxEchoTimeout.Checked = (temp & 0x04) == 0x04;
            switch (temp & 0x03)
            {
                case 0:
                    comboBoxTofTimeoutCtrl.Text = "128";
                    break;
                case 1:
                    comboBoxTofTimeoutCtrl.Text = "256";
                    break;
                case 2:
                    comboBoxTofTimeoutCtrl.Text = "512";
                    break;
                case 3:
                    comboBoxTofTimeoutCtrl.Text = "1024";
                    break;
            }
            switch ((temp >> 3) & 0x07)
            {
                case 0:
                    comboBoxShortTOFBlankPeriod.Text = "8";
                    break;
                case 1:
                    comboBoxShortTOFBlankPeriod.Text = "16";
                    break;
                case 2:
                    comboBoxShortTOFBlankPeriod.Text = "32";
                    break;
                case 3:
                    comboBoxShortTOFBlankPeriod.Text = "64";
                    break;
                case 4:
                    comboBoxShortTOFBlankPeriod.Text = "128";
                    break;
                case 5:
                    comboBoxShortTOFBlankPeriod.Text = "256";
                    break;
                case 6:
                    comboBoxShortTOFBlankPeriod.Text = "512";
                    break;
                case 7:
                    comboBoxShortTOFBlankPeriod.Text = "1024";
                    break;
            }
            #endregion

            #region Clock Rate

            temp = (byte)(regs[4] % 256);
            checkBoxClockDiv.Checked = (temp & 0x04) == 0x04;
            switch (temp & 0x03)
            {
                case 0:
                    comboBoxAutozeroPeriod.Text = "64";
                    break;
                case 1:
                    comboBoxAutozeroPeriod.Text = "128";
                    break;
                case 2:
                    comboBoxAutozeroPeriod.Text = "256";
                    break;
                case 3:
                    comboBoxAutozeroPeriod.Text = "512";
                    break;
            }

            #endregion

            labelDirection.Text = (regs[5] / 256).ToString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            switch(tabControl1.SelectedIndex)
            {
                case 3:
                    {
                        UInt16[] regs = new UInt16[13];
                        modbus.ReadRegisters(1, 1, 13, ref regs);
                        Debug.WriteLine(modbus.modbusStatus);
                        byte[] result = new byte[regs.Length * 2];
                        Buffer.BlockCopy(regs, 0, result, 0, result.Length);
                        labelWindSpeed.Text = ToFloat(result, 0).ToString();
                        labelWindDirection.Text = ToFloat(result, 4).ToString();
                        labelTOF0.Text = ToFloat(result, 8).ToString();
                        labelTOF1.Text = ToFloat(result, 12).ToString();
                        labelTOF2.Text = ToFloat(result, 16).ToString();
                        labelTOF3.Text = ToFloat(result, 20).ToString();
                        labelMeasureErrors.Text = System.BitConverter.ToInt16(result, 24).ToString();
                        labelComErrors.Text = modbus.modbusStatus;
                        //chart1.Series[0].Points.Add(ToFloat(result, 0));
                        //if (chart1.Series[0].Points.Count > 60) chart1.Series[0].Points.RemoveAt(0);
                    }
                    break;
                case 4:
                    {
                        if (checkBoxAutoRefresh.Checked)
                        {
                            TDC1000RefreshRegisters();
                        }
                    }
                    break;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("Selected tab: " + tabControl1.SelectedIndex.ToString());
            if (tabControl1.SelectedIndex == 3)
            {
                timer1.Interval = 500;
                timer1.Start();
            }
            else if(tabControl1.SelectedIndex == 4)
            {
                timer1.Interval = 500;
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxAutoRefresh.Checked)
            {
                buttonRefresh.Enabled = false;
                buttonSet.Enabled = false;
            }
            else
            {
                buttonRefresh.Enabled = true;
                buttonSet.Enabled = true;
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            TDC1000RefreshRegisters();
        }

        void TDC1000SetRegisters()
        {
            UInt16[] regs = new UInt16[10];
            byte value = 0;

            //TDC1000SetConfig0
            value = (byte)(comboBoxFreqDivider.SelectedIndex);
            if (value == 0xff) value = 0;
            value <<= 5;
            value |= (byte)numNumOfTxInBurst.Value;
            regs[0] = (UInt16)(256 * value);

            //TDC1000SetConfig1()
            value = (byte)(numericNumOfExpReciEvent.Value);
            var temp = (byte)(comboBoxNumOfMeasToAverageStw.SelectedIndex);
            if (temp == 0xff) temp = 0; 
            value |= (byte)(temp << 3);
            regs[0] |= value;

            //TDC1000SetConfig2()
            value = 0;
            for (int i = 0; i < checkListBoxConfig2.Items.Count; i++)
            {
                if (checkListBoxConfig2.GetItemChecked(i))
                {
                    value |= (byte)(0x80 >> i);
                }
            }
            value |= (byte)numericTOFMeasMode.Value;
            regs[1] =(UInt16)(256 * value);

            //TDC1000SetConfig3()
            value = (byte)comboBoxEchoQualThld.SelectedIndex;
            if (value == 0xff) value = 0;
            for (int i = 0; i < checkListBoxConfig3.Items.Count; i++)
            {
                if (checkListBoxConfig3.GetItemChecked(i))
                {
                    value |= (byte)(0x40 >> i);
                }
            }
            regs[1] |= value;

            //TDC1000SetConfig4()
            value = (byte)(numericTxPhShiftPos.Value);
            for (int i = 0; i < checkListBoxConfig4.Items.Count; i++)
            {
                if (checkListBoxConfig4.GetItemChecked(i))
                {
                    value |= (byte)(0x40 >> i);
                }
            }
            regs[2] = (UInt16)(256 * value);

            //TDC1000SetTOF1()
            value = ((byte)comboBoxPGAGain.SelectedIndex == 0xff) ? (byte)0 : (byte)(comboBoxPGAGain.SelectedIndex << 5);
            if (!checkBoxPgaCtrl.Checked) value |= 0x10;
            if (!checkBoxLnaCtrl.Checked) value |= 0x08;
            if (checkBoxLNAFb.Checked) value |= 0x04;
            value |= (byte)numericTimingReg.Value;
            regs[2] |= value;

            //TDC1000SetTOF0()
            value = (byte)numericTOF0.Value;
            regs[3] = (UInt16)(256 * value);

            //TDC1000SetErrorFlags()
            value = 0;
            for (int i = 0; i < checkedListBoxErrorFlags.Items.Count; i++)
            {
                if (checkedListBoxErrorFlags.GetItemChecked(i))
                {
                    value |= (byte)(0x4 >> i);
                }
            }
            regs[3] |= value;

            //Timeout
            value = 0;
            if(checkBoxForceShortTOF.Checked) value |= 0x40;
            if(checkBoxEchoTimeout.Checked) value |= 0x04;
            switch (comboBoxTofTimeoutCtrl.Text)
            {
                case "128":
                    break;
                case "256":
                    value |= 1;
                    break;
                case "512":
                    value |= 2;
                    break;
                case "1024":
                    value |= 3;
                    break;
            }
            switch (comboBoxShortTOFBlankPeriod.Text)
            {
                case "8":

                    break;
                case "16":
                    value |= 1 << 3;
                    break;
                case "32":
                    value |= 2 << 3;
                    break;
                case "64":
                    value |= 3 << 3;
                    break;
                case "128":
                    value |= 4 << 3;
                    break;
                case "256":
                    value |= 5 << 3;
                    break;
                case "512":
                    value |= 6 << 3;
                    break;
                case "1024":
                    value |= 7 << 3;
                    break;
            }
            regs[4] = (UInt16)(value * 256);

            //TDC1000SetClockRate()
            value = ((byte)(comboBoxAutozeroPeriod.SelectedIndex) == 0xff) ? (byte)0:(byte)(comboBoxAutozeroPeriod.SelectedIndex);
            if (checkBoxClockDiv.Checked) value |= 0x04;
            regs[4] |= value;




            modbus.WriteMultipleRegisters(1, 14, 5, regs);
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            TDC1000SetRegisters();
        }
    }
}
