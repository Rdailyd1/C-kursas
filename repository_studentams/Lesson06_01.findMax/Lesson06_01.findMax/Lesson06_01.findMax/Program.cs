using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06_01.findMax
{
    class Program
    {
        private static int FindMax(int skaicius1, int skaicius2)
            {
            if (skaicius1 > skaicius2)
            {
                return skaicius1;
            }
            else
            {
                return skaicius2;
            }
            }
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int max;
            max = FindMax(a, b);
            max = FindMax(max, c);
            Console.WriteLine(max);

            Console.ReadLine();
        }
    }
}
