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
            DateTime kurso_pradzia;
            DateTime kurso_pabaiga;
            double dienos = 0;
            int savaites = 0;
            int be_savaitgaliu = 0;


            Console.WriteLine("Įveskite mokyklos pavadinimą:");
            mokyklos_pav = Console.ReadLine();
            Console.WriteLine("Įveskite kurso pavadinimą:");
            kurso_pav = Console.ReadLine();
            Console.WriteLine("Įveskite studentų skaičių:");
            studentu_sk = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Įveskite pradzios data:");
            kurso_pradzia = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Įveskite pabaigos data:");
            kurso_pabaiga = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Mokyklos pavadinimas: {0}", mokyklos_pav);
            Console.WriteLine("Kurso pavadinimas: {0}", kurso_pav);
            Console.WriteLine("Studentų skaičius: {0}", studentu_sk);
            Console.WriteLine("Šiandien: {0}", siandien.ToLongDateString());
            dienos = (kurso_pradzia - kurso_pabaiga).TotalDays;
            savaites = Convert.ToInt16(dienos/7);
            Console.WriteLine("Dienu skaičius: {0}", dienos);
            Console.WriteLine("Savaiciu skaičius: {0}", savaites);
            be_savaitgaliu = Convert.ToInt16(dienos) - Convert.ToInt16(savaites) * 3;
            Console.WriteLine("Dienu skaicius be savaitgaliu: {0}", be_savaitgaliu);
            Console.ReadLine();
        }
    }
}
