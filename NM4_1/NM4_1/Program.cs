using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp42
{
    class Program
    {
        protected static int origRow;
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite savo varda: ");
            string vardas = Console.ReadLine();
            for (int i = 1; i <= 10; i++)
            {              
                Console.WriteLine(vardas); 
            }
            Console.ReadLine();
        }
    }
}
