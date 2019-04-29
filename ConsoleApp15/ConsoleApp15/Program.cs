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
            
            

            Console.WriteLine("Įveskite skaičių 1:");
            skaicius1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Įveskite skaičių 2:");
            skaicius2 = Convert.ToInt16(Console.ReadLine());
            int suma = skaicius1 + skaicius2;
            int skirtumas = skaicius1 - skaicius2;
            int sandauga = skaicius1 * skaicius2;
            decimal dalyba = skaicius1 / skaicius2;
            Console.WriteLine("Suma: {0}", suma);
            Console.WriteLine("skirtumas: {0}", skirtumas);
            Console.WriteLine("sandauga: {0}", sandauga);
            Console.WriteLine("dalyba: {0}", dalyba);


            Console.ReadLine();
        }
    }
}
