using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NM6_5
{
    class Program
    {
        public static void remelis(string tekstas, string simb)
        {
            int simb_sk = tekstas.Length+4;
            char[] t_masyvas = tekstas.ToCharArray();
            for (int v = 0; v < simb_sk; v++)
            {
                Console.Write(simb);
            }
            Console.WriteLine();
            Console.WriteLine(simb + " " + tekstas + " " + simb);
            for (int a = 0; a < simb_sk; a++)
            {
                Console.Write(simb);
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite teksto eilute");
            string tekstas = Console.ReadLine();
            Console.WriteLine("Iveskite simboli");
            string simbolis = Console.ReadLine();
            remelis(tekstas, simbolis);
        }
    }
}