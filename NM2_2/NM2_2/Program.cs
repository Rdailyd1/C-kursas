using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apskritimas
{
    class apskritimas
    {

        static void Main(string[] args)
        {
            int spindulys = 0;
            decimal ilgis = 0;
            decimal plotas = 0;
            Console.WriteLine("Įveskite apskritimo spindulį:");
            spindulys = Convert.ToInt16(Console.ReadLine());
            ilgis = Convert.ToDecimal(Math.PI * 2 * spindulys);
            plotas = Convert.ToDecimal(Math.PI * spindulys * spindulys);
            Console.WriteLine("Apskritimo ilgis {0}", ilgis);
            Console.WriteLine("Skritulio plotas {0}", plotas);
            Console.ReadLine();
        }
    }
}
