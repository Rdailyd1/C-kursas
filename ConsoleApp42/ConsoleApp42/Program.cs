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
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int sk = int.Parse(Console.ReadLine());
            for (int i = 0; i < sk; i++)
            {
                Thread.Sleep(50); // milisekundes
                Console.Write("#");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
