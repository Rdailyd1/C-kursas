using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NM6_p1
{
    class Program
    {
        public static char cezario_sifras(char pradinis, int key)
        {
            if (!char.IsLetter(pradinis))
            {
                return pradinis;
            }
            char d = char.IsUpper(pradinis) ? 'A' : 'a';
            return (char)((((pradinis + key) - d) % 26) + d);
        }
        public static string uzsifruotas(string input, int key)
        {
            string output = string.Empty;
            foreach (char ch in input)
                output += cezario_sifras(ch, key);
            return output;
        }
        public static string issifruotas(string input, int key)
        {
            return uzsifruotas(input, 26 - key);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite teksta:");
            string tekstas = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Iveskite sifro rakta");
            int raktas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Uzsifruotas tekstas");
            string uzsifruotas = Program.uzsifruotas(tekstas, raktas);
            Console.WriteLine(uzsifruotas);
            Console.Write("\n");
            Console.WriteLine("Issifruotas tekstas:");
            string issifr = issifruotas(uzsifruotas, raktas);
            Console.WriteLine(issifr);
            Console.Write("\n");
            Console.ReadKey();
        }
    }
}
