using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class trys_skaiciai
    {

        static void Main(string[] args)
        {
            int skaicius1 = 0;
            int skaicius2 = 0;
            int tarpinis = 0;

            Console.WriteLine("Įveskite skaičių A:");
            skaicius1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Įveskite skaičių B:");
            skaicius2 = Convert.ToInt16(Console.ReadLine());

            tarpinis = skaicius1;
            skaicius1 = skaicius2;
            skaicius2 = tarpinis;
            Console.WriteLine("Skaicius A = {0}", skaicius1);
            Console.WriteLine("Skaicius B = {0}", skaicius2);

            Console.ReadLine();
        }
    }
}
