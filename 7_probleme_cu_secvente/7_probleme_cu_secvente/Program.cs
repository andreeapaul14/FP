using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_probleme_cu_secvente
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,min,max,b;
            Console.WriteLine("Introduceti numarul n");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele secventei");
            b = int.Parse(Console.ReadLine());
            min = max = b;
            for (int i=1;i<n;i++)
            {
                b = int.Parse(Console.ReadLine());
                if (b < min)
                    min = b;
                else
                    if (b > max)
                    max = b;
            }
            Console.WriteLine("Minimul din secventa este {0}", min);
            Console.WriteLine("Maximul din secventa este {0}", max);
        }
    }
}
