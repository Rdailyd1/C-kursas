using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06_04.rekursija
{
    class Program
    {
        public static string vardas(string name)
        {
            Console.WriteLine(name);
            return name;
        }

        static void Main(string[] args)
        {
            string name = "Rolandas";


            vardas(name);

            Console.ReadKey();
        }
    }
}
