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
            txtPortName.Items.Insert(0, "---انتخاب پورت ---");
            txtPortName.SelectedIndex = 0;
            txtBaudRate.Items.Insert(0, "---انتخاب BaudRate ---");
            txtBaudRate.SelectedIndex = 0;
            //LoadConfigSetting();
        }

        private void LoadConfigSetting()
        {
           
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtPortName_DropDown(object sender, EventArgs e)
        {
            txtPortName.Items.Clear();
            txtPortName.Items.Insert(0, "---انتخاب پورت ---");
            txtPortName.SelectedIndex = 0;
            string[] comPorts = SerialPort.GetPortNames();
            foreach (var comPort in comPorts)
            {
                txtPortName.Items.Add(comPort);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (validationInputs())
            {
               
                serialConfig();

                try
                {
                    serialPortInput.Open();
                    if (serialPortInput.IsOpen)
                    {
                        btnConnect.Enabled = false;
                        btnDisconnect.Enabled = true;
                        btnZero.Enabled = true;
                        btnHold.Enabled = true;
                        ReadSerialData();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(@"عدم توانایی اتصال به ترازو." + exception.Message);
                }
            }
            else
            {
                MessageBox.Show("لطفا موارد اجباری را انتخاب کنید ");
            }


        }

        private void serialConfig()
        {
            serialPortInput.PortName = txtPortName.Text;
            serialPortInput.BaudRate = int.Parse(txtBaudRate.Text);
            serialPortInput.Parity = Parity.None;
            serialPortInput.DataBits = 8;
            serialPortInput.StopBits = StopBits.One;
        }

        private bool validationInputs()
        {
            if (txtPortName.SelectedIndex==0 || txtBaudRate.SelectedIndex==0)
            {
                return false;
            }

            return true;
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
                showReadSerialValue(serialDataRead);
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
                if (s != "")
                {
                    var finalValue = s.TrimStart('0').Replace('@', '-');

                    if (finalValue.Contains("M"))
                        finalValue = finalValue.Substring(0, finalValue.IndexOf('M'));
                    txtshowReadData.AppendText(Environment.NewLine + "> " + finalValue+" KG");
                    txtshowReadData.ScrollToCaret();
                }
               
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            
            if (serialPortInput.IsOpen)
            {
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
                btnZero.Enabled = false;
                btnHold.Enabled = false;
                serialPortInput.Close();
                txtshowReadData.AppendText(Environment.NewLine + ">DISCONNECTED");
                
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtshowReadData.Clear();
            txtshowReadData.AppendText(">TERMINAL IS CLEARED");
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (serialPortInput.IsOpen)
            {
                txtshowReadData.AppendText(Environment.NewLine + ">ZERO");
                serialPortInput.Write("z");

            }
        }

        private void btnHold_Click(object sender, EventArgs e)
        {
            if (serialPortInput.IsOpen)
            {
                txtshowReadData.AppendText(Environment.NewLine + ">HOLD");
                serialPortInput.Write("h");

            }
        }
    }
}
