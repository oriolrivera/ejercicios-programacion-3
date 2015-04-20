using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero = 0;
            double i = 0;
            double fact = 1;
            Console.WriteLine("Escriba el numero");
            numero = Convert.ToDouble(Console.ReadLine());
            for (i = 1; i < numero + 1; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine("El factorial es = " + fact); 
            
            Console.Read();
        }
    }
}
