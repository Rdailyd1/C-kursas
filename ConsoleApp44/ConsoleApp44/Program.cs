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
            int[] masyvas1 = new int[10];
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

            int[] masyvas2 = new int[10];
            Random rnd2 = new Random();
            for (int i = 0; i < masyvas2.Length; i++)
            {
                masyvas2[i] = rnd2.Next(1, 100);
            }
            Console.WriteLine();
            foreach (var skaicius2 in masyvas2)
            {
                Console.Write("{0}, ", skaicius2);
            }
            Console.WriteLine();
            Console.WriteLine("Jungtinis Masyvas:");
            int[] jungtinis = new int[20];
            for (int i = 0; i < masyvas1.Length; i++)
            {
               jungtinis[i] = masyvas1[i];
            }
            int a = 0;
            for (int j = 10; j < masyvas2.Length+10; j++)
            {
                jungtinis[j] = masyvas2[a];
                a++;
            }
            for (int i = 0; i < jungtinis.Length; i++)
            {
                for (int j = 0; j < jungtinis.Length; j++)
                {
                    if (jungtinis[i] < jungtinis[j])
                    {
                        var k = jungtinis[i];
                        jungtinis[i] = jungtinis[j];
                        jungtinis[j] = k;

                    }
                }
            }

            foreach (var skaicius in jungtinis)
            {
                Console.Write("{0}, ", skaicius);
            }
            Console.ReadLine();
        }
    }
}
