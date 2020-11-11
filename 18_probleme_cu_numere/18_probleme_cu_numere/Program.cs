using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_probleme_cu_numere
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, d, p, k = 0; ;
            Console.WriteLine("Introduceti numarul n: ");
            n = int.Parse(Console.ReadLine());
            d = 2;
            while(n>1)
            {
                p = 0;
                while(n%d==0)
                { 
                    p++;
                    n /= d;
                }
                if (p > 0)
                    if (k == 1)
                        Console.Write($"X{d}^{p}");
                    else
                    {
                        Console.Write($"{d}^{p}");
                        k = 1;
                    }
                d++;
            }
            Console.WriteLine();
        }
    }
}
