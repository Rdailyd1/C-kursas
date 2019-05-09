using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp44
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] masyvas1 = new int[5];
            int suma = 0;
            Random rnd1 = new Random();
            for (int i = 0; i < masyvas1.Length; i++)
            {
                masyvas1[i] = rnd1.Next(1, 100);
                suma += masyvas1[i];
                Console.Write("{0} ", masyvas1[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Suma: {0}", suma);
            Console.ReadLine();
        }
    }
}
