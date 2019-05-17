using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarpai_eiluteje
{
    class Program
    {
        public static int tarpai(string tekstas)
        {
            int tarpu_sk = 0;
            char[] t_masyvas = tekstas.ToCharArray();
            for (int i = 0; i < tekstas.Length; i++)
            {
                if (t_masyvas[i] == Convert.ToChar(" "))
                {
                    tarpu_sk++;
                }
            }
            return tarpu_sk;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite teksto eilute");
            string tekstas = Console.ReadLine();
            int ts = tarpai(tekstas);
            Console.WriteLine("Tekstas turi {0}", ts + " tarpa(-us)");
            Console.ReadKey();
        }
    }
}

