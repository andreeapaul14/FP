using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_probleme_cu_numere
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b,x,y,z=0;
            Console.WriteLine("Introduceti 2 numere intregi: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            x = a;
            y = b;
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            z = x * y / a;
            Console.WriteLine($"Cel mai mare divizor al numerelor {x} si {y} este {a}");
            Console.WriteLine($"Cel mai mic multiplu comun al numerelor {x} si {y} este {z}");
        }
    }
}
