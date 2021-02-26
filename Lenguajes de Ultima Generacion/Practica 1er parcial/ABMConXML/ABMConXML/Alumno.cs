using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMConXML
{
    class Alumno
    {
        public int Legajo;
        public string Nombre;
        public string Apellido;

        public Alumno(int legajo, string nombre, string apellido)
        {
            Legajo = legajo;
            Nombre = nombre;
            Apellido = apellido;
        }
    }
}
