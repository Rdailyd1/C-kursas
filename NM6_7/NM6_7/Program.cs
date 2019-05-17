using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NM6_6
{
    class Program
    {
        public static void skaiciu_masyvas(decimal [] masyvas)
        {
            decimal elem = 0;
            for (int v = 0; v < 5; v++)
            {
                elem = masyvas[v];
                Console.Write(elem);
                if (v < 4)
                {
                    Console.Write(", ");
                }
                else
                {
                    Console.Write(".");
                }
            }
           
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            decimal[] sk_mas = new decimal[5];
           
            sk_mas[0] = 5.6m;
            sk_mas[1] = 3.2m;
            sk_mas[2] = 4.4m;
            sk_mas[3] = 7.3m;
            sk_mas[4] = 2.2m;
            skaiciu_masyvas(sk_mas);
        }
    }
}
