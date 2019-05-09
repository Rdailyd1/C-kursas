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
            int suma = 0;
            for (int i = 10; i <= 20; i++)
            {
                suma += i;
            }
            Console.WriteLine("Skaiciu nuo 10 ik 20 suma= {0}", suma);
            Console.ReadLine();
        }
    }
}
