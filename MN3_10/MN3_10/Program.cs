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
            decimal mokestis = 0;
            Console.WriteLine("Iveskite pajamas");
            int pajamos;
            if (int.TryParse(Console.ReadLine(), out pajamos))
            {

                if (pajamos > 100000)
                {
                    mokestis = (decimal)pajamos * 35 / 100;
                }
                else if (pajamos > 75000)
                {
                    mokestis = (decimal)pajamos * 20 / 100;
                }
                else if (pajamos >= 40000)
                {
                    mokestis = (decimal)pajamos * 15 / 100;
                }
                if (mokestis == 0)
                {
                    Console.WriteLine("Jums nereikia moketi mokesciu");
                }
                else
                {
                    Console.WriteLine("Mokestis: {0}", mokestis);
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Ivestas blogas skaicius");
                Console.ReadLine();
            }
        }
    }
}
