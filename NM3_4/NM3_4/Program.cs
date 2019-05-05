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
            Console.Write("Iveskite skaiciu 1:");
            double sk1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Iveskite skaiciu 2:");
            double sk2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Iveskite operacijos simboli:");
            double rez = 0;
            string opr = Console.ReadLine();
            switch (opr)
            {
                case "+":
                    rez = sk1 + sk2;
                    Console.WriteLine("Suma: {0}", rez);
                    break;
                case "-":
                    rez = sk1 - sk2;
                    Console.WriteLine("Skirtumas: {0}", rez);
                    break;
                case "*":
                    rez = sk1 * sk2;
                    Console.WriteLine("Sandauga: {0}", rez);
                    break;
                case "/":
                    rez = sk1 / sk2;
                    Console.WriteLine("Dalyba: {0}", rez);
                    break;
            }

             Console.ReadLine();
        }
    }
}
