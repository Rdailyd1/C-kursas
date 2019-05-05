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

            Console.WriteLine("Iveskite figuros numeri");
            Console.WriteLine("[1] - apskritimas, [2] - staciakampis, [3] - status trikampis");
            int veiksmas = int.Parse(Console.ReadLine());
            switch (veiksmas)
            {
                case 1:
                    Console.WriteLine("Iveskite spinduli: ");
                    int spind = Convert.ToInt16(Console.ReadLine());
                    double skrit_plotas = Math.PI*spind*spind;
                    Console.WriteLine("Skritulio plotas: {0}", skrit_plotas);
                    break;
                case 2:
                    Console.WriteLine("Iveskite krastine A: ");
                    int A_krastine = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Iveskite krastine B: ");
                    int B_krastine = Convert.ToInt16(Console.ReadLine());
                    int stac_plotas =A_krastine * B_krastine;
                    Console.WriteLine("Staciakampio plotas: {0}", stac_plotas);
                    break;
                case 3:
                    Console.WriteLine("Iveskite trikampio aukstine h: ");
                    int aukstine = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Iveskite trikampio krastine a: ");
                    int krastine = Convert.ToInt16(Console.ReadLine());
                    int trik_plotas = aukstine * krastine / 2;
                    Console.WriteLine("Trikampio plotas: {0}", trik_plotas);
                    break;
                default:
                    Console.WriteLine("Nezinomas veiksmas. Paspauskite [ENTER] kad uzdaryti langa.");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
            }
            Console.ReadLine();
        }
    }
}
