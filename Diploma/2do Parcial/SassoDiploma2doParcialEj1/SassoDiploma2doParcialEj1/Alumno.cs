using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SassoDiploma2doParcialEj1
{
    [Serializable]
    public class Alumno
    {
        string legajo;
        string nombre;
        string apellido;

        public Alumno()
        {
            Legajo = "TAR-124124";
            Nombre = "Patricio";
            Apellido = "Sasso";
        }

        public Alumno(string legajo, string nombre, string apellido)
        {
            Legajo = legajo;
            Nombre = nombre;
            Apellido = apellido;
        }

        public string Legajo { get => legajo; set => legajo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
    }
}
