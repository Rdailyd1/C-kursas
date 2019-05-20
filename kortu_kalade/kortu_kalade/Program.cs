using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kortu_kalade
{
    class Program
    {
        public static int korta_taskai(int kt)
        {
            string[] kalade = { "9", "10", "J", "Q", "K", "A" };
            int taskai = 0;
            switch (kt)
            {
                case 0:
                    taskai = 9;
                    break;
                case 1:
                    taskai = 10;
                    break;
                case 2:
                    taskai = 4;
                    break;
                case 3:
                    taskai = 5;
                    break;
                case 4:
                    taskai = 6;
                    break;
                case 5:
                    taskai = 11;
                    break;
            }
            return taskai;
        }
        static void Main(string[] args)
        {
            string[] kalade = { "9", "10", "J", "Q", "K", "A" };
            Random ats = new Random();
            int kortos_taskai = 0;
            int i = 0;
            while (i < 21)
            {
                int korta = ats.Next(5);
                Console.WriteLine("Kompiuterio ismesta korta");
                Console.WriteLine(kalade[korta]);
                kortos_taskai += korta_taskai(korta);
                if (kortos_taskai <= 21)
                   {
                    Console.WriteLine("Kortu verte {0}", kortos_taskai);
                    Console.WriteLine("Ar prasote dar vienos kortos?");
                    Console.ReadKey();
                   }
                else
                   {
                    Console.WriteLine("Pralaimejote. Jusu kortu verte {0}", kortos_taskai);
                    Console.ReadKey();
                   }
                i++;
            }
        }
    }
}

