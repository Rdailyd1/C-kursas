using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace NM4_5
{
    class Program
    {
        protected static int origRow;
        static void Main(string[] args)
        {
         
            for (int a = 4; a >= 1; a--)
            {
                for (int i = a; i <= 4; i++)
                {
                    
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
