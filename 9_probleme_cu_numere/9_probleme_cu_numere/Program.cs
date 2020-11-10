using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_probleme_cu_numere
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Introduceti numarul n: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Divizorii lui {0} sunt: ",n);
            for (int d = 1; d <= n; d++)
                if (n % d == 0)
                {
                    Console.Write(d);
                    Console.Write(" ");
                }
        }
    }
}
