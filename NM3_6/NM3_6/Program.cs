using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class trikampis
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite skaičių 1:");
            int skaicius1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Įveskite skaičių 2:");
            int skaicius2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Įveskite skaičių 3:");
            int skaicius3 = Convert.ToInt16(Console.ReadLine());
            int suma = skaicius1 + skaicius2 + skaicius3;
            if (suma == 180)
            {
                Console.WriteLine("Gali buti sudarytas trikampis");
            }
            else
            {
                Console.WriteLine("Negali buti sudarytas trikampis, nes kampu suma nelygi 180");
            }
            Console.ReadLine();
        }
    }
}
