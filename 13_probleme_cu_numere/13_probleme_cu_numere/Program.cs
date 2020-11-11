using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_probleme_cu_numere
{
    class Program
    {
        static void Main(string[] args)
        {
            int y1, y2, c = 0;
            Console.WriteLine("Introduceti y1: ");
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti y2: ");
            y2 = int.Parse(Console.ReadLine());
            for(int i=y1;i<=y2;i++)
            {
                if((i % 4 == 0 && i % 100 != 0) || i % 400 == 0)
                {
                    c++;
                }
            }
            Console.WriteLine($"Intre anii {y1} si {y2} sunt {c} ani bisecti.");
        }
    }
}
