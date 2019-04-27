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
            string spalva = "1";
            while (spalva != "2")
            {
                Console.WriteLine("Kokia jūsų mėgstama spalva:");
                spalva = Console.ReadLine();
                Console.WriteLine("Mano irgi");

            }
            Console.Clear();
            //Console.WriteLine("Mano irgi");
            Console.ReadLine();
        }
    }
}
