using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {

        static void Main(string[] args)
        {
           double sk1;
           double sk2;

            Console.WriteLine("Iveskite pirma skaiciu:");
            sk1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu:");
            sk2 = Convert.ToDouble(Console.ReadLine());
            if (sk1 == sk2)
            {
                Console.WriteLine("Skaiciai vienodi");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Skaiciai skiriasi");
                Console.ReadLine();
            }
        }
    }
}
