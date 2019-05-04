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

            Console.WriteLine("Iveskite egzamino pazymi");
           
            int pazymys = int.Parse(Console.ReadLine());
            int pzm;
            if (pazymys <= 4)
            {
                pzm = 0;
            }
            else
            {
                pzm = pazymys;
            }
            switch (pzm)
            {
                case 0 :
                    Console.WriteLine("NEPATENKINAMAI");
                    break;
                case 5:
                    Console.WriteLine("SILPNAI");
                    break;
                case 6:
                    Console.WriteLine("PATENKINAMAI");
                    break;
                case 7:
                    Console.WriteLine("VIDUTINISKAI");
                    break;
                case 8:
                    Console.WriteLine("GERAI");
                    break;
                case 9:
                    Console.WriteLine("LABAI GERAI");
                    break;
                case 10:
                    Console.WriteLine("PUIKIAI");
                    break;
            }
            Console.WriteLine("Paspauskite [ENTER] kad uzdarytumet langa.");
            Console.ReadLine();
        }
    }
}
