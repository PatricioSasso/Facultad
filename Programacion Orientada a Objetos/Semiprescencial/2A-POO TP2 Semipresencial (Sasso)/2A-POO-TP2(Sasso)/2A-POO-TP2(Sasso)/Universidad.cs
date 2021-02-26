using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2A_POO_TP2_Sasso_
{
    class Universidad
    {
        List<Alumno> alumnos;

        public Universidad()
        {
            alumnos = new List<Alumno>();
        }

        public List<Alumno> Alumnos { get => alumnos; }

        public EventHandler EventoPromedio;

        public void AgregarAlumno()
        {
            try
            {
                int Legajo = int.Parse(Interaction.InputBox("Ingrese el legajo del alumno"));
                string Nombre = Interaction.InputBox("Ingrese el nombre del alumno");
                string Apellido = Interaction.InputBox("Ingrese el apellido del alumno");
                if (alumnos.Exists(a => a.Legajo == Legajo))
                {
                    MessageBox.Show("El legajo ya está siendo utilizado");
                }
                else
                {
                    Alumnos.Add(new Alumno(Legajo, Nombre, Apellido));
                    MessageBox.Show("Alumno agregado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void EliminarAlumno(int Legajo)
        {
            try
            {
                if (alumnos.Exists(a => a.Legajo == Legajo))
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

        public void ModificarAlumno(int Legajo)
        {
            try
            {
                string NuevoNombre = Interaction.InputBox("Ingrese el nombre del alumno");
                string NuevoApellido = Interaction.InputBox("Ingrese el apellido del alumno");
                if (alumnos.Exists(a => a.Legajo == Legajo))
                {
                    Alumnos.Find(a => a.Legajo == Legajo).Modificar(NuevoNombre, NuevoApellido);
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

        public void Evento_Promedio(int PromedioGeneral)
        {
            if(PromedioGeneral >= 9)
            {
                object o = "El promedio del alumno es :" + PromedioGeneral + " .";
                EventoPromedio?.Invoke(o, new EventArgs());
            }
        }

        public void OrdenarAscendentemente()
        {
            alumnos.Sort(new CompareApellidoAsc());
        }
        public void OrdenarDescendentemente()
        {
            alumnos.Sort(new CompareApellidoDesc());
        }
        class CompareApellidoAsc : IComparer<Alumno>
        {
            public int Compare(Alumno x, Alumno y)
            {
                return x.Apellido.CompareTo(y.Apellido);
            }
        }
        class CompareApellidoDesc : IComparer<Alumno>
        {
            public int Compare(Alumno x, Alumno y)
            {
                return -1 * x.Apellido.CompareTo(y.Apellido);
            }
        }
    }
}
