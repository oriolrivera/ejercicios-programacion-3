using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace anioBosiesto
{
    class Program
    {
        static void Main(string[] args)
        {
                  int year;  
                  Console.WriteLine("Ingresa año");
                  year = Convert.ToInt32(Console.ReadLine());
                  if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
                  {
                      Console.WriteLine("El año " + year + " Si es bisiesto ");  
                 }else{
                     Console.WriteLine("El año " + year + " No es bisiesto ");  
                 }                    
                 Console.ReadLine();  
                     
                
        }
    }
}
