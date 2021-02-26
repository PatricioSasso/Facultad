using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_5_Facultad
{
    class Facultad
    {
        private List<Alumno> alumnos;
        private List<Basica> basicas;
        private List<Especializada> especializadas;

        public event EventHandler PromedioMayorOIguala9;

        public Facultad()
        {
            this.alumnos = new List<Alumno>();
            this.basicas = new List<Basica>();
            this.especializadas = new List<Especializada>();
        }

        internal List<Basica> Basicas { get => basicas; }
        internal List<Especializada> Especializadas { get => especializadas; }
        internal List<Alumno> Alumnos { get => alumnos; }

        #region ABM Alumno

        public void AltaAlumno(int legajo, string nombre, string apellido)
        {
            if(alumnos.Exists(a => a.Legajo == legajo))
            {
                MessageBox.Show("El legajo está siendo utilizado");
            }
            else
            {
                alumnos.Add(new Alumno(legajo, nombre, apellido));
            }
        }

        public void ModificarAlumno(int legajo, string nuevoNombre, string nuevoApellido)
        {
            Alumno modificar = alumnos.Find(a => a.Legajo == legajo);
            if (modificar == null)
            {
                MessageBox.Show("No existe ningún alumno bajo ese legajo");
            }
            else
            {
                modificar.Modificar(nuevoNombre, nuevoApellido);
            }
        }

        public void BajaAlumno(int legajo)
        {
            Alumno baja = alumnos.Find(a => a.Legajo == legajo);
            if (baja == null)
            {
                MessageBox.Show("No existe ningún alumno bajo ese legajo");
            }
            else
            {
                alumnos.Remove(baja);
            }
        }

        #endregion

        #region ABM Basica

        public void AltaBasica(int codigo, string nombre)
        {
            if (basicas.Exists(b => b.Codigo == codigo))
            {
                MessageBox.Show("El código está siendo utilizado");
            }
            else
            {
                basicas.Add(new Basica(codigo, nombre));
            }
        }

        public void ModificarBasica(int codigo, string nuevoNombre)
        {
            Basica modificar = basicas.Find(b => b.Codigo == codigo);
            if (modificar == null)
            {
                MessageBox.Show("No existe ninguna materia básica bajo ese código");
            }
            else
            {
                modificar.Modificar(nuevoNombre);
            }
        }

        public void BajaBasica(int codigo)
        {
            Basica baja = basicas.Find(b => b.Codigo == codigo);
            if (baja == null)
            {
                MessageBox.Show("No existe ninguna materia básica bajo ese código");
            }
            else
            {
                basicas.Remove(baja);
            }
        }

        #endregion

        #region ABM Especializada

        public void AltaEspecializada(int codigo, string nombre)
        {
            if (especializadas.Exists(e => e.Codigo == codigo))
            {
                MessageBox.Show("El código está siendo utilizado");
            }
            else
            {
                especializadas.Add(new Especializada(codigo, nombre));
            }
        }

        public void ModificarEspecializada(int codigo, string nuevoNombre)
        {
            Especializada modificar = especializadas.Find(e => e.Codigo == codigo);
            if (modificar == null)
            {
                MessageBox.Show("No existe ninguna materia especializada bajo ese código");
            }
            else
            {
                modificar.Modificar(nuevoNombre);
            }
        }

        public void BajaEspecializada(int codigo)
        {
            Especializada baja = especializadas.Find(e => e.Codigo == codigo);
            if (baja == null)
            {
                MessageBox.Show("No existe ninguna materia especializada bajo ese código");
            }
            else
            {
                especializadas.Remove(baja);
            }
        }

        #endregion

        public void LlamarEvento()
        {
            PromedioMayorOIguala9?.Invoke(this, null);
        }
    }
}
