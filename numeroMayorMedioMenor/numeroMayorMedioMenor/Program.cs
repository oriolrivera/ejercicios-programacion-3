using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace numeroMayorMedioMenor
{
    class Program
    {
        static void Main(string[] args)
        {
             int num1, num2, num3;
                Console.WriteLine("Ingrese primer numero");
                      num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese segundo numero");
                      num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese tercer numero");
                     num3 = int.Parse(Console.ReadLine());

                if (num1 > num2 && num2 > num3) {
                Console.WriteLine("Numero mayor = " +num1);
                Console.WriteLine("Numero medio = " +num2);
                Console.WriteLine("Numero menor = " +num3);
                }else if (num2 > num1 && num1 > num3) {
                Console.WriteLine("Numero medio = " +num1);
                Console.WriteLine("Numero mayor = " +num2);
                Console.WriteLine("Numero menor= " +num3);
                }else if (num2 > num1 && num1 > num3) {
                Console.WriteLine("Numero mayor = " +num2);
                Console.WriteLine("Numero medio = " +num1);
                Console.WriteLine("Numero menor = " +num3);
                }else if (num2 > num3 && num3 > num1 ) {
                Console.WriteLine("Numero mayor = " +num2);
                Console.WriteLine("Numero medio = " +num3);
                Console.WriteLine("Numero menor = " +num1);
                }else if (num3 > num1 && num1 > num2) {
                Console.WriteLine("Numero mayor = " +num3);
                Console.WriteLine("Numero medio = " +num1);
                Console.WriteLine("Numero menor = " +num2);
                }else if (num3 > num2 && num2 > num1) {
                Console.WriteLine("Numero mayor = " +num3);
                Console.WriteLine("Numero medio = " +num2);
                Console.WriteLine("Numero menor = " + num1);
                }
                Console.ReadLine();
        }
    }
}
