using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NM6_8
{
    class Program
    {
        public static int atvirkstinis(string skaicius)
        {
            string rez;
            int gr = 0;
            char[] charArray = skaicius.ToCharArray();
            Array.Reverse(charArray);
            rez = new string(charArray);
            gr = Int32.Parse(rez);
            return gr;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int skaicius = int.Parse(Console.ReadLine());
            Console.WriteLine("Atvirkstinis {0}", atvirkstinis(skaicius.ToString()));
            Console.ReadKey();
        }
    }
}
