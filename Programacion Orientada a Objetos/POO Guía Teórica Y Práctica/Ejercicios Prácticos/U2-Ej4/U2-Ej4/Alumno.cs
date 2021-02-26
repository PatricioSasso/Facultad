using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_Ej4
{
    class Alumno
    {
        private int legajo;
        private string nombre;
        private string apellido;
        private decimal[] notas;
        private decimal promedio;

        public int Legajo { get => legajo; }
        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public decimal[] Notas { get => notas; }
        public decimal Promedio { get => promedio; }

        public event EventHandler Promedio10;
        public event EventHandler<PromedioMenorQue4> PromedioMenorQue4;


        public Alumno(int Legajo, string Nombre, string Apellido, decimal[] Notas)
        {
            this.legajo = Legajo;
            this.nombre = Nombre;
            this.apellido = Apellido;
            this.notas = Notas;
            this.promedio = CalcularPromedio(Notas);
        }

        public void Modificar(string NuevoNombre, string NuevoApellido, decimal[] NuevasNotas)
        {
            this.nombre = NuevoNombre;
            this.apellido = NuevoApellido;
            this.notas = NuevasNotas;
            this.promedio = CalcularPromedio(NuevasNotas);
        }

        public decimal CalcularPromedio(decimal[] Notas)
        {

            for (int i = 0; i < Notas.Length; i++)
            {
                promedio += Notas[i];
            }
            if (Notas.Length == 1)
            {
                return notas[0];
            }
            else
            {
                return (promedio / notas.Length);
            }
        }

        public void CheckearPromedio()
        {
            if (promedio == 10)
            {
                Promedio10.Invoke(Promedio10, null);
            }
            if (promedio < 4)
            {
                PromedioMenorQue4.Invoke(this, new PromedioMenorQue4(promedio));
            }
        }
    }

    public class PromedioMenorQue4
    {
        private decimal promedio;

        public PromedioMenorQue4(decimal promedio)
        {
            this.promedio = promedio;
        }

        public decimal Promedio { get => promedio; }

        public string Mensaje()
        {
            return "El alumno tiene promedio " + promedio + " debe recursar.";
        }
    }
}
