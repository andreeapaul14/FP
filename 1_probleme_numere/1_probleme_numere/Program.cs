using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_probleme_numere
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, x;
            Console.WriteLine("Dati coeficientii ecuatiei");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            if (a != 0)
            {
                x = -b / a;
                Console.WriteLine("Solutia = {0}", x);
            }
            else
                 Console.WriteLine("Ecuatia nu este de gradul I");
        }
    }
}
