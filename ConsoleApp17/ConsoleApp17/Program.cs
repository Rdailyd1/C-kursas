using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class mokykla
    {

        static void Main(string[] args)
        {
            string mokyklos_pav = "";
            string kurso_pav = "";
            int studentu_sk = 0;
            DateTime siandien = DateTime.Now;
            
            Console.WriteLine("Įveskite mokyklos pavadinimą:");
            mokyklos_pav = Console.ReadLine();
            Console.WriteLine("Įveskite kurso pavadinimą:");
            kurso_pav = Console.ReadLine();
            Console.WriteLine("Įveskite studentų skaičių:");
            studentu_sk = Convert.ToInt16(Console.ReadLine());

                    
            Console.WriteLine("Mokyklos pavadinimas: {0}", mokyklos_pav);
            Console.WriteLine("Kurso pavadinimas: {0}", kurso_pav);
            Console.WriteLine("Studentų skaičius: {0}", studentu_sk);
            Console.WriteLine("Šiandien: {0}", siandien.ToLongDateString());
            Console.ReadLine();
        }
    }
}
