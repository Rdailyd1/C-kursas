using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindromas
{
    class Program
    {
        public static string palindromas(string tekstas)
        {
            char[] charArray = tekstas.ToCharArray();
            Array.Reverse(charArray);
            string atvirkstinis = new string(charArray);
            if (tekstas == atvirkstinis)
            {
                Console.WriteLine(atvirkstinis);
                Console.WriteLine("Tai yra palindromas");
            }
            else
            {
                Console.WriteLine("Tai nera palindromas");
            }
            return atvirkstinis;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite teksta");

            string tekstas = Console.ReadLine();

            palindromas(tekstas);

            Console.ReadKey();
        }
    }
}
