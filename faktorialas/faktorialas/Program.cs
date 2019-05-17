using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faktorialas
{
    class Program
    {
        public static int faktor(int skaicius)
        {
            if (skaicius == 1)
                return 1;
            else
                return skaicius * faktor(skaicius-1);
        }
              
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            int rez = faktor(skaicius);
            Console.WriteLine("Skaiciaus {0} faktorialas {1}", skaicius, rez);
            Console.ReadKey();
        }
    }
}