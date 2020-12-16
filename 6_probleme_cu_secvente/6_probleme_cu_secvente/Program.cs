using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_probleme_cu_secvente
{
    class Program
    {
        private static int crescator(int[] a, int n)
        {
            int i, c;
            c = 1;
            for (i = 0; i <= n - 2; i++)
            {
                if (a[i + 1] < a[i]) c = 0;
            }
            return c;
        }

        static void Main(string[] args)
        {
            int n, i;
            int[] v = new int[100];
            Console.WriteLine("Dati nr de elemente de initializat");
           
            n = int.Parse(Console.ReadLine());
            for (i = 0; i <= n - 1; i++)
            {
                Console.Write("v[{0}]=", i);
                v[i] = int.Parse(Console.ReadLine());
            }
            if (crescator(v, n) == 1)
                Console.WriteLine("Vectorul este ordonat crescator");
            else
                Console.WriteLine("Vectorul nu este ordonat crescator");

        }
    }
}
