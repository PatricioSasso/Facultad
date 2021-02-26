using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2A_POO_TP2_Semipresencial__Sasso_
{
    class Alumno
    {
        private int legajo;
        private string nombre;
        private string apellido;
        private List<Materia> materias;

        public int Legajo { get => legajo; }
        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }

        public Alumno(int Legajo, string Nombre, string Apellido)
        {
            legajo = Legajo;
            nombre = Nombre;
            apellido = Apellido;
        }

        public void Modify(string NuevoNombre, string NuevoApellido)
        {
            nombre = NuevoNombre;
            apellido = NuevoApellido;
        }

    }
}
