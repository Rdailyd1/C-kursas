using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NM2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int pirmas = 0;
            int antras = 0;
            int suma = 0;
            Console.WriteLine("Įveskite pirmą skaičių:");
            pirmas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite antrą skaičių:");
            antras = Convert.ToInt32(Console.ReadLine());
            pirmas = pirmas + antras; // 5 + 6 = 11
            antras = pirmas - antras; // 11 - 6 = 5
            pirmas = pirmas - antras; // 11 - 5 = 6
            
            Console.WriteLine("Pirmas skaicius: {0}", pirmas);
            Console.WriteLine("Antras skaicius: {0}", antras);
            Console.ReadLine();
        }
    }
}
