using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp44
{
    class Program
    {
        static void Main(string[] args)
        {
            string vardas = "Rolandas";

            for (int i = 0; i < vardas.Length; i++)
            {
                char current = vardas[i];
                System.Console.Write(current);
            }
            Console.WriteLine();
            Console.WriteLine("Vardas atvirkstine tvarka: ");
            for (int i = vardas.Length - 1; i >= 0; i--)
            {
                char current = vardas[i];
                System.Console.Write(current);
            }
            Console.ReadLine();
        }
    }
}
