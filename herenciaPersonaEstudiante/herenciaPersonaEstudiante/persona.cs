using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace herenciaPersonaEstudiante
{
    class persona
    {
        static void datosPersona(string[] args)
        {
            string nombre = datos("minom", "apellido", 1234, 5463, "Santo domingo rd", "Enero 12 de 1990");

            Console.WriteLine(nombre);
            Console.ReadLine();
        }

        public static string datos(string nombre, string apellido, int cedula, int seg, string dir, string fehcaNac)
        {

            return "Nombre = " + nombre + " | Apellido = " + apellido + " | Cedula = " + cedula + "| Numero de la seguridad social = " + seg + "| Dirección = " + dir + "| Fecha de nacimiento = " + fehcaNac;

        }

        public string datosEstud(string matricula, string carrera)
        {
            return "Matricula = " + matricula + " | Carrera = " + carrera;
        }
    }
}
