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
            string[] masyvas1 = new string[10];
            Console.WriteLine("Įveskite 10 vardu");
            for (int i = 0; i < masyvas1.Length; i++)
            {
                masyvas1[i] = Console.ReadLine();
            }
            Console.WriteLine("Pirmas masyvas");
            foreach (var vardas in masyvas1)
            {
                Console.Write("{0}, ", vardas);
            }
            Console.WriteLine();

            string[] masyvas2 = new string[8];
            int a = 0;

            Console.WriteLine("Antras masyvas");
            for (int i = 0; i < masyvas2.Length; i++)
            {

                if (i != 4 && i != 6)
                {
                    masyvas2[a] = masyvas1[i];
                    a++;
                }
                
                
            }

            foreach (var skaicius2 in masyvas2)
            {
                Console.Write("{0}, ", skaicius2);
            }
            Console.ReadLine();
        }
    }
}
