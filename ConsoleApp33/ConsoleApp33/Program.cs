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
            string simbolis = "";

            Console.WriteLine("Įveskite simboli :");
           simbolis = Console.ReadLine();
            Console.WriteLine("{0} ", simbolis);
            Console.WriteLine("{0} {0} ", simbolis, simbolis);
            Console.WriteLine("{0} {0} {0}", simbolis, simbolis, simbolis);
           
            Console.ReadLine();
        }
    }
}
