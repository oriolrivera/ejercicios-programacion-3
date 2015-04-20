using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sumasDosNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int resul;

            Console.WriteLine("Ingrese el primer numero");            
                 num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
                 num2 = int.Parse(Console.ReadLine());
            resul = num1 + num2;
            Console.WriteLine("El Resultado es = " + resul);
            Console.ReadLine();


        }
    }
}
