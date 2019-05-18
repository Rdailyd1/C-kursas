using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp56
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int skaicius = rnd.Next(10);
            int vat_sk = 0;
            int s = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Iveskite savo skaiciu");
                vat_sk = int.Parse(Console.ReadLine());
                if (vat_sk > skaicius)
                {
                    Console.WriteLine("Maziau");
                }
                else if (vat_sk < skaicius)
                {
                    Console.WriteLine("Daugiau");
                }
                 else 
                {
                    Console.WriteLine("Atspejote");
                    s = 1;
                    break; 
                }
            }
            if (s == 0)
            {
                Console.WriteLine("Neatspejote");
            }
            Console.ReadKey();
        }
    }
}
