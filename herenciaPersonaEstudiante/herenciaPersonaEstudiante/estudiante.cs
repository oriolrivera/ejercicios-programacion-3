using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace herenciaPersonaEstudiante
{
    class estudiante : persona
    {
        static void Main(string[] args)
        {
            persona objP = new persona();
            string dataEst = objP.datosEstud("2010-0312", "informatica");
            Console.WriteLine(dataEst);

            string nombre = datos("minom", "apellido", 1234, 5463, "Santo domingo rd", "Enero 12 de 1990");

            Console.WriteLine(nombre);


            Console.ReadLine();
        }
    }
}
