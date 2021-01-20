using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_pool3
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int n;
            Console.Write("introduceti numarul de elemente: ");
            n = int.Parse(Console.ReadLine());

            int[] v = new int[n];

            for (int i = 0; i < n; i++)
            {
                int x = rnd.Next(10);
                v[i] = x;
                Console.Write($"{v[i]} ");
            }
            int y = v[0]; //memorarea primului element
            for (int i = 1; i < n; i++)
            {
                v[i - 1] = v[i]; //rotirea spre stanga
            }
            v[n - 1] = y; //actualizarea ultimului element cu primul

            Console.WriteLine();
            for (int i = 0; i < n; i++)
                Console.Write($"{v[i]} ");
        }
    }
}
