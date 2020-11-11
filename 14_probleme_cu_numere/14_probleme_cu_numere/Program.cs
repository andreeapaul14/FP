using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_probleme_cu_numere
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, c, p=0;
            Console.WriteLine("Introduceti numarul n: ");
            n = int.Parse(Console.ReadLine());
            c = n; //c este copia lui n
            while(c!=0)
            {
                p = p * 10 + c % 10;
                c /= 10;
            }
            if (p == n)
                Console.WriteLine($"Numarul {n} este palindrom");
            else
                Console.WriteLine($"Numarul {n} nu este palindrom");
        }
    }
}
