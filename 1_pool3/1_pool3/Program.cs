using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_pool3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, s = 0;
            int[] a = new int[100];
            Console.WriteLine("Dati nr de elemente de initializat din vector");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n ; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                s = s + a[i];
            }
            Console.WriteLine("Suma={0}", s);
        }
    }
}
