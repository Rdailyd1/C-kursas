﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class vardas_pavarde
    {

        static void Main(string[] args)
        {
            string vardas = "";
            string pavarde = "";

            Console.WriteLine("Įveskite varda:");
            vardas = Console.ReadLine();
            Console.WriteLine("Įveskite pavarde:");
            pavarde = Console.ReadLine();

            Console.WriteLine("{0} {1}", vardas, pavarde);

            Console.ReadLine();
        }
    }
}
