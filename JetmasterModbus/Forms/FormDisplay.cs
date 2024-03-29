﻿using JetmasterModbus.BaseClient;
using JetmasterModbus.Methods;
using JetmasterModbus.Modbus;
using Microsoft.Win32;
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

namespace JetmasterModbus.Forms
{
    public partial class FormDisplay : Form
    {
        public FormDisplay()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        public string PortName;
        public string Description = "Başlık";

        public ModbusCommunication ModbusCommunication;
        public List<Register> Registers = new List<Register>();

        private void FormDisplay_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 55; i++)
            {
                Registers.Add(new Register() { Address = (ushort)(0 + i) }); // cast type to ushort.
            }

            Task.Run(() => Test());

            dcFirstValue.Register = Registers[1];
            dcSecondValue.Register = Registers[50];

            lblPortName.Text = PortName;
            lblDesc.Text = Description;
        }


        bool Disconnect = false;
        int lastErrorVal = 0;

        public void Test()
        {
            try
            {
                if (ModbusCommunication.Connect() == true)
                {
                    while (Disconnect == false)
                    {
                        var data = ModbusCommunication.ReadHoldingRegistersAsync();

                        for (int i = 0; i < data.Length; i++)
                        {
                            Registers[i].Value = data[i];
                        }

                        PressureChart._points = data;

                        int ErrorVal = Registers[51].Value;

                        if (ErrorVal != 0 && ErrorVal != lastErrorVal)
                        {
                            lastErrorVal = ErrorVal;

                            string errorVal = JetmasterConfigs.CatchUp(ErrorVal);
                            FormMain.SendErrorLog
                                ("| Error | " +
                                " | Bağlantı Portu : " + PortName + " | " +
                                " | Bağlantı Başlığı : " + Description + " | " +
                                "Hata Kodu : " + errorVal);
                        }
                        else if (ErrorVal == 0 && lastErrorVal != 0) lastErrorVal = 0;
                    }
                }
            }
            catch (Exception exception)
            {
                FormMain.SendLog(PortName + " | Bağlantı kurulamadı. - "  + exception.Message);
            }
        }

        public void WriteHoldingRegisters(int val)
        {
            Task.Run(() => ModbusCommunication.WriteHoldingRegister(val));
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            FormDisplayConfigs formConfigs = new FormDisplayConfigs();
            formConfigs.formDisplay = this;
            formConfigs.ShowDialog();   
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Disconnect = true;
            FormMain.boundPortAdressess.Remove(this.PortName);
            FormMain._formDisplay = null;
            FormMain.formPressureDisplaysControl.Remove(this);

            Thread.Sleep(200);
            ModbusCommunication.Disconnect();
            this.Dispose();
        }
    }
}
