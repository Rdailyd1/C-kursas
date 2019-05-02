using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class konvertavimas
    {

        static void Main(string[] args)
        {
            double skaicius = 26;
            int konv_sk = Convert.ToInt32(skaicius);
            short sh_sk = Convert.ToInt16(skaicius);
            byte b_sk = Convert.ToByte(skaicius);

            Console.WriteLine("Int: {0}",konv_sk);
            Console.WriteLine("Short: {0}", sh_sk);
            Console.WriteLine("Bytet: {0}", b_sk);

            Console.ReadLine();
        }
    }
}
