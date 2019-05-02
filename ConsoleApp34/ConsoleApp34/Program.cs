using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class staciakampis
    {

        static void Main(string[] args)
        {
            string tikras_vardas = "Rolandas";
            string tikras_slapt = "45rd";
            string vardas = "";
            string slaptazodis = "";
           
           
            for (int index = 0; index < 3; index++)
            {
                Console.WriteLine("Įveskite varda :");
                vardas = Console.ReadLine();
                Console.WriteLine("Įveskite slaptazodi :");
                slaptazodis = Console.ReadLine();
                if (vardas == tikras_vardas && slaptazodis == tikras_slapt)
                {
                    Console.WriteLine("Teisingai");
                    break;
                }
                else
                {
                 
                    if (index == 2)
                    {
                        Console.WriteLine("Suklydote 3 kartus");
                        break;
                    }
                    else {
                        Console.WriteLine("Neteisingai, bandykite dar karta");
                    }

                }
            }
           

            Console.ReadLine();
        }
    }
}
