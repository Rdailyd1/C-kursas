using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vardas_pavarde
{
    class Program
    {
        public static string sujungimas(string vardas, string pavarde)
        {
            string rez = vardas + ", " + pavarde;
            return rez;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite varda");
            string vardas = Console.ReadLine();
            Console.WriteLine("Iveskite pavarde");
            string pavarde = Console.ReadLine();
            string sujungta = sujungimas(vardas, pavarde);
            Console.WriteLine(sujungta);
            Console.ReadKey();
        }
    }
}


