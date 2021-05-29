using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MORZE
{
    class Kodtabla
    {
        public static List<Kod> adatok = new List<Kod>();
        StreamReader olvas = new StreamReader("morzeabc.txt", Encoding.Default);
        public void beolvasas()
        {
            string fejlec = olvas.ReadLine();
            while (!olvas.EndOfStream)
            {
                string sor = olvas.ReadLine();
                string[] sorelemek = sor.Split('\t');
                adatok.Add(new Kod(sorelemek[0], sorelemek[1]));

            }

        }
        public Kodtabla()
        {
            beolvasas();
        }
    }
}
