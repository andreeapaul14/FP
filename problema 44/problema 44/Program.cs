using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_44
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, x;
            int[]v = new int [100];
            for (i = 0; i <= 99; i++)
                v[i] = 0;                   //initializez vectorul cu 0
            Random rnd = new Random();
            for (i = 0; i <= 99; i++)
            {
                x = rnd.Next(100);
                v[x]++;                     //calculez fecventa 
            }
            for (i = 0; i <= 99; i++)
            {
                if (v[i] >= 2)              // daca apare de 2 sau mai multe ori il afisez
                    Console.Write(" {0}", i);
            }
        }
    }
}
