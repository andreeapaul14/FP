using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_probleme_cu_secvente
{
    class Program
    {
        static void Main(string[] args)
        {
            int s=0,i;
            Console.Write("Introduceti numarul de elemente al vectorului: ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("Introduceti elementele:");
            for ( i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                if (v[i] % 2 == 0)
                    s++;
            }

            Console.WriteLine("Exista {0} numere pare", s);
        }
    }
}
