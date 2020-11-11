using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_probleme_cu_numere
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, n,c=0;
            Console.WriteLine("Introduceti numarul n: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul b: ");
            b = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
                if (i % n == 0)
                    c++;
            Console.WriteLine($"In intervalul [{a},{b}] sunt {c} numere intregi divizibile cu {n}");
        }
    }
}
