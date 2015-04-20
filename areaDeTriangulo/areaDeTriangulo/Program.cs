using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace areaDeTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, h, area;
            Console.WriteLine("Ingrese la base");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la altura");
            h = Convert.ToDouble(Console.ReadLine());
            area = b * h / 2;
            Console.WriteLine("El area del triangulo es = " + area);
            Console.ReadLine();
        }
    }
}
