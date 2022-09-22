using JetmasterModbus.Abstact;
using JetmasterModbus.Forms;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Threading;

namespace JetmasterModbus.Methods
{
    public class PressureChart : IPressure
    {

        public static ushort[] _points;

        private List<KeyValuePair<int,double>> PressureData = new List<KeyValuePair<int, double>>();


        public PressureChart()
        {

        }

        public int ReadData(int pressureData)
        {
            var test = _points[pressureData];
            return _points[pressureData];
        }

        public void SaveData(int val, double dateTime)
        {
            PressureData.Insert(0, new KeyValuePair<int, double>(val, dateTime));
        }

        public List<KeyValuePair<int, double>> DisplayPressure(int val)
        {
            if (_points != null)
            {
                SaveData(ReadData(val), DateTime.Now.ToOADate());
                Thread.Sleep(400);
            }

            return PressureData;
        }
    }
}
