using JetmasterModbus.BaseClient;
using JetmasterModbus.Modbus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JetmasterModbus.Forms
{
    public partial class FormDisplayConfigs : Form
    {
        public FormDisplayConfigs()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        public FormDisplay formDisplay;

        private void FormDisplayConfigs_Load(object sender, EventArgs e)
        {
            foreach (var kvp in JetmasterConfigs.Configs)
            {
                cbxFirstDisplay.Items.Add(kvp.Key);
                cbxSecondDisplay.Items.Add(kvp.Key);
                cbxConfig1.Items.Add(kvp.Key);
            }

            tbxTitle.Text = formDisplay.Description;
            cbxFirstDisplay.SelectedIndex = 1;
            cbxSecondDisplay.SelectedIndex = 50;
            cbxConfig1.SelectedIndex = 1;

            displayControl1.Register = formDisplay.Registers[1];

            this.Text = formDisplay.PortName + " | " + formDisplay.Description;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            FormMain.SetDisplay(this.tbxTitle.Text, formDisplay.Name);

            string firstKey = cbxFirstDisplay.SelectedItem.ToString();
            var firtDisplay = JetmasterConfigs.Configs.FirstOrDefault(t => t.Key == firstKey);
            int firstAdress = firtDisplay.Value;
            formDisplay.dcFirstValue.Register = formDisplay.Registers[firstAdress];

            string secondKey = cbxSecondDisplay.SelectedItem.ToString();
            var secondDisplay = JetmasterConfigs.Configs.FirstOrDefault(t => t.Key == secondKey);
            int secondAdress = secondDisplay.Value;
            formDisplay.dcSecondValue.Register = formDisplay.Registers[secondAdress];

            this.Close();
        }



        private void btnConfgisApply_Click(object sender, EventArgs e)
        {
            int val = Convert.ToInt32(tbxConfig1.Text);
            formDisplay.WriteHoldingRegisters(val);
        }

        private void cbxConfig1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string firstKey = cbxConfig1.SelectedItem.ToString();
            var firtDisplay = JetmasterConfigs.Configs.FirstOrDefault(t => t.Key == firstKey);
            int firstAdress = firtDisplay.Value;
            displayControl1.Register = formDisplay.Registers[firstAdress];
        }
    }
}
