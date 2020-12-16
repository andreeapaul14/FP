using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_probleme_cu_secvente
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul n");
            int n = int.Parse(Console.ReadLine());
            int firstNumber = 1, secondNumber = 1;
            int fn;


            for (int i = 2; i < n; i++)
            {
                fn= firstNumber + secondNumber;
                secondNumber = firstNumber;
                firstNumber = fn;
            }
            Console.WriteLine ("Al {0}-lea termen din sirul fibonacci este {1} ", n, firstNumber);
        }
    }
}
