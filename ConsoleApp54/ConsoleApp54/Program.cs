using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skaiciu_suma
{
    class Program
    {
        public static int nuo_iki(int nuo, int iki)
        {
            int suma = 0;
            for (int i = nuo; i <= iki; i++)
            {
                suma += i;
            }
            return suma;
        }
        public static int nuo_iki(int nuo, int iki, bool rodytiTarpineSuma)
        {
            int suma = 0;
            Console.WriteLine("Tarpine suma");
            for (int i = nuo; i <= iki; i++)
            {
                suma += i;
                Console.WriteLine(suma);
            }
            return suma;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu NUO");
            int nuo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu IKI");
            int iki = Convert.ToInt32(Console.ReadLine());
            int rez =nuo_iki(nuo, iki);
            Console.WriteLine("Rezultatas {0}", rez);
            nuo_iki(nuo, iki, true);
            Console.ReadKey();
        }
    }
}

