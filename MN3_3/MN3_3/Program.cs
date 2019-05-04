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
            Console.Write("Iveskite skaiciu:");
            sk1 = Convert.ToDouble(Console.ReadLine());
            if (sk1 % 2 == 0)
            {
                Console.Write("Skaicius lyginis");
            }
            else
            {
                Console.Write("Skaicius nelyginis");
            }
            if (sk1 > 0)
            {
                Console.Write(", teigiamas");
                Console.ReadLine();
            }
            else
            {
                Console.Write(", neigiamas");
                Console.ReadLine();
            }
        }
    }
}
