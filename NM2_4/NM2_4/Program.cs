using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sekundes
{
    class sekundes
    {

        static void Main(string[] args)
        {
            int skaicius;
            Console.WriteLine("Įveskite skaičių (sekundes):");
            skaicius = Convert.ToInt32(Console.ReadLine());
            TimeSpan laikas = TimeSpan.FromSeconds(skaicius);
            DateTime dateTime = DateTime.Today.Add(laikas);
            string val_min_sek = dateTime.ToString("hh:mm:ss");
            Console.WriteLine("Valandos: minutes: sekundes - {0}", val_min_sek);
            Console.ReadLine();
        }
    }
}
