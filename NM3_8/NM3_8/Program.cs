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

            Console.WriteLine("Iveskite skaiciu nuo 1 iki 7");
            int diena = Convert.ToByte(Console.ReadLine());
            switch (diena)
            {
                case 1:
                    Console.WriteLine("Pirmadienis");
                    break;
                case 2:
                    Console.WriteLine("Antradienis");
                    break;
                case 3:
                    Console.WriteLine("Treciadienis");
                    break;
                case 4:
                    Console.WriteLine("Ketvirtadienis");
                    break;
                case 5:
                    Console.WriteLine("Penktadienis");
                    break;
                case 6:
                    Console.WriteLine("Sestadienis");
                    break;
                case 7:
                    Console.WriteLine("Sekmadienis");
                    break;
            }
            Console.ReadLine();
        }
    }
}
