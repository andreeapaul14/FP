using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_probleme_cu_secvente
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, s = 0,p=1;
            Console.WriteLine("Introduceti numarul n: ");
            n = int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                s = s + i;
                p = p * i;
            }
            Console.WriteLine("Suma numerelor de la 1 la {0} este {1}", n, s);
            Console.WriteLine("Produsul numerelor de la 1 la {0} este {1}", n, p);
        }
    }
}
