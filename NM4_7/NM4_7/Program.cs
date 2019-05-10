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
            Console.WriteLine("Įveskite 5 skaičius");
            for (int i = 0; i < masyvas1.Length; i++)
            {
                masyvas1[i] = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("Pirmas masyvas");
            foreach (var skaicius in masyvas1)
            {
                Console.Write("{0}, ", skaicius);
            }
            Console.WriteLine();

            int[] masyvas2 = new int[5];
            Console.WriteLine("Antras masyvas");
            for (int i = 0; i < masyvas2.Length; i++)
            {
                masyvas2[i] = masyvas1[i];
            }
            
            foreach (var skaicius2 in masyvas2)
            {
                Console.Write("{0}, ", skaicius2);
            }
           
            Console.ReadLine();
        }
    }
}
