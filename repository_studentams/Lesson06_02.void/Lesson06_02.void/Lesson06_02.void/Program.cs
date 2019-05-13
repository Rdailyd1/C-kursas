using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06_02.@void
{
    class Program
    {
        static void Main(string[] args)
        {
            SkaiciusLangeluje(1);
            SkaiciusLangeluje(12);
            SkaiciusLangeluje(1123456);

            Console.ReadLine();
        }

        private static void SkaiciusLangeluje(int skaicius)
        {
            int remosimboliukiekis = 25;
            string remoSimbolis = "*";
            string tarposimbolis = " ";

            // nupiesiame virsutine eilute            
            PiestiEilute(remosimboliukiekis, remoSimbolis);

            // nupiesiame vidurine eilute
            Console.Write("{0}{1}{2}", remoSimbolis, tarposimbolis, skaicius);
            int skaiciausIlgis = skaicius.ToString().Length;
            int kiekTarpuPraleisti = remoSimbolis.Length * 2 + skaiciausIlgis + tarposimbolis.Length;
            for (int i = kiekTarpuPraleisti; i < remosimboliukiekis; i++)
            {
                Console.Write(tarposimbolis);
            }
            Console.Write(remoSimbolis);

            // nupiesiame apatine eilute
            Console.WriteLine();
            PiestiEilute(remosimboliukiekis, remoSimbolis);
        }
        private static void PiestiEilute(int kiekRemelioSimboliuNupiesti, string remoSimbolis)
        {
        for (int i = 0; i < kiekRemelioSimboliuNupiesti; i++)
            {
                Console.Write(remoSimbolis);
            }
             Console.WriteLine();
          }
    }
}
