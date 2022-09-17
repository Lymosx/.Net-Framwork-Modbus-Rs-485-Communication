using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JetmasterModbus.Abstact
{
    internal interface IModbusSerial : IModbus
    {
        //bool[] ReadCoils(byte slaveAddress, ushort startAddress, ushort numberOfPoints);
        //Task<bool[]> ReadCoilsAsync(byte slaveAddress, ushort startAddress, ushort numberOfPoints);
        //bool[] ReadInputs(byte slaveAddress, ushort startAddress, ushort numberOfPoints);
        //Task<bool[]> ReadInputsAsync(byte slaveAddress, ushort startAddress, ushort numberOfPoints);
        ushort[] ReadHoldingRegisters(byte slaveAddress, ushort startAddress, ushort numberOfPoints);
        Task<ushort[]> ReadHoldingRegistersAsync(byte slaveAddress, ushort startAddress, ushort numberOfPoints);
        //ushort[] ReadInputRegisters(byte slaveAddress, ushort startAddress, ushort numberOfPoints);
        //Task<ushort[]> ReadInputRegistersAsync(byte slaveAddress, ushort startAddress, ushort numberOfPoints);
        //void WriteSingleCoil(byte slaveAddress, ushort coilAddress, bool value);
        //Task WriteSingleCoilAsync(byte slaveAddress, ushort coilAddress, bool value);
        void WriteSingleRegister(byte slaveAddress, ushort registerAddress, ushort value);
        Task WriteSingleRegisterAsync(byte slaveAddress, ushort registerAddress, ushort value);
        //void WriteMultipleRegisters(byte slaveAddress, ushort startAddress, ushort[] data);
        //Task WriteMultipleRegistersAsync(byte slaveAddress, ushort startAddress, ushort[] data);
        //void WriteMultipleCoils(byte slaveAddress, ushort startAddress, bool[] data);
        //Task WriteMultipleCoilsAsync(byte slaveAddress, ushort startAddress, bool[] data);
        //ushort[] ReadWriteMultipleRegisters(byte slaveAddress, ushort startReadAddress, ushort numberOfPointsToRead, ushort startWriteAddress, ushort[] writeData);
        //Task<ushort[]> ReadWriteMultipleRegistersAsync(byte slaveAddress, ushort startReadAddress, ushort numberOfPointsToRead, ushort startWriteAddress, ushort[] writeData);
    }
}
