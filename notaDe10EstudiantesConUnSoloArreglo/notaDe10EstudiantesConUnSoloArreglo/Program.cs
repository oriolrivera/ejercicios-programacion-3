using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * 5) Hacer un programa en C Sharp que capture la Matricula, 
 * Nombre, Apellido, Nota del primer encuentro, 
 * nota del segundo encuentro, nota del tercer encuentro, 
 * nota del cuarto encuentro, nota del quinto encuentro de
 * diez estudiantes utilizando un solo arreglo y calcule la 
 * calificación final para cada estudiante.
 */

namespace notaDe10EstudiantesConUnSoloArreglo
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
                string nota1 = Console.ReadLine();

                Console.WriteLine("Ingrese nota 2");
                string nota2 = Console.ReadLine();

                Console.WriteLine("Ingrese nota 3");
                string nota3 = Console.ReadLine();

                Console.WriteLine("Ingrese nota 4");
                string nota4 = Console.ReadLine();

                Console.WriteLine("Ingrese nota 5");
                string nota5 = Console.ReadLine();

                string[] estudiantes = new string[8] { matricula, nombre, apellido, nota1, nota2, nota3, nota4, nota5 };


                //sumar notas
                double result;
                result = Convert.ToDouble(nota1) + Convert.ToDouble(nota2) + Convert.ToDouble(nota3) + Convert.ToDouble(nota4) + Convert.ToDouble(nota5);
                //recorrer el arreglo
                foreach (string i in estudiantes)
                {
                    Console.WriteLine("{0} ", i);
                }

            
                Console.WriteLine("Total nota = " + result);

            }//end for
            Console.Read();
        }
    }
}
