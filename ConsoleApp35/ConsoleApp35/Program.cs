using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class laipsniai
    {
        //master variables

        public int kelvin(int celcius)
        {
            int kelvin = 273 + celcius;
            return kelvin;
        }
        public int fahrenheit(int celcius)
        {
            int fahrenheit = celcius * 18 / 10 + 32;
            return fahrenheit;
        }

        public void Display(int celcius)
        {
            Console.WriteLine("kelvin = {0}", kelvin(celcius));
            Console.WriteLine("fahrenheit = {0}", fahrenheit(celcius));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int celcius = 0;
            Console.WriteLine("Įveskite celcijaus laipsnius:");
            celcius = Convert.ToInt16(Console.ReadLine());

            laipsniai temp = new laipsniai();

            temp.Display(celcius);
            Console.ReadLine();
        }

    }
}
