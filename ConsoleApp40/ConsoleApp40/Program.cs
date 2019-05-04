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
            
            if (nariai > 2 && nariai < 10)
            {
                nariai = 3;
            }
            if (nariai > 10)
            {
                nariai = 4;
            }
            switch (nariai)
            {
                case 1:
                    Console.WriteLine("Tai solo atlikejas");
                    break;
                case 2:
                    Console.WriteLine("Tai duetas");
                    break;
                case 3:
                    Console.WriteLine("Tai ansamblis");
                    break;
                case 4:
                    Console.WriteLine("Tai kamerinis ansamblis");
                    break;
                default:
                    Console.WriteLine("Klaidingas nariu skaicius");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
            }
            
            Console.ReadLine();
        }
    }
}
