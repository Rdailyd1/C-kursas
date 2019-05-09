using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NM5_6
{
    class daugybos_lentele
    {
        //master variables

        public int vienas(int skaicius)
        {
            int vienas = skaicius;
            return vienas;
        }
        public int du(int skaicius)
        {
            int du = skaicius * 2;
            return du;
        }

        public int trys(int skaicius)
        {
            int trys = skaicius * 3;
            return trys;
        }
        public int keturi(int skaicius)
        {
            int keturi = skaicius * 4;
            return keturi;
        }
        public int penki(int skaicius)
        {
            int penki = skaicius * 5;
            return penki;
        }
        public int sesi(int skaicius)
        {
            int sesi = skaicius * 6;
            return sesi;
        }
        public int septyni(int skaicius)
        {
            int septyni = skaicius * 7;
            return septyni;
        }
        public int astuoni(int skaicius)
        {
            int astuoni = skaicius * 8;
            return astuoni;
        }
        public int devyni(int skaicius)
        {
            int devyni = skaicius * 9;
            return devyni;
        }
        public int desimt(int skaicius)
        {
            int desimt = skaicius * 10;
            return desimt;
        }

        public void Display(int skaicius)
        {
            Console.Write(" 1 * {0}", skaicius + " = " + vienas(skaicius) + ",");
            Console.Write(" 2 * {0}", skaicius + " = " + du(skaicius) + ",");
            Console.Write(" 3 * {0}", skaicius + " = " + trys(skaicius) + ",");
            Console.Write(" 4 * {0}", skaicius + " = " + keturi(skaicius) + ",");
            Console.Write(" 5 * {0}", skaicius + " = " + penki(skaicius) + ",");
            Console.Write(" 6 * {0}", skaicius + " = " + sesi(skaicius) + ",");
            Console.Write(" 7 * {0}", skaicius + " = " + septyni(skaicius) + ",");
            Console.Write(" 8 * {0}", skaicius + " = " + astuoni(skaicius) + ",");
            Console.Write(" 9 * {0}", skaicius + " = " + devyni(skaicius) + ",");
            Console.Write(" 10 * {0}", skaicius + " = " + desimt(skaicius));
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            for (int skaicius = 0; skaicius <= 10; skaicius++)
            {
                daugybos_lentele lentele = new daugybos_lentele();
                lentele.Display(skaicius);
            }
            Console.ReadLine();
        }

    }
}
