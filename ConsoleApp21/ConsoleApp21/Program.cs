using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class trys_skaiciai
    {

        static void Main(string[] args)
        {
            int ilgis = 0;
            int plotis = 0;
            int plotas;

            Console.WriteLine("Įveskite ilgi:");
            ilgis = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Įveskite ploti:");
           plotis = Convert.ToInt16(Console.ReadLine());
            plotas = ilgis * plotis;
            Console.WriteLine("Plotas {0}", plotas);
           
            Console.ReadLine();
        }
    }
}
