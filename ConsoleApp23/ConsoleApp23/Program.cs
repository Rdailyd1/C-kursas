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
            int skaicius = 0;

            Console.WriteLine("Įveskite skaiciu:");
            skaicius = Convert.ToInt16(Console.ReadLine());
            if (skaicius < 0)
                Console.WriteLine("True");
            else Console.WriteLine("False");
            Console.ReadLine();
        }
    }
}

