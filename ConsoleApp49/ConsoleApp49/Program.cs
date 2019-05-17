using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skaitmenu_suma
{
    class Program
    {
        public static int skaitmenys(int skaicius)
        {
            
           string skait = skaicius.ToString();
               foreach (string sk in skait)
            {

            }
               
            return skaicius;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");

            int skaicius = Convert.ToInt32(Console.ReadLine());

            skaitmenys(skaicius);

            Console.ReadKey();
        }
    }
}

