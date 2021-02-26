using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U5_Ej3
{
    class Alumno
    {
        private int legajo;
        private string nombre;
        private string apellido;
        private decimal promedio;

        public int Legajo { get => legajo; }
        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public decimal Promedio { get => promedio; }

        public Alumno(int Legajo, string Nombre, string Apellido, decimal Promedio)
        {
            this.legajo = Legajo;
            this.nombre = Nombre;
            this.apellido = Apellido;
            this.promedio = Promedio;
        }

        public void Modificar(string NuevoNombre, string NuevoApellido, decimal NuevoPromedio)
        {
            this.nombre = NuevoNombre;
            this.apellido = NuevoApellido;
            this.promedio = NuevoPromedio;
        }
    }
}
