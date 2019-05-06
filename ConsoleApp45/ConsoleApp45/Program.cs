using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp44
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] masyvas = new int[50];
            Random rnd = new Random();
            for (int i = 0; i < masyvas.Length; i++)
            {
                masyvas[i] = rnd.Next(1, 100);
            }
            int kartojasi = 0;
            for (int i = 0; i < masyvas.Length; i++)
            {
                foreach (var sk in masyvas)
                {
                    if (sk == masyvas[i])
                    {
                        kartojasi++;
                    }
                }
                Console.WriteLine("Elementas {0}, kartojasi  {1}", i, kartojasi);
                kartojasi = 0;
            }

            Console.ReadLine();
        }
    }
}
