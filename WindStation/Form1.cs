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
            short[] registerValues = new short[20];
            modbus.ReadRegisters(0, 0, 10,ref registerValues);
            labelPortOpened.Text = "✓";
            labelPortOpened.ForeColor = Color.Green;

            labelModbusClientConnected.Text = "✓";
            labelModbusClientConnected.ForeColor = Color.Green;
            Debug.WriteLine(modbus.modbusStatus);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            short[] regs = new short[3];
            modbus.ReadRegisters(1, 1, 3, ref regs);
            Debug.WriteLine(modbus.modbusStatus);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            short[] regs = new short[12];
            modbus.ReadRegisters(1, 1, 12, ref regs);
            Debug.WriteLine(modbus.modbusStatus);
            byte[] result = new byte[regs.Length * 2];
            Buffer.BlockCopy(regs, 0, result, 0, result.Length);
            labelWindSpeed.Text = ToFloat(result, 0).ToString();
            labelWindDirection.Text = ToFloat(result, 4).ToString();
            labelTOF0.Text = ToFloat(result, 8).ToString();
            labelTOF1.Text = ToFloat(result, 12).ToString();
            labelTOF2.Text = ToFloat(result, 16).ToString();
            labelTOF3.Text = ToFloat(result, 20).ToString();
            label7.Text = modbus.modbusStatus;
            chart1.Series[0].Points.Add(ToFloat(result, 0));
            if (chart1.Series[0].Points.Count > 60) chart1.Series[0].Points.RemoveAt(0);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("Selected tab: " + tabControl1.SelectedIndex.ToString());
            if (tabControl1.SelectedIndex == 3)
            {
                timer1.Interval = 1000;
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }
    }
}
