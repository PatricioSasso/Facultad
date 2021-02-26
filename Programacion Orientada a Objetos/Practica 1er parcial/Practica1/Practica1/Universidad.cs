using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Practica1
{
    class Universidad
    {
        private List<Alumno> alumnos;

        public event EventHandler Promedio10;

        public Universidad(List<Alumno> alumnos)
        {
            this.alumnos = alumnos;
        }

        public Universidad()
        {
            this.alumnos = new List<Alumno>();
        }

        public List<Alumno> Alumnos { get => this.alumnos; }

        public void InscribirAlumno(int legajo, string nombre, string apellido, decimal promedio)
        {
            if (alumnos.Exists(a => a.Legajo == legajo) == false)
            {
                alumnos.Add(new Alumno(legajo, nombre, apellido, promedio));
                MessageBox.Show("Alumno inscripto");
                if (promedio == 10) { Promedio10?.Invoke(this, null); }
            }
            else
            {
                MessageBox.Show("El legajo ya está siendo utilizado");
            }
        }

        public void ModificarAlumno(int legajo, string nuevoNombre, string nuevoApellido, decimal nuevoPromedio)
        {
            Alumno buscar = alumnos.Find(a => a.Legajo == legajo);
            if (buscar != null)
            {
                buscar.Modificar(nuevoNombre, nuevoApellido, nuevoPromedio);
                MessageBox.Show("Alumno modificado");
                if (nuevoPromedio == 10) { Promedio10?.Invoke(this, null); }
            }
            else
            {
                MessageBox.Show("El legajo elegido no existe");
            }
        }

        public void DesinscribirAlumno(int legajo)
        {
            Alumno buscar = alumnos.Find(a => a.Legajo == legajo);
            if (buscar != null)
            {
                alumnos.Remove(buscar);
                MessageBox.Show("Alumno desinscripto");
            }
            else
            {
                MessageBox.Show("El legajo elegido no existe");
            }
        }

        #region IComparer

        public void OrdenarAscPorApellido()
        {
            alumnos.Sort(new CompararApellidosAsc());
        }

        public void OrdenarPorDescApellido()
        {
            alumnos.Sort(new CompararApellidosDesc());
        }

        public class CompararApellidosAsc : IComparer<Alumno>
        {
            public int Compare(Alumno x, Alumno y)
            {
                return x.Apellido.CompareTo(y.Apellido);
            }
        }

        public class CompararApellidosDesc : IComparer<Alumno>
        {
            public int Compare(Alumno x, Alumno y)
            {
                return x.Apellido.CompareTo(y.Apellido) * -1;
            }
        }

        #endregion
    }
}
