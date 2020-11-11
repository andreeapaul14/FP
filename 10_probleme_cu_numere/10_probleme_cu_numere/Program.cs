using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_probleme_cu_numere
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Introduceti numarul n: ");
            n = int.Parse(Console.ReadLine());
            if (n < 2 || ( n%2==0 && n!=2))
                Console.WriteLine("Numarul {0} nu este prim.", n);
            for (int d = 3; d * d <= n; d += 2)
                if (n % d == 0)
                    Console.WriteLine("Numarul {0} nu este prim.", n);
            Console.WriteLine("Numarul {0} este prim.", n);
        }
    }
}
