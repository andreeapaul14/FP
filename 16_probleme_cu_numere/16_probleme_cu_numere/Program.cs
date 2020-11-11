using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_probleme_cu_numere
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, min, max;
            Console.WriteLine("Introduceti 5 numere: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());
            if (a < b)
            {
                if (a < c && a < d && a < e)
                {
                    Console.Write($"{a} ");
                    if (b < c)
                    {
                        if (b < d && b < e)
                        {
                            Console.Write($"{b} ");
                            if (c < d)
                            {
                                if (c < e)
                                {
                                    Console.Write($"{c} ");
                                    if (d < e)
                                        Console.WriteLine($"{d} {e}");
                                    else
                                        Console.WriteLine($"{e} {d}");
                                }
                                else
                                {
                                    if(e<c)
                                    {
                                        Console.Write($"{e} ");
                                        if(e<d)
                                            Console.WriteLine($"{c} {d}");
                                        else
                                            Console.WriteLine($"{d} {c}");
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}
