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
            
            Console.WriteLine("Iveskite grupes pavadinima:");
            string grupesPavadinimas = Console.ReadLine();

            Console.WriteLine("Iveskite grupes nariu skaiciu:");
            int nariuSkaicius;// = int.Parse(Console.ReadLine());
            if (!int.TryParse(Console.ReadLine(), out nariuSkaicius))
            {
                Console.WriteLine("Ivestas blogas skaicius");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine("Grupes pavadinimas yra: {0}, nariu skaicius yra {1}", grupesPavadinimas, nariuSkaicius);
            Console.ReadLine();
        }
    }
}
