using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_probleme_cu_secvente
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,b,s=0;
            Console.WriteLine("Introduceti numarul n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele secventei");
            for(int i=0;i<n;i++)
            {
                b = int.Parse(Console.ReadLine());
                if (b == i)
                    s++;
            }
            Console.WriteLine("Numarul de elemente care sunt egale cu pozitia pe care apar in secventa este {0}", s);
        }
    }
}
