using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_probleme_cu_numere
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,c=0, copien,k=0;
            n = int.Parse(Console.ReadLine());
            copien = n;
            while (n % 10 == 0) //tratez cazut in care numarul are mai multi de 0 la final 
            {
                k++;
                n /= 10;
            }
            while (n!=0)
            {
                c = c * 10 + n % 10;
                n /= 10;
            }
            n = copien;
            if (k != 0)
            {
                Console.Write($"Numarul {n} scris invers este ");
                while (k != 0) 
                {
                    Console.Write("0");
                    k--;

                }
                Console.Write($"{c}");
                Console.WriteLine();

            }
                
            else
                Console.WriteLine($"Numarul {n} scris invers este {c}");
        }
    }
}
