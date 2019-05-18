using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NM6_9
{
    class Program
    {
        public static string atsitiktines_raides(string simboliai)
        {
            string atsit_simb="";
            char[] simb_eilute = simboliai.ToCharArray();
            int el_nr = 0;
            var random = new Random();
            for (int i=0;i<10;i++)
            {
                el_nr = random.Next(simb_eilute.Length);
                atsit_simb += simb_eilute[el_nr].ToString();
            }
            return atsit_simb;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite raidziu/skaiciu eilute");
            string simboliai = Console.ReadLine();
            string rezultatas = atsitiktines_raides(simboliai);
            Console.WriteLine("10 atsitiktiniu raidziu: {0}", rezultatas);
            Console.ReadLine();
        }
    }
}
