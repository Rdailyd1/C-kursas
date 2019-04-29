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
            bool sulyginimas = true;

            Console.WriteLine("Įveskite skaičių A:");
            skaicius1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Įveskite skaičių B:");
            skaicius2 = Convert.ToInt16(Console.ReadLine());
            if (skaicius1 == skaicius2)
                Console.WriteLine("True");
            else Console.WriteLine("False");

            Console.ReadLine();
        }
    }
}
