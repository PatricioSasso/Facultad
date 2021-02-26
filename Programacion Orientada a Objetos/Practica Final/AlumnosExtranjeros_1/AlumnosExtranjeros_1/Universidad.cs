using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace AlumnosExtranjeros_1
{
    class Universidad
    {
        List<Alumno> alumnos;
        List<Telefono> telefonos;

        public Universidad()
        {
            this.alumnos = new List<Alumno>();
            this.telefonos = new List<Telefono>();
        }

        public event EventHandler<EventoTelefonos> Evento;

        internal List<Alumno> Alumnos { get => alumnos; set => alumnos = value; }
        internal List<Telefono> Telefonos { get => telefonos; set => telefonos = value; }

        #region ABM Alumnos

        public void AltaAlumno(int identificador, bool extranjero)
        {
            if(alumnos.Exists(a => a.Identificador == identificador))
            {
                MessageBox.Show("El legajo o dni se encuentra en uso.");
            }
            else
            {
                string nombre = Interaction.InputBox("Ingrese el nombre del alumno");
                string apellido = Interaction.InputBox("Ingrese el apellido del alumno");
                if(extranjero == true)
                {
                    string origen = Interaction.InputBox("Ingrese la universidad de origen del alumno");
                    int materiasAprobadas = int.Parse(Interaction.InputBox("Ingrese la cantidad de materias aprobadas por el alumno en el extrnajero"));
                    Extranjero nuevo = new Extranjero(identificador, nombre, apellido, origen, materiasAprobadas);
                    alumnos.Add(nuevo);
                }
                else
                {
                    alumnos.Add(new Alumno(identificador, nombre, apellido));
                }
            }
        }

        public void ModificacionAlumno(int identificador)
        {
            Alumno modificar = alumnos.Find(a => a.Identificador == identificador);
            if (modificar == null)
            {
                MessageBox.Show("El id seleccionado no existe");
            }
            else
            {
                string nombre = Interaction.InputBox("Ingrese el nombre del alumno");
                string apellido = Interaction.InputBox("Ingrese el apellido del alumno");
                if (modificar is Extranjero)
                {
                    Extranjero ext = (Extranjero)modificar;
                    string origen = Interaction.InputBox("Ingrese la universidad de origen del alumno");
                    int materiasAprobadas = int.Parse(Interaction.InputBox("Ingrese la cantidad de materias aprobadas por el alumno en el extrnajero"));
                    ext.Modificar(nombre, apellido, origen, materiasAprobadas);
                }
                else
                {
                    modificar.Modificar(nombre, apellido);
                }
            }
        }

        public void BajaAlumno(int identificador)
        {
            Alumno eliminar = alumnos.Find(a => a.Identificador == identificador);
            if(eliminar == null)
            {
                MessageBox.Show("El id seleccionado no existe");
            }
            else
            {
                alumnos.Remove(eliminar);
            }
        }

        #endregion

        #region ABM Telefonos
        public void AltaTelefono(int id)
        {
            if (telefonos.Exists(t => t.Id == id))
            {
                MessageBox.Show("El teléfono ya existe");
            }
            else
            {
                int numero = int.Parse(Interaction.InputBox("Ingrese el número de teléfono"));
                telefonos.Add(new Telefono(id, numero, false));
            }
        }

        public void ModificarTelefono(int id)
        {
            Telefono modificar = telefonos.Find(t => t.Id == id);
            if(modificar == null)
            {
                MessageBox.Show("El teléfono no existe");
            }
            else
            {
                int numero = int.Parse(Interaction.InputBox("Ingrese el número de teléfono"));
                modificar.Modificar(numero);
            }
        }

        public void BajaTelefono(int id)
        {
            Telefono eliminar = telefonos.Find(t => t.Id == id);
            if (eliminar == null)
            {
                MessageBox.Show("El teléfono no existe");
            }
            else
            {
                telefonos.Remove(eliminar);
            }
        }

        #endregion

        public void AgregarTelefonoAAlumno(int identificador, int id)
        {
            Alumno alumno = alumnos.Find(a => a.Identificador == identificador);
            Telefono telefono = telefonos.Find(t => t.Id == id);
            if( alumno != null && telefono != null)
            {
                if (alumno.Telefonos.Count >= 1)
                {
                    Evento.Invoke(this, new EventoTelefonos(telefono));
                    return;
                }
                alumno.AgregarTelefono(telefono);
            }
            else
            {
                MessageBox.Show("El identificador o el teléfono seleccionado es incorrecto");
            }
        }

        public void OrdenarPorApellidoAsc()
        {
            alumnos.Sort(new OrdenarAlumnosAsc());
        }

        public void OrdenarPorApellidoDesc()
        {
            alumnos.Sort(new OrdenarAlumnosDesc());
        }

    }

    public class EventoTelefonos : EventArgs
    {
        Telefono telefono;

        public EventoTelefonos(Telefono telefono)
        {
            this.Telefono = telefono;
        }

        public Telefono Telefono { get => telefono; set => telefono = value; }
    }

    public class OrdenarAlumnosAsc : IComparer<Alumno>
    {
        public int Compare(Alumno x, Alumno y)
        {
            return x.Apellido.CompareTo(y.Apellido);
        }
    }

    public class OrdenarAlumnosDesc : IComparer<Alumno>
    {
        public int Compare(Alumno x, Alumno y)
        {
            return -1 * x.Apellido.CompareTo(y.Apellido);
        }
    }
}
