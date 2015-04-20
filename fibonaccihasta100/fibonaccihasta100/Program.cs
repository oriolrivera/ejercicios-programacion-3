using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fibonaccihasta100
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = 0, n2 = 1, n3, cont;
            Console.WriteLine(1);
            for (cont = 1; cont <= 100; cont++)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3);
                n1 = n2;
                n2 = n3;

            }
            Console.ReadLine();
        }
    }
}
