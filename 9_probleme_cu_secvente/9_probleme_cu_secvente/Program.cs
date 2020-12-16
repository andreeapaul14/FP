using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_probleme_cu_secvente
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a,i,dir,b;
            Console.WriteLine("Introduceti nr de elemente ak secventei");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele secventei");
            a = int.Parse(Console.ReadLine());

            dir = 0; // initial directia este indecisa (egala)
            i = 1;
            while (i < n && dir < 2)
            {
                b = int.Parse(Console.ReadLine());
                if (b > a) // secventa devine crescatoare, daca se mai poate
                    if (dir < 0)
                        dir = 2;
                    else
                        dir = 1;
                else if (b < a) // secventa devine descrescatoare, daca se mai poate
                    if (dir > 0)
                        dir = 2;
                    else
                        dir = -1;
                a = b;
                i++;
            }
            if (dir < 2)
                Console.WriteLine("Secventa este monotona");
            else
                Console.WriteLine("Secventa nu este monotona");

        }
    }
}
