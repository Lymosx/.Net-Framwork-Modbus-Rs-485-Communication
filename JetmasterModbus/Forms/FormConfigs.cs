using JetmasterModbus.Modbus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JetmasterModbus.Forms
{
    public partial class FormConfigs : Form
    {
        public FormConfigs()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;
        }

        public string PortName
        {
            get { return cbxPorts.Text; }
        }
        public string Title
        {
            get { return tbxName.Text; }
        }
        public int Baudrate
        {
            get { return Convert.ToInt32(cbxBaudrate.Text); }
        }
        public int DataBits
        {
            get { return Convert.ToInt32(cbxDataBits.Text); }
        }
        public Parity Parity
        {
            get
            {
                var parity = Parity.None;
                if (cbxParity.SelectedItem.Equals(Parity.None.ToString()))
                {
                    parity = Parity.None;
                }
                else if (cbxParity.SelectedItem.Equals(Parity.Odd.ToString()))
                {
                    parity = Parity.Odd;
                }
                else if (cbxParity.SelectedItem.Equals(Parity.Even.ToString()))
                {
                    parity = Parity.Even;
                }
                else if (cbxParity.SelectedItem.Equals(Parity.Mark.ToString()))
                {
                    parity = Parity.Mark;
                }
                else if (cbxParity.SelectedItem.Equals(Parity.Space.ToString()))
                {
                    parity = Parity.Space;
                }
                return parity;
            }
            set
            {
                cbxParity.SelectedItem = Convert.ToString(value);
            }
        }
        public StopBits StopBits
        {
            get
            {
                StopBits bits = StopBits.None;
                switch (cbxStopBits.SelectedIndex)
                {
                    case 0:
                        bits = StopBits.None;
                        break;
                    case 1:
                        bits = StopBits.One;
                        break;
                    case 2:
                        bits = StopBits.OnePointFive;
                        break;
                    case 3:
                        bits = StopBits.Two;
                        break;
                }
                return bits;
            }
            set
            {
                switch (value)
                {
                    case StopBits.None:
                        cbxStopBits.SelectedIndex = 0;
                        break;
                    case StopBits.One:
                        cbxStopBits.SelectedIndex = 1;
                        break;
                    case StopBits.OnePointFive:
                        cbxStopBits.SelectedIndex = 2;
                        break;
                    case StopBits.Two:
                        cbxStopBits.SelectedIndex = 3;
                        break;
                }
            }
        }
        public int SlaveId
        {
            get { return Convert.ToInt32(cbxSlaveId.Text); }
        }
        private void FormConfigs_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                cbxPorts.Items.Add(port);
            }

            if (cbxPorts.Items.Count != 0)
            {
                cbxPorts.SelectedIndex = 0;

                //2) Baudrates:
                string[] baudrates = { "230400", "115200", "57600", "38400", "19200", "9600" };

                foreach (string baudrate in baudrates)
                {
                    cbxBaudrate.Items.Add(baudrate);
                }

                cbxBaudrate.SelectedIndex = 1;

                // 3) Parity
                string[] parity = { "None", "Odd", "Even", "Mark", "Space" };

                foreach (string paritys in parity)
                {
                    cbxParity.Items.Add(paritys);
                }
                cbxParity.SelectedIndex = 0;

                // 4) StopBits
                string[] stopBits = { "None", "1", "1.5", "2", };

                foreach (string stopBit in stopBits)
                {
                    cbxStopBits.Items.Add(stopBit);
                }
                cbxStopBits.SelectedIndex = 1;

                //5) DataBits:

                string[] dataBits = { "7", "8" };

                foreach (string dataBit in dataBits)
                {
                    cbxDataBits.Items.Add(dataBit);
                }
                cbxDataBits.SelectedIndex = 1;

                //5) DataBits:

                for (int i = 0; i < 30; i++)
                {
                    cbxSlaveId.Items.Add(i);
                }
                cbxSlaveId.SelectedIndex = 1;

                //Textbox defaults:
                tbxName.Text = "Başlık";

                //tbxRegisterQty.Text = "20";
                //tbxSampleRate.Text = "1000";
                //tbxSlaveId.Text = "1";
                //tbxStartAddr.Text = "0";
            }
            else
            {
                this.Close();
                FormMain.SendLog("Bağlanılacak Port Yok !");
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                var match = FormMain.boundPortAdressess.FirstOrDefault(stringToCheck => stringToCheck.Contains(this.PortName));
                if (match == null)
                {
                    ModbusCommunication jetmaster = new ModbusCommunication()
                    {
                        _PortName = PortName,
                        _BaudRate = Baudrate,
                        _DataBits = DataBits,
                        _Parity = Parity,
                        _StopBits = StopBits,
                        _SlaveId = SlaveId
                    };

                    FormDisplay formDisplay = new FormDisplay();
                    formDisplay.Name = "form" + PortName;
                    formDisplay.Description = tbxName.Text;
                    formDisplay.PortName = PortName;
                    formDisplay.ModbusCommunication = jetmaster;

                    FormMain.AddDisplayForm(formDisplay);
                    this.Close();
                }
                else
                {
                    FormMain.SendLog(this.PortName + " Bağlantısı zaten açık!");
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
