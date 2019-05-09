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
            int be_liekanos = 0;
            Console.WriteLine("Be liekanos yra sie skaiciai: ");
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    be_liekanos = i;
                    Console.WriteLine(be_liekanos);
                }
            }
            Console.ReadLine();
        }
    }
}
