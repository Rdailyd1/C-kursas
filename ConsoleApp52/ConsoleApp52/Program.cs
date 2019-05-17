using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp52
{
    class Program
    {
        public static void skaitmenys(int skaicius)
        {
            int sum = 0;
            int el = 0;
            while (skaicius != 0)
            {
                sum += skaicius % 10;
                skaicius /= 10;
                el++;
            }
            Console.WriteLine("Skaitmenu suma {0}", sum);
            Console.WriteLine("Elementu skaicius {0}", el);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int skaicius = Convert.ToInt16(Console.ReadLine());
            skaitmenys(skaicius);
        }
    }
}
