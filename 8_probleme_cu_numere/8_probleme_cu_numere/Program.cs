using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_probleme_cu_numere
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Introduceti numarul a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul b: ");
            b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Numarul a={0} si b={1} ", a, b);
        }
    }
}
