using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class vidurkis
    {

        static void Main(string[] args)
        {
            int skaicius = 1;
            int indeksas = -1;
            int suma = 0;
            double vidurkis = 0;
            Console.WriteLine("Įveskite skaičius, sekos pabaiga skaičius 0");
            while (skaicius != 0)
            {
                Console.WriteLine("Įveskite skaičių:");
                skaicius = Convert.ToInt16(Console.ReadLine());
                suma = suma + skaicius;
                indeksas = indeksas + 1 ;
                
            }
            //Console.Clear();
            vidurkis = suma / indeksas;
            Console.WriteLine("Vidurkis: {0}", vidurkis);
            Console.ReadLine();
        }
    }
}
