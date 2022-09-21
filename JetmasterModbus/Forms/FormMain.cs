using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using JetmasterModbus.Forms;
using JetmasterModbus.Modbus;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JetmasterModbus
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            _flpDisplay = flpDisplay;
            _lbxLogger = lbxLogger;
            _lbxErrorLogger = lbxErrorLogger;
        }

        public static FormDisplay _formDisplay;
        public static FormPressure _formPressure;

        public static FlowLayoutPanel _flpDisplay;
        public static ListBox _lbxLogger;
        public static ListBox _lbxErrorLogger;

        public static bool IsOpen;

        public static List<string> boundPortAdressess = new List<string>();
        public static List<FormDisplay> formPressureDisplaysControl = new List<FormDisplay>();


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConfigs formConfigs = new FormConfigs();
            formConfigs.ShowDialog();
        }


        public static void SetDisplay(string Title, string formName)
        {
            var match = formPressureDisplaysControl.FirstOrDefault(stringToCheck => stringToCheck.Name.Contains(formName));
            match.lblDesc.Text = Title;
        }

        public static void GetFormDisplay(FormDisplay formDisplay)
        {
            formDisplay.TopLevel = false;
            formDisplay.AutoScroll = false;
            formDisplay.AutoSize = true;
            formDisplay.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            _formDisplay = formDisplay;
        }
        public static void AddDisplayForm(FormDisplay formDisplay)
        {
            try
            {
                formDisplay.TopLevel = false;
                formDisplay.AutoScroll = true;
                formDisplay.AutoSize = true;
                //formDisplay.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                formDisplay.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                boundPortAdressess.Add(formDisplay.PortName);
                formPressureDisplaysControl.Add(formDisplay);

                _flpDisplay.Controls.Add(formDisplay);
                formDisplay.Show();
            }
            catch (Exception exception)
            {
                _lbxLogger.Items.Add(DateTime.Now + "\t " + exception.Message);
            }
        }

        public static void SendLog(string msg)
        {
            _lbxLogger.Items.Add(DateTime.Now + "\t " + msg);
        }

        public static void SendErrorLog(string msg)
        {
            _lbxErrorLogger.Items.Add(DateTime.Now + "\t " + msg);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }


        private void tabMain_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == tabPressureGraph)
            {
                if (_formPressure != null)
                {

                }
                else
                {
                    FormPressure formPressure = new FormPressure();
                    formPressure.TopLevel = false;          
                    tabPressureGraph.Controls.Add(formPressure);
                    formPressure.Dock = DockStyle.Fill;
                    formPressure.Show();
                }
            }
        }
    }
}
