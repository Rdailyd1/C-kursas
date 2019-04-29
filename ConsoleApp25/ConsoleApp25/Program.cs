using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class adresas
    {

        static void Main(string[] args)
        {
            string miestas = "";
            string gatve = "";
            int namo_nr = 0;
            DateTime pastatymo_metai;
            int metai;

            Console.WriteLine("Įveskite miesto pavadinima:");
            miestas= Console.ReadLine();
            Console.WriteLine("Įveskite gatves pavadinima:");
            gatve = Console.ReadLine();
            Console.WriteLine("Įveskite namo Nr.");
            namo_nr = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Įveskite namo pastatymo metus:");
            pastatymo_metai = Convert.ToDateTime(Console.ReadLine());
            metai = (pastatymo_metai).Year;

            Console.WriteLine("Miestas {0}", miestas);
            Console.WriteLine("Gatve {0}",gatve);
            Console.WriteLine("Namo Nr. {0}", namo_nr);
            Console.WriteLine("Pastatymo metai {0}", metai);
            Console.ReadLine();
        }
    }
}
