using JetmasterModbus.Abstact;
using Modbus.Device;
using NModbus;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JetmasterModbus.ModbusSerial
{
    internal class ModbusSerialRTU : IModbusSerial
    {
        ModbusSerialMaster _master;
        private bool disposedValue;

        public ModbusSerialRTU(ModbusSerialMaster master)
        {
            _master = master;
        }

        public ushort[] ReadHoldingRegisters(byte slaveAddress, ushort startAddress, ushort numberOfPoints)
        {
            byte _slaveID = slaveAddress;
            ushort _startAddress = startAddress;
            ushort _numOfPoints = numberOfPoints;
            ushort[] holding_register = _master.ReadHoldingRegisters(_slaveID, startAddress, _numOfPoints);

            return holding_register;
        }

        public Task<ushort[]> ReadHoldingRegistersAsync(byte slaveAddress, ushort startAddress, ushort numberOfPoints)
        {
            byte _slaveID = slaveAddress;
            ushort _startAddress = startAddress;
            ushort _numOfPoints = numberOfPoints;
            var holding_register = _master.ReadHoldingRegistersAsync(_slaveID, startAddress, _numOfPoints);

            return holding_register;
        }

        public void WriteSingleRegister(byte slaveAddress, ushort registerAddress, ushort value)
        {
            byte _slaveID = slaveAddress;
            ushort _registerAddress = registerAddress;
            ushort _value = value;

            _master.WriteSingleRegister(_slaveID, registerAddress, _value);
        }

        public async Task WriteSingleRegisterAsync(byte slaveAddress, ushort registerAddress, ushort value)
        {
            byte _slaveID = slaveAddress;
            ushort _registerAddress = registerAddress;
            ushort _value = value;

            await _master.WriteSingleRegisterAsync(_slaveID, registerAddress, _value);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: yönetilen durumu (yönetilen nesneleri) atın
                }

                // TODO: yönetilmeyen kaynakları (yönetilmeyen nesneleri) serbest bırakın ve sonlandırıcıyı geçersiz kılın
                // TODO: büyük alanları null olarak ayarlayın
                disposedValue = true;
            }
        }

        // // TODO: sonlandırıcıyı yalnızca 'Dispose(bool disposing)' içinde yönetilmeyen kaynakları serbest bırakacak kod varsa geçersiz kılın
        // ~ModbusSerialRTU()
        // {
        //     // Bu kodu değiştirmeyin. Temizleme kodunu 'Dispose(bool disposing)' metodunun içine yerleştirin.
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Bu kodu değiştirmeyin. Temizleme kodunu 'Dispose(bool disposing)' metodunun içine yerleştirin.
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
