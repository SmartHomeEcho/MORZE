using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MORZE
{
    class Kod
    {
        private string _betu;
        private string _morzekod;
        public string Betu
        {
            get
            {
                return _betu;
            }
            set
            {
                if (value.Length == 1) _betu = value;
                else throw new Exception("Nem megfelelő hosszúságú betű!");
            }

        }
        public string MorzeKod
        {
            get
            {
                return _morzekod;
            }
            set
            {
                if (value.Length >= 1 && value.Length <= 6) _morzekod = value;
                else throw new Exception("Nem megfelelő hosszúságú morze kód!");
            }

        }
        public Kod(string betuadd, string morzekodadd)
        {
            Betu = betuadd;
            MorzeKod = morzekodadd;
        }

        
    }
}
