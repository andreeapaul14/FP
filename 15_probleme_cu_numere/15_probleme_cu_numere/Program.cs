using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_probleme_cu_numere
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Introduceti primul numar: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea numar: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al trilea numar: ");
            c = int.Parse(Console.ReadLine());
            if (a < b)
            {
                if (a < c)
                {
                    Console.Write($"{a} ");
                    if (b < c)
                    {
                        Console.WriteLine($"{b} {c}");
                    }
                    else
                    {
                        Console.WriteLine($"{c} {b}");
                    }
                }
                else
                {
                    Console.WriteLine($"{c} {a} {b}");
                }
            }
            else
            {
                if (b < c)
                {
                    Console.Write($"{b} ");
                    if (a < c)
                    {
                        Console.WriteLine($"{a} {c}");
                    }
                    else
                    {
                        Console.WriteLine($"{c} {a}");
                    }
                }
                else
                {
                    Console.WriteLine($"{c} {b} {a}");
                }
            }
        }
    }
}
