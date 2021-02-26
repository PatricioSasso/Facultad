using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1 
{
    class Alumno
    {
        int legajo;
        string nombre;
        string apellido;
        decimal promedio;

        public Alumno(int legajo, string nombre, string apellido, decimal promedio)
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.promedio = promedio;
        }

        public int Legajo { get => legajo; }
        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public decimal Promedio { get => promedio; }

        public void Modificar(string nuevoNombre, string nuevoApellido, decimal nuevoPromedio)
        {
            this.nombre = nuevoNombre;
            this.apellido = nuevoApellido;
            this.promedio = nuevoPromedio;
        }

    }
}
