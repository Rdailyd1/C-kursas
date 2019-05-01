using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace darbuotojo_alga
{
    class alga
    {

        static void Main(string[] args)
        {
            string darb_id = "";
            int isd_valandos = 0;
            int valandinis_ikainis = 0;
            int uzdirbta_alga = 0;

            Console.WriteLine("Įveskite darbuotojo ID:");
            darb_id = Console.ReadLine();
            Console.WriteLine("Įveskite išdirbtas valandas:");
            isd_valandos = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Įveskite valandinį įkainį:");
            valandinis_ikainis = Convert.ToInt16(Console.ReadLine());
            uzdirbta_alga = valandinis_ikainis * isd_valandos;
            Console.WriteLine("Darbuotojo ID {0}", darb_id);
            Console.WriteLine("Darbuotojo alga {0}",uzdirbta_alga);
            Console.ReadLine();
        }
    }
}
