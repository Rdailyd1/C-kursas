using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class mokesciai
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite sunaudoto vandens kieki, kub.m.:");
            int skaicius1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Įveskite sunaudotos elektros energijos kieki, kWh:");
            int skaicius2 = Convert.ToInt16(Console.ReadLine());
            decimal vanduo = Convert.ToDecimal(skaicius1 * 1.16);
            decimal elektra = Convert.ToDecimal(skaicius2 * 0.04);
            Console.WriteLine("Uz sunaudota vandeni turite moketi {0} {1}", vanduo, " eur");
            Console.WriteLine("Uz sunaudota elektros energija turite moketi {0} {1}", elektra, " eur");
            Console.ReadLine();
        }
    }
}
