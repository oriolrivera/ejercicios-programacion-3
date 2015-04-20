using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cuadrado100Al1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i >= 1; i--)
            {
                Console.WriteLine(i + " x " + i + " cuadrado = " + i*i);
            }

            Console.ReadLine();
        }
    }
}
