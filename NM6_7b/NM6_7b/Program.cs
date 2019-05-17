using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NM6_7b
{
    class Program
    {
        public static decimal skaiciu_masyvas(decimal[] masyvas)
        {
            decimal sum = 0;
            for (int v = 0; v < 5; v++)
            {
                sum += masyvas[v];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            decimal[] sk_mas = new decimal[5];

            sk_mas[0] = 3.645m;
            sk_mas[1] = 6.2662m;
            sk_mas[2] = 4.2145m;
            sk_mas[3] = 7.532m;
            sk_mas[4] = 9.255m;
            decimal rez = Math.Round(skaiciu_masyvas(sk_mas),2);
            Console.WriteLine("Masyvo elementu suma {0}", rez);
            Console.ReadLine();
        }
    }
}

