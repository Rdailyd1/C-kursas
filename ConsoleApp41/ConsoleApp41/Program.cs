using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NM3_s2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool res;
            Console.WriteLine("Iveskite isdirbtas valandas:");
            string valandos = Console.ReadLine();
            res = Int32.TryParse(valandos, out int val);
            if (res)
            {
                int vl = Convert.ToInt16(valandos);
                int skirtumas = 0;
                if (vl < 160)
                {
                    skirtumas = 160 - vl;
                    Console.WriteLine("Dar reikia isdirbti: {0}", skirtumas);
                }
                else if (vl == 160)
                {
                    Console.WriteLine("Isdirbtas pilnas etatas");
                }
                else if (vl > 160)
                {
                    skirtumas = vl - 160;
                    Console.WriteLine("Virsvalandziu: {0}", skirtumas);
                }
            }
            else
            {
                Console.WriteLine("Ivesta klaidinga reiksme");
            }
                Console.ReadLine();
            
        }
    }
}
