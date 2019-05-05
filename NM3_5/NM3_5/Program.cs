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
          
            bool sulyginimas = true;

            Console.WriteLine("Įveskite skaičių 1:");
            int skaicius1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Įveskite skaičių 2:");
            int skaicius2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Įveskite skaičių 3:");
            int skaicius3 = Convert.ToInt16(Console.ReadLine());
            if (skaicius1 > skaicius2 && skaicius1 > skaicius3)
            {
                Console.WriteLine("Didziausias skaicius: {0}", skaicius1);
            }
            else if (skaicius2 > skaicius1 && skaicius2 > skaicius3)
            {
                Console.WriteLine("Didziausias skaicius: {0}", skaicius2);
            }
            else if (skaicius3 > skaicius1 && skaicius3 > skaicius2)
            {
                Console.WriteLine("Didziausias skaicius: {0}", skaicius3);
            }
            else if (skaicius1 == skaicius2 || skaicius1 == skaicius3 || skaicius2 == skaicius3)
            {
                Console.WriteLine("Yra vienodų skaičių");
            }
            Console.ReadLine();
        }
    }
}
