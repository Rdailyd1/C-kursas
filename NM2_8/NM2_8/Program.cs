using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NM2_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int kord_x = 0;
            int kord_y = 0;
            int kord_x1 = 0;
            int kord_y1 = 0;
            int kord_m = 0;
            int kord_n = 0;
            
            Console.WriteLine("Įveskite koordinate X:");
            kord_x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite koordinate Y:");
            kord_y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite koordinate X1:");
            kord_x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite koordinate Y1:");
            kord_y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite koordinate M:");
            kord_m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Įveskite koordinate N:");
            kord_n = Convert.ToInt32(Console.ReadLine());

            bool tikrinimas = (kord_m > kord_x) && (kord_m < kord_x1) && (kord_n > kord_y) && (kord_n < kord_y1);
            Console.WriteLine("M.N taskas patenka i staciakampi (True-patenka, False-nepatenka): {0}", tikrinimas);
            Console.ReadLine();
        }
    }
}
