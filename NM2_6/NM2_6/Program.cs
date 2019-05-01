using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NM2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int skaicius = 0;
            int pirmas = 0;
            int antras = 0;
            int suma = 0;
            Console.WriteLine("Įveskite 2 ženklų skaičių:");
            skaicius = Convert.ToInt32(Console.ReadLine());
            pirmas = skaicius / 10;
            antras = skaicius % 10;
            suma = pirmas + antras;
            Console.WriteLine("Skaiciu suma: {0}", suma);
            Console.ReadLine();
        }
    }
}
