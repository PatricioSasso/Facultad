using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_5_Facultad
{
    public class Alumno
    {
        private int legajo;
        private string nombre;
        private string apellido;
        private List<Basica> a_basicas;
        private List<Especializada> a_especializadas;

        public Alumno(int legajo, string nombre, string apellido)
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.a_basicas = new List<Basica>();
            this.a_especializadas = new List<Especializada>();
        }

        public int Legajo { get => legajo; }
        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        internal List<Basica> A_basicas { get => a_basicas; }
        internal List<Especializada> A_especializadas { get => a_especializadas; }

        public void Modificar(string nuevoNombre, string nuevoApellido)
        {
            this.nombre = nuevoNombre;
            this.apellido = nuevoApellido;
        }

        public void AgregarMateria(int codigo, string nombre, string tipo)
        {
            if(tipo == "Especializada" && a_especializadas.Exists(m => m.Codigo == codigo))
            {
                MessageBox.Show("El alumno ya está contiene esta materia especializada.");
            }
            else if(tipo == "Especializada")
            {
                A_especializadas.Add(new Especializada(codigo, nombre));
            }
            else if(tipo == "Basica" && a_basicas.Exists(m => m.Codigo == codigo))
            {
                MessageBox.Show("El alumno ya está contiene esta materia básica.");
            }
            else if(tipo == "Basica")
            {
                A_basicas.Add(new Basica(codigo, nombre));
            }
            else
            {
                throw new Exception("El código elegido no pertenece a ninguna materia.");
            }
        }

        public void SacarMateria(int codigo, string tipo)
        {
            Especializada sacare = a_especializadas.Find(m => m.Codigo == codigo);
            Basica sacarb = a_basicas.Find(m => m.Codigo == codigo);
            if (tipo == "Especializada" && sacare == null)
            {
                MessageBox.Show("El alumno no contiene esta materia especializada.");
            }
            else if (tipo == "Especializada")
            {
                A_especializadas.Remove(sacare);
            }
            else if (tipo == "Basica" && sacarb == null)
            {
                MessageBox.Show("El alumno no contiene esta materia básica.");
            }
            else if (tipo == "Basica")
            {
                A_basicas.Remove(sacarb);
            }
            else
            {
                throw new Exception("El código elegido no contiene ninguna materia");
            }
        }

        public void PonerNota(int codigo, int nota, string tipo)
        {
            Especializada e = a_especializadas.Find(m => m.Codigo == codigo);
            Basica b = a_basicas.Find(m => m.Codigo == codigo);
            if (tipo == "Especializada" && e == null)
            {
                MessageBox.Show("El alumno no contiene esta materia especializada.");
            }
            else if (tipo == "Especializada")
            {
                e.ModificarNota(nota);
            }
            else if (tipo == "Basica" && b == null)
            {
                MessageBox.Show("El alumno no contiene esta materia básica.");
            }
            else if (tipo == "Basica")
            {
                b.ModificarNota(nota);
            }
            else
            {
                throw new Exception("El código elegido no contiene ninguna materia");
            }
        }

    }

    public class OrdenarAscendente : IComparer<Alumno>
    {
        public int Compare(Alumno x, Alumno y)
        {
            return x.Apellido.CompareTo(y.Apellido);
        }
    }

    public class OrdenarDescendente : IComparer<Alumno>
    {
        public int Compare(Alumno x, Alumno y)
        {
            return x.Apellido.CompareTo(y.Apellido) * -1;
        }
    }
}
