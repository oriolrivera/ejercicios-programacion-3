using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * 4)Hacer un programa en C Sharp que capture la Matricula, 
 * Nombre, Apellido, Nota del primer encuentro, nota del 
 * segundo encuentro, nota del tercer encuentro, nota del 
 * cuarto encuentro, nota del quinto encuentro de diez 
 * estudiantes utilizando arreglos y calcule la 
 * calificación final para cada estudiante.
 */

namespace nota10EstudiantesArreglos
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int init = 1; init <= 10; init++)
            {
                Console.WriteLine("Ingrese datos de estudiante = " + init);
                Console.WriteLine("Ingrese matricula");
                string matricula = Console.ReadLine();
                Console.WriteLine("Ingrese el nombre");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el apellido");
                string apellido = Console.ReadLine();

                Console.WriteLine("Ingrese nota 1");
                double nota1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese nota 2");
                double nota2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese nota 3");
                double nota3 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese nota 4");
                double nota4 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese nota 5");
                double nota5 = double.Parse(Console.ReadLine());

                string[] estudiantes = new string[3] { matricula, nombre, apellido};
                double[] notas = new double[5] { nota1, nota2, nota3, nota4, nota5 };


                //recorrer el arreglo
                foreach (string i in estudiantes)
                {
                    Console.WriteLine("{0} ", i);
                }

                //sumar notas
                double result;
                result = nota1 + nota2 + nota3 + nota4 + nota5;

                foreach (double Inota in notas)
                {
                    Console.WriteLine("{0} ", Inota);
                     
                     
                }
                Console.WriteLine("Total nota = " + result);
                
            }//end for
            Console.Read();
        }
    }
}
