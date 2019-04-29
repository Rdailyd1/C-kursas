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
            string tekstas = "";

            Console.WriteLine("Įveskite tekstą:");
            tekstas = Console.ReadLine();
            if (tekstas != "")
                Console.WriteLine("True");
            else Console.WriteLine("False");
            Console.ReadLine();
        }
    }
}
