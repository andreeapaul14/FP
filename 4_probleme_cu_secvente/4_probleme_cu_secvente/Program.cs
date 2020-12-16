using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_probleme_cu_secvente
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, poz = -1,a,b;
            Console.WriteLine("Introduceti numarul n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul a:");
            a = int.Parse(Console.ReadLine());
            
            for(int i=0;i<n;i++)
            {
                b = int.Parse(Console.ReadLine());
                if(b==a)
                {
                    poz = i;
                    break;
                }
            }
            Console.WriteLine("Numarul {0} se afla pe pozitia {1}", a, poz);
        }
    }
}
