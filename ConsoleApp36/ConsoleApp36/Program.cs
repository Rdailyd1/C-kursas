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
            double skaicius = 22878778787878;
            int konv_sk = (int)skaicius;
            short sh_sk =(short)(skaicius);
            byte b_sk = (byte)(skaicius);

            Console.WriteLine("Int: {0}",konv_sk);
            Console.WriteLine("Short: {0}", sh_sk);
            Console.WriteLine("Byte: {0}", b_sk);

            Console.ReadLine();
        }
    }
}
