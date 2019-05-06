using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite eiluciu skaiciu");
            int sk = int.Parse(Console.ReadLine());
            int k = sk;
            for (int x = sk; x > 0;  x--)
            {

                k--;
                for (int z = 1; z <=k; z++ )
                {
                    Console.Write(" ");
                }
                for (int y = 0; y < sk - k; y++)
                {
                    
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}