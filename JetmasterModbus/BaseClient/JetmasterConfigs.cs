using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JetmasterModbus.BaseClient
{
    internal class JetmasterConfigs
    {
        public static string CatchUp(int Error)
        {
            string errorVal = "";
            var test = ToBinary(Error, 13);
            char[] bytes = test.ToCharArray();

            for (int i = 0; i < bytes.Length; i++)
            {
                var x = Convert.ToInt32(bytes[i].ToString());
                if (x == 1)
                {
                    int intErrorVal = (bytes.Length - 1) - i;
                    var item = ErrorValue.ElementAt(intErrorVal);
                    var itemKey = item.Key;
                    errorVal += " " + itemKey.ToString();
                }
            }
            return errorVal;
        }

        private static string ToBinary(int number, int bitsLength = 32)
        {
            return NumberToBinary(number, bitsLength);
        }

        private static string NumberToBinary(int number, int bitsLength = 32)
        {
            string result = Convert.ToString(number, 2).PadLeft(bitsLength, '0');

            return result;
        }

        private static int FromBinaryToInt(string binary)
        {
            return BinaryToInt(binary);
        }

        private static int BinaryToInt(string binary)
        {
            return Convert.ToInt32(binary, 2);
        }

        public static Dictionary<string, int> Configs = new Dictionary<string, int>
        {
            {"P001_GenelCalisma",0},
            {"(J-02) P002_UflemeSuresi",1},
            {"P003_MaksimumSure",2},
            {"P004_OtomatikAyar",3},
            {"P005_FabrikaAyari",4},
            {"P006_PassKoruma",5},
            {"P007_Password",6},
            {"P008_UzaktanDurdurmaTercihi",7},
            {"P009_BuzzerSeviye",8},
            {"P010_VibroCalismaSikligi",9},
            {"P011_VibroSuresi",10},
            {"AI00_BasincSensoru",11},
            {"P100_UflemeBasinci",12},
            {"P101_MaksimumSure",13},
            {"P102_UflemeBasincMinDeger",14},
            {"P103_UflemeBasincMaxDeger",15},
            {"P104_UflemeBasincDegisimDegeri",16},
            {"P105_4mADegeri",17},
            {"P106_20mADegeri",18},
            {"P107_UflemeBasincGuvenlikSiniri",19},
            {"P108_HavaDevirKontrolu",20},
            {"P109_MinTankBasinci",21},
            {"P110_Basincsensorcikisi_Secimi",22},
            {"P111_HavauretecSetSuresi",23},
            {"P112_HavauretecMinCikis",24},
            {"P113_HavauretecMaxCikis",25},
            {"P114_HavauretecBaslangicCikisi",26},
            {"P115_HavauretecdegisimDegeri",27},
            {"AO01_HavaUretecMotorCikisi",28},
            {"AI01_FarkBasincSensero",29},
            {"P200_HedefFarkBasinci",30},
            {"P201_UflemePeryotMinDeger",31},
            {"P202_UflemePeryotMaxDeger",32},
            {"P203_UflemePeryotDegisimDegeri",33},
            {"P204_4mADegeri",34},
            {"P205_20mADegeri",35},
            {"P206_FiltrePatlakUyarisiMinDeger",36},
            {"P207_FiltreDoluUyarisiMaxDeger",37},
            {"P208_UflemeBasincAyari",38},
            {"P209_FarkBasincsensorcikisi_Secimi",39},
            {"P210_BasincMinCikisi",40},
            {"P211_BasincMaxCikisi",41},
            {"P212_BasincBaslangicCikisi",42},
            {"P213_BasincdegisimDegeri",43},
            {"AO02_BasincRegulatorCikisi",44},
            {"(J-01) P300_UflemePeryodu",45},
            {"DI00_DigitalGiris_Ufleme",46},
            {"DI01_DigitalGiris_Durdurma",47},
            {"P400_ModbusSlaveID",48},
            {"P401_ModbusBaundRate",49},
            {"Bironcekiislemdensonragecensure",50},
            {"Error.Val",51},
            {"Versiyon",52},
            {"(J-03) Maksimum röle adedi",53},
            {"P500 SYNC sinyali maksimum bekleme süres",54},
        };
        public static Dictionary<string, long> ErrorValue = new Dictionary<string, long>
        {
            {"E_01",0000000000001},
            {"E_02",0000000000010},
            {"E_03",0000000000100},
            {"E_04",0000000001000},
            {"E_05",0000000010000},
            {"E_06",0000000100000},
            {"E_07",0000001000000},
            {"E_08",0000010000000},
            {"E_09",0000100000000},
            {"E_10",0001000000000},
            {"E_11",0010000000000},
            {"E_12",0100000000000},
            {"E_13",1000000000000},
        };

    }
}
