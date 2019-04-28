using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class aritmetiniai_veiksmai
    {
        //master variables
       
        public int sandauga(int pirmas, int antras)
        {
            int sandauga = pirmas * antras;
            return sandauga;
        }

        public double dalyba(int pirmas, int antras)
        {
            double dalyba = pirmas / antras;
            return dalyba;
        }
        public double suma(int pirmas, int antras)
        {
            int suma = pirmas + antras;
            return suma;
        }
        public double skirtumas(int pirmas, int antras)
        {
            int skirtumas = pirmas - antras;
            return skirtumas;
        }

    public void Display(int pirmas, int antras)
        {
            Console.WriteLine("Sandauga: {0}", sandauga(pirmas,antras));
            Console.WriteLine("Dalyba: {0}", dalyba(pirmas, antras));
            Console.WriteLine("Suma: {0}", suma(pirmas, antras));
            Console.WriteLine("Skirtumas: {0}", skirtumas(pirmas, antras));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int pirmas = 0;
            int antras = 0;
            Console.WriteLine("Įveskite I-ą skaičių:");
            pirmas = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Įveskite II-ą skaičių:");
            antras = Convert.ToInt16(Console.ReadLine());
            aritmetiniai_veiksmai aritmetika = new aritmetiniai_veiksmai();
           
            aritmetika.Display(pirmas, antras);
            Console.ReadLine();
        }

    }
}
