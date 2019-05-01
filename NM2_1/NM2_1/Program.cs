using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace didziosios_raides
{
    class raides
    {

        static void Main(string[] args)
        {
            string vardas = "";
            string pavarde = "";

            Console.WriteLine("Įveskite vardą:");
            vardas = Console.ReadLine();
            Console.WriteLine("Įveskite pavardę:");
            pavarde = Console.ReadLine();
            string didziosios = (vardas + "_" + pavarde).ToUpper();
            Console.WriteLine("Vardas pavardė {0}", didziosios);
            Console.ReadLine();
        }
    }
}
