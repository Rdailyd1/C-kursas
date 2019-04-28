using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
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
            int trys= skaicius * 3;
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
            Console.WriteLine("1 * {0}", skaicius + " = " + vienas(skaicius));
            Console.WriteLine("2 * {0}", skaicius + " = " + du(skaicius));
            Console.WriteLine("3 * {0}", skaicius + " = " + trys(skaicius));
            Console.WriteLine("4 * {0}", skaicius + " = " + keturi(skaicius));
            Console.WriteLine("5 * {0}", skaicius + " = " + penki(skaicius));
            Console.WriteLine("6 * {0}", skaicius + " = " + sesi(skaicius));
            Console.WriteLine("7 * {0}", skaicius + " = " + septyni(skaicius));
            Console.WriteLine("8 * {0}", skaicius + " = " + astuoni(skaicius));
            Console.WriteLine("9 * {0}", skaicius + " = " + devyni(skaicius));
            Console.WriteLine("10 * {0}", skaicius  + " = " + desimt(skaicius));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int skaicius = 0;
            Console.WriteLine("Įveskite skaičių:");
            skaicius = Convert.ToInt16(Console.ReadLine());
           
           daugybos_lentele lentele = new daugybos_lentele();

            lentele.Display(skaicius);
            Console.ReadLine();
        }

    }
}
