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
            int skaicius3 = 0;

            Console.WriteLine("Įveskite skaičių A:");
            skaicius1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Įveskite skaičių B:");
            skaicius2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Įveskite skaičių C:");
            skaicius3 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("("+skaicius1 + "+"+skaicius2+")"+"*"+skaicius3+"="+(skaicius1+skaicius2)*skaicius3);
            Console.WriteLine(skaicius1 + "*" + skaicius3 + "+" + skaicius2 + "*"+skaicius3 + "=" + ((skaicius1 * skaicius3) + (skaicius2*skaicius3)));

            Console.ReadLine();
        }
    }
}
