using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacio_skaicius
{
    class Program
    {
        public static int kelimas_laipsniu(int skaicius, int laipsnis)
        {
            int rezultatas = 1;
            for (int i = 0; i < laipsnis; i++)
            {
                rezultatas *= skaicius;
            }

            return rezultatas;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite laipsni");
            int laipsnis = Convert.ToInt32(Console.ReadLine());
            int rez = kelimas_laipsniu(skaicius, laipsnis);
            Console.WriteLine("Rezultatas {0}", rez);
            Console.ReadKey();
        }
    }
}

