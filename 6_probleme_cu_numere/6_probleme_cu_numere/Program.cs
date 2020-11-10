using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_probleme_cu_numere
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            Console.WriteLine("Introduceti latura a: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti latura b: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti latura c: ");
            c = float.Parse(Console.ReadLine());
            if ((a < b + c) && (b < a + c) && (c < a + b) && (a > 0) && (b > 0) && (c > 0))
            {
                Console.WriteLine("Numerele pot forma triunghi");
                if ((a == b) && (a == c))
                    Console.WriteLine("Triunghi echilateral");
                else if ((a == b) || (a == c) || (b==c))
                    Console.WriteLine("Triunghi isoscel");
                else
                    Console.WriteLine("Triunghi oarecare");
            }
            else
                Console.WriteLine("Numerele nu pot forma triunghi");

        }
    }
}
