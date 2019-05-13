using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindromas
{
    class Program
    {
        public static int fibonatis(int skaicius)
        {
            int ankstesnis = 0;
            int sum = 0;
            for (int i = 1; i <= skaicius; i++)
            {
                ankstesnis = i-1;
                sum += ankstesnis;
                Console.Write(sum + " ");
            }
            return skaicius;
        }
            static void Main(string[] args)
            {
                Console.WriteLine("Iveskite skaiciu");

                int skaicius = Convert.ToInt32(Console.ReadLine());

                fibonatis(skaicius);

                Console.ReadKey();
            }
        }
    }

