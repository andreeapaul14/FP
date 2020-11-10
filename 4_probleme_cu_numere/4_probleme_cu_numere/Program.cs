using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_probleme_cu_numere
{
    class Program
    {
        static void Main(string[] args)
        {
            int an;
            an = int.Parse(Console.ReadLine());
            if ((an % 4 == 0 && an%100!=0) || an%400==0)
                Console.WriteLine("Anul {0} este an bisect", an);
            else
                Console.WriteLine("Anul {0} nu este an bisect", an);
        }
    }
}
