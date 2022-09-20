using JetmasterModbus.Abstact;
using JetmasterModbus.ModbusSerial;
using Modbus.Device;
using Modbus.Extensions.Enron;
using NModbus;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace JetmasterModbus.Modbus
{
    public class ModbusCommunication
    {
        public ModbusCommunication()
        {          
        }

        private SerialPort serialPort;
        ModbusSerialMaster modbusSerialMaster;
        public string _PortName;
        public int _BaudRate { get; set; }
        public int _DataBits { get; set; }
        public Parity _Parity { get; set; }
        public StopBits _StopBits { get; set; }
        public int _SlaveId { get; set; }

        // Jetmaster Modbus Communication Configs Count.
        private ushort NumberOfPoints = 55;
        // Jetmaster Modbus Communication Start Adress.
        private ushort StartAdress = 0;

        public bool Connect()
        {
            serialPort = new SerialPort();
            serialPort.BaudRate = _BaudRate;
            serialPort.DataBits = _DataBits;
            serialPort.Parity = _Parity;
            serialPort.StopBits = _StopBits;
            serialPort.PortName = _PortName;

            // Do not change these values.
            serialPort.ReadTimeout = 400;
            serialPort.WriteTimeout = 400;

            modbusSerialMaster = ModbusSerialMaster.CreateRtu(serialPort);

            if (!serialPort.IsOpen)
            {
                serialPort.Open();
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Disconnect()
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }

        public ushort[] ReadHoldingRegistersAsync() =>
                Task.Run(() => modbusSerialMaster.ReadHoldingRegistersAsync((byte)_SlaveId, StartAdress, NumberOfPoints)).ConfigureAwait(false).GetAwaiter().GetResult();

        public void WriteHoldingRegister(int val) =>
            Task.Run(() => WriteHoldingRegisterAsync(val)).ConfigureAwait(false).GetAwaiter().GetResult();

        public async Task WriteHoldingRegisterAsync(int val)
        {
            await modbusSerialMaster.WriteSingleRegisterAsync((byte)_SlaveId, 1, (ushort)val);
        }
    }
}
