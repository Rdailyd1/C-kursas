using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Rectangle
    {
        //master variables
        private double lenth;
        private double width;

        public void Acceptdetails()
        {
            lenth = 4.5;
            width = 3.5;
        }
        public double GetArea()
        {
            return lenth * width;
        }
        public void Display()
        {
            Console.WriteLine("Lenth: {0}", lenth);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }
    class Program
    { 
            static void Main(string[] args)
    {
        Rectangle r = new Rectangle();
        r.Acceptdetails();
        r.Display();
        Console.ReadLine();
    }

    }
}
