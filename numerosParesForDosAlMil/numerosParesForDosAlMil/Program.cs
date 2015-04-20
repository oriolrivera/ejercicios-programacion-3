using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace numerosParesForDosAlMil
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 1000; i=i+2)
            {
                Console.WriteLine(i);
            }

            Console.Read();

        }
    }
}
