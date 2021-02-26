using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace U2_Ej5
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

        public static string Universidad;
        public static string Ubicacion;

        public static event EventHandler Promedio10;
        public static event EventHandler<PromedioMenorQue4> PromedioMenorQue4;

        static Alumno()
        {
            Universidad = "UAI";
            Ubicacion = "Centro";
        }


        public Alumno(int Legajo, string Nombre, string Apellido, decimal[] Notas)
        {
            this.legajo = Legajo;
            this.nombre = Nombre;
            this.apellido = Apellido;
            this.notas = Notas;
            this.promedio = CalcularPromedio(Notas);
        }

        public static void AgregarAlumno(List<Alumno> Alumnos)
        {
            try
            {
                int Legajo = int.Parse(Interaction.InputBox("Ingrese el legajo del alumno"));
                string Nombre = Interaction.InputBox("Ingrese el nombre del alumno");
                string Apellido = Interaction.InputBox("Ingrese el apellido del alumno");
                int cant_notas = int.Parse(Interaction.InputBox("Ingrese la cantidad de notas del alumno"));
                decimal[] Notas = new decimal[cant_notas];
                if (cant_notas < 0) { throw new Exception("La nota no puede ser negativa"); }
                if (cant_notas != 0)
                {
                    for (int i = 0; i < cant_notas; i++)
                    {
                        Notas[i] = int.Parse(Interaction.InputBox("Ingrese la nota " + (i + 1) + " ."));
                    }
                }
                if (Alumnos.Exists(a => a.Legajo == Legajo))
                {
                    MessageBox.Show("El legajo ya está siendo utilizado");
                }
                else
                {
                    Alumnos.Add(new Alumno(Legajo, Nombre, Apellido, Notas));
                    MessageBox.Show("Alumno agregado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void EliminarAlumno(int Legajo, List<Alumno> Alumnos)
        {
            try
            {
                if (Alumnos.Exists(a => a.Legajo == Legajo))
                {
                    Alumnos.Remove(Alumnos.Find(a => a.Legajo == Legajo));
                    MessageBox.Show("Alumno eliminado");
                }
                else
                {
                    MessageBox.Show("No existe ningún alumno con ese legajo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void ModificarAlumno(int Legajo, List<Alumno> Alumnos)
        {
            try
            {
                string NuevoNombre = Interaction.InputBox("Ingrese el nombre del alumno");
                string NuevoApellido = Interaction.InputBox("Ingrese el apellido del alumno");
                int cant_notas = int.Parse(Interaction.InputBox("Ingrese la cantidad de notas del alumno"));
                decimal[] NuevasNotas = new decimal[cant_notas];
                if (cant_notas < 0) { throw new Exception("La nota no puede ser negativa"); }
                if (cant_notas != 0)
                {
                    for (int i = 0; i < cant_notas; i++)
                    {
                        NuevasNotas[i] = int.Parse(Interaction.InputBox("Ingrese la nota " + (i + 1) + " ."));
                    }
                }
                if (Alumnos.Exists(a => a.Legajo == Legajo))
                {
                    Alumnos.Find(a => a.Legajo == Legajo).Modificar(NuevoNombre, NuevoApellido, NuevasNotas);
                    MessageBox.Show("Alumno modificado");
                }
                else
                {
                    MessageBox.Show("No existe ningún alumno con ese legajo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
