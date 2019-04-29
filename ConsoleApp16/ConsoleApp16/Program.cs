using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class skaiciu_veiksmai
    {

        static void Main(string[] args)
        {
            int skaicius1 = 0;
            int skaicius2 = 0;
            int skaicius3 = 0;

            Console.WriteLine("Įveskite skaičių 1:");
            skaicius1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Įveskite skaičių 2:");
            skaicius2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Įveskite skaičių 3:");
            skaicius3 = Convert.ToInt16(Console.ReadLine());
            int suma = skaicius1 + skaicius2 + skaicius3;
           
            decimal vidurkis = suma/3;
            Console.WriteLine("Vidurkis: {0}", vidurkis); 

            Console.ReadLine();
        }
    }
}
