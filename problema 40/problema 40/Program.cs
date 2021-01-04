using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_40
{
    class Program
    {
        //50. Functia care determina daca un vector dat are numai elem pare.
        private static int impar(int[] v,int n)
        {
            int ok = 0,i;
            for( i=1; i<=n; i++)
                if (v[i] % 2 == 0)
                    ok = 1;
            return ok;
        }
        static void Main(string[] args)
        {
            int i, n;
            int[] v = new int[100];
            Console.WriteLine("Dati nr de elemente din vector");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elemente din vector");
            for (i = 1; i <=n ; i++)
            {
                v[i] =int.Parse(Console.ReadLine());
            }
            if (impar(v, n) == 0)
                Console.WriteLine("Vectorul are numai elemente impare.");
            else
                Console.WriteLine("Vectorul nu are doar elemente impare, ce si pare.");
        }
    }
}
