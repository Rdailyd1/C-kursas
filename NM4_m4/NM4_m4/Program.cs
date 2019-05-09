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
            string vardas = "pavadinimas";
           
            for (int i = 0; i < vardas.Length; i++)
            {
                char current = vardas[i];
                System.Console.Write(current);
            }
            Console.WriteLine();
            for (int i = vardas.Length-1; i >= 0; i--)
            {
                char current = vardas[i];
                System.Console.Write(current);
            }
            Console.ReadLine();
        }
    }
}
