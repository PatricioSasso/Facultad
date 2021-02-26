using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4_Medicamentos
{
    class Paciente
    {
        private int dni;
        private string apellido;
        private string nombre;
        private List<Medicamento> p_medicamentos;

        public Paciente(int dni, string apellido, string nombre)
        {
            this.dni = dni;
            this.apellido = apellido;
            this.nombre = nombre;
            this.p_medicamentos = new List<Medicamento>();
        }

        public int Dni { get => dni; set => dni = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        internal List<Medicamento> P_medicamentos { get => p_medicamentos; set => p_medicamentos = value; }

        public void Modificar(string nuevoApellido, string nuevoNombre)
        {
            this.apellido = nuevoApellido;
            this.nombre = nuevoNombre;
        }
    }
}
