using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace etmadScale
{

    public partial class Form1 : Form
    {
        public Thread ReadSerialDataThread;
        public string serialDataRead;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //LoadConfigSetting();
        }

        private void LoadConfigSetting()
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtPortName_DropDown(object sender, EventArgs e)
        {
            txtPortName.Items.Clear();
            string[] comPorts = SerialPort.GetPortNames();
            foreach (var comPort in comPorts)
            {
                txtPortName.Items.Add(comPort);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
            btnDisconnect.Enabled = true;


            serialPortInput.PortName = txtPortName.Text;
            serialPortInput.BaudRate = int.Parse(txtBaudRate.Text);
            serialPortInput.Parity = Parity.None;
            serialPortInput.DataBits = 8;
            serialPortInput.StopBits = StopBits.One ;

            serialPortInput.Open();
            if (serialPortInput.IsOpen)
            {
                ReadSerialData();
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
            }


        }

        private void ReadSerialData()
        {
            try
            {
                ReadSerialDataThread = new Thread(ReadSerial);
                ReadSerialDataThread.Start();
            }
            catch (Exception e)
            {
                MessageBox.Show(@"Read Serial thread." + e.Message);
            }
        }

        private void ReadSerial()
        {
            while (serialPortInput.IsOpen)
            {
                serialPortInput.Write("s");
                serialDataRead = serialPortInput.ReadExisting();
                if (serialDataRead!="")
                {
                    serialDataRead = serialDataRead.TrimStart('0').Replace('@', '-');
                    serialDataRead = serialDataRead.Substring(0, serialDataRead.IndexOf('M')) + " KG";
                    showReadSerialValue(serialDataRead);
                    if (!checkTerminal.Checked)
                    {
                       
                        serialPortInput.Close();
                        break;
                    }
                }
                Thread.Sleep(500);
            }
           
        }

        public delegate void showSerialDelegate(string r);
        private void showReadSerialValue(string s)
        {
            if (txtshowReadData.InvokeRequired)
            {
                showSerialDelegate SSDD = showReadSerialValue;
                Invoke(SSDD, s);
            }
            else
            {
                txtshowReadData.AppendText(Environment.NewLine+ "> " + s);
                txtshowReadData.ScrollToCaret();
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            
            if (serialPortInput.IsOpen)
            {
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
                serialPortInput.Close();
                txtshowReadData.AppendText(Environment.NewLine + ">DISCONNECTED");
                
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtshowReadData.Clear();
            txtshowReadData.AppendText(">TERMINAL IS CLEARED");
        }
    }
}
