using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class staciakampis
    {

        static void Main(string[] args)
        {
            string skaicius = "";
           
            Console.WriteLine("Įveskite skaičių :");
            skaicius = Console.ReadLine();
            Console.WriteLine("{0} {1} {2}", skaicius, skaicius, skaicius);
            Console.WriteLine("{0} {1} {2}", skaicius, " ", skaicius);
            Console.WriteLine("{0} {1} {2}", skaicius, " ", skaicius);
            Console.WriteLine("{0} {1} {2}", skaicius, " ", skaicius);
            Console.WriteLine("{0} {1} {2}", skaicius, skaicius, skaicius);

            Console.ReadLine();
        }
    }
}
