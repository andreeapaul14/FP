using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_probleme_cu_secvente
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, ok = 0, n,s=1;
            Console.WriteLine("Introducetinumarul n: ");
            n = int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                x = int.Parse(Console.ReadLine());
                if(x!=0 && ok==0)
                {
                    s++;
                    ok = 1;
                }
                if (x != 0 && ok == 1)
                {
                    ok = 1;
                }
            }
            Console.WriteLine("{0} grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere",s);
        }
    }
}
