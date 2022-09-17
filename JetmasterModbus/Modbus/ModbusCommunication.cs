using JetmasterModbus.Abstact;
using JetmasterModbus.ModbusSerial;
using Modbus.Device;
using Modbus.Extensions.Enron;
using NModbus;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
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

        public bool Connect()
        {
            serialPort = new SerialPort();
            serialPort.BaudRate = _BaudRate;
            serialPort.DataBits = _DataBits;
            serialPort.Parity = _Parity;
            serialPort.StopBits = _StopBits;
            serialPort.PortName = _PortName;
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

        public Task<ushort[]> ReadHoldingRegisters()
        {
            return modbusSerialMaster.ReadHoldingRegistersAsync((byte)_SlaveId, 0, 55);
        }

        public void WriteHoldingRegisters(int val)
        {
            var modbusSerialRTU = new ModbusSerialRTU(modbusSerialMaster);
            modbusSerialMaster.WriteSingleRegisterAsync((byte)_SlaveId, 1, (ushort)val);
        }
    }
}
