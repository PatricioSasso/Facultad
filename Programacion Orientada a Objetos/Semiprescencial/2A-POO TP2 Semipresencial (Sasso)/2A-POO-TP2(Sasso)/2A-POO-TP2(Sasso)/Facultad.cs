using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2A_POO_TP2_Semipresencial__Sasso_
{
    class Facultad
    {
        List<Alumno> alumnos;
        List<Materia> materias;

        public List<Alumno> Alumnos { get => alumnos; }
        public List<Materia> Materias { get => materias; }

        public void AgregarAlumno(int Legajo, string Nombre, string Apellido)
        {
            if(alumnos.Exists(a => a.Legajo != Legajo))
            {
               Alumnos.Add(new Alumno(Legajo, Nombre, Apellido));
                MessageBox.Show("Alumno agregado");
            }
            else
            {
                MessageBox.Show("El legajo ya está siendo utilizado");
            }
        }

        public void EliminarAlumno(int Legajo)
        {
            if(alumnos.Exists(a => a.Legajo == Legajo))
            {
                Alumnos.Remove(Alumnos.Find(a => a.Legajo == Legajo));
                MessageBox.Show("Alumno eliminado");
            }
            else
            {
                MessageBox.Show("No existe ningún alumno con ese legajo");
            }
        }

        public void ModificarAlumno(int Legajo , string NuevoNombre, string NuevoApellido)
        {
            if (alumnos.Exists(a => a.Legajo == Legajo))
            {
                Alumnos.Find(a => a.Legajo == Legajo).Modify(NuevoNombre, NuevoApellido);
                MessageBox.Show("Alumno modificado");
            }
            else
            {
                MessageBox.Show("No existe ningún alumno con ese legajo");
            }
        }
    }
}
