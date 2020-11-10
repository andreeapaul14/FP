using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_probleme_cu_numere
{
    class Program
    {
        static void Main(string[] args)
        {
            int k, n;
            Console.WriteLine("Introduceti numarul n: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul k: ");
            k = int.Parse(Console.ReadLine());
            for (int i = 1; i <= k-1; i++) 
                n /= 10;
            Console.WriteLine("A k-a cifra din numar este {0}", n % 10);
        }
    }
}
