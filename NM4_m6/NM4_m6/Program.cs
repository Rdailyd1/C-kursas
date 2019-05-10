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
            int[] masyvas1 = new int[100];
            Random rnd1 = new Random();
            for (int i = 0; i < masyvas1.Length; i++)
            {
                masyvas1[i] = rnd1.Next(1, 100);
            }

            foreach (var skaicius in masyvas1)
            {
                Console.Write("{0}, ", skaicius);
            }
            Console.WriteLine();
            int maxvalue = masyvas1.Max();
            int minvalue = masyvas1.Min();
            int maxIndex = masyvas1.ToList().IndexOf(maxvalue);
            int minIndex = masyvas1.ToList().IndexOf(minvalue);
            Console.WriteLine("Masyvo didziausia reiksme: {0}:", maxvalue);
            Console.WriteLine("Masyvo didziausios reiksmes indeksas: {0}:", maxIndex);
            Console.WriteLine("Masyvo maziausia reiksme: {0}:", minvalue);
            Console.WriteLine("Masyvo maziausios reiksmes indeksas: {0}:", minIndex);
            Console.ReadLine();
        }
    }
}
