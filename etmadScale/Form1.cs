using System;
using System.Diagnostics;
using System.IO.Ports;
using System.Threading;
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
            txtmode.SelectedIndex = 0;
        }


        private void label5_Click(object sender, EventArgs e)
        {
            Process.Start("https://ptsy.ir/");
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
                        txtPortName.Enabled = false;
                        txtBaudRate.Enabled = false;
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
                   
                    if (txtmode.SelectedIndex==0)
                    {
                        txtshowReadData.AppendText(Environment.NewLine + "> " + s);
                        txtshowReadData.ScrollToCaret();
                    }
                    else
                    {
                        var finalValue = s.TrimStart('0').Replace('@', '-');

                        if (finalValue.Contains("M"))
                            finalValue = finalValue.Substring(0, finalValue.IndexOf('M'));
                        string real = finalValue.Substring(0, finalValue.Length - 3);
                        string unreal = finalValue.Substring(finalValue.Length - 3);
                        finalValue = real + "." + unreal + " KG";
                        lblShowData.Text = finalValue;
                    }
                }
               
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            
            if (serialPortInput.IsOpen)
            {
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
                txtPortName.Enabled = true;
                txtBaudRate.Enabled = true;
                serialPortInput.Close();
                txtshowReadData.AppendText(Environment.NewLine + ">DISCONNECTED");
                
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtshowReadData.Clear();
            lblShowData.Text = "----------";
            txtshowReadData.AppendText(">TERMINAL IS CLEARED");
        }

        private void txtmode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtmode.SelectedIndex==1)
            {
                txtshowReadData.Visible = false;
                lblShowData.Visible = true;

            }
            else
            {
                txtshowReadData.Visible = true;
                lblShowData.Visible = false;
            }
        }
    }
}
