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
            Console.WriteLine("Iveskite skaiciu");
            int sk = Convert.ToInt16(Console.ReadLine());
            decimal proc = 0;
            for (int i = 1; i <= sk; i++)
            {
                origRow = Console.CursorTop;
                Console.SetCursorPosition(1, 2);
                proc = (decimal)i / sk * 100;
                Thread.Sleep(50);
                Console.Write(Convert.ToString(Convert.ToInt16(proc)) + "%");
                Thread.Sleep(50); // milisekundes
                Console.SetCursorPosition(i, 3);
                Console.Write("#");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
