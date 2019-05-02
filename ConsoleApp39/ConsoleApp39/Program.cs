using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Iveskite grupes nariu skaiciu:");
            int nariai = Convert.ToInt16(Console.ReadLine());
            if (nariai == 1)
            {
                Console.WriteLine("Tai solo atlikejas");
            }
            else if (nariai == 2)
            {
                Console.WriteLine("Tai duetas");
            }
            else if (nariai > 2 && nariai < 10)
            {
                Console.WriteLine("Tai ansamblis");

            }
            else if (nariai > 10)
            {
                Console.WriteLine("Tai kamerinis ansamblis");
            }
            else
            {
                Console.WriteLine("Klaidingas nariu skaicius");
            }
            Console.ReadLine();
        }
    }
}
