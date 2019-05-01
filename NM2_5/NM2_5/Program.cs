using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NM2_5
{
    class Program
    {
            static void Main(string[] args)
            {
                int krastine_x;
                int krastine_y;
                int talpa;
                Console.WriteLine("Įveskite stačiakamoio kraštinę X:");
                krastine_x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Įveskite stačiakamoio kraštinę Y:");
                krastine_y = Convert.ToInt32(Console.ReadLine());
                talpa = krastine_x * krastine_y / 6;
                Console.WriteLine("Telpa - {0}", talpa);
                Console.ReadLine();
            }
        }
    }
