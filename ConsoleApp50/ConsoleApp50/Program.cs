using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacio_skaicius
{
    class Program
    {
        public static int fibonatis(int skaicius)
        {
            int a = 0;
            int b = 1;
            Console.Write(a + " ");
            Console.Write(b + " ");
            for (int i = 0; i < skaicius; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
                Console.Write(b + " ");
            }

            return skaicius;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");

            int skaicius = Convert.ToInt32(Console.ReadLine());

            fibonatis(skaicius);

            Console.ReadKey();
        }
    }
}

