using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_probleme_cu_numere
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,k;
            Console.WriteLine("Introduceti numarul n: ");
            n= int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul k: ");
            k = int.Parse(Console.ReadLine());
            if (n % k == 0)
                Console.WriteLine("{0} il divide pe {1}", n, k);
            else
                Console.WriteLine("{0} nu il divide pe {1}", n, k);
        }
    }
}
