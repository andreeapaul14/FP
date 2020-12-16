using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_probleme_cu_secvente
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, neg = 0, zero = 0, poz = 0;
            Console.WriteLine("Introduceti nr de elemente din secventa: ");
            n =int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("Introduceti elementele secventei:");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                if (v[i] < 0)
                    neg++;
                else
                    if (v[i] > 0)
                    poz++;
                else
                    zero++;
            }
            Console.WriteLine("Elemente negative:{0} ", neg);
            Console.WriteLine("Elemente pozitive:{0} ", poz);
            Console.WriteLine("Elemente egale cu zero:{0} ", zero);
        }
    }
}
