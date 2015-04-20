using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Crear un programa en C# que capture los datos de un empleado utilizando POO.
 */
namespace datosDeEmpleado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese datos de empleado");
           
            Console.WriteLine("Ingrese nomre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese apellido");
            string apellido = Console.ReadLine();
            Console.WriteLine("Ingrese telefono");
            string telefono = Console.ReadLine();
            Console.WriteLine("Ingrese direccion");
            string direccion = Console.ReadLine();
            Console.WriteLine("Ingrese cedula");
            string cedula = Console.ReadLine();
        }
    }
}
