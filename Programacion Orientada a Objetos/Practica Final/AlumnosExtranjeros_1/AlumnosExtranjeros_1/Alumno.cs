using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlumnosExtranjeros_1
{
    public class Alumno
    {
        int identificador;
        string nombre;
        string apellido;
        List<Telefono> telefonos;

        public Alumno(int identificador, string nombre, string apellido)
        {
            this.identificador = identificador;
            this.nombre = nombre;
            this.apellido = apellido;
            telefonos = new List<Telefono>();
        }

        public int Identificador { get => identificador; set => identificador = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        internal List<Telefono> Telefonos { get => telefonos; set => telefonos = value; }

        public void Modificar(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public void AgregarTelefono(Telefono telefono)
        {
            if(telefono.Usado == false)
            {
                telefonos.Add(telefono);
                telefono.EnUso();
            }
            else
            {
                MessageBox.Show("El teléfono ya se encuentra en uso");
            }
        }
    }

    public class Extranjero : Alumno
    {
        string u_Origen;
        int e_MateriasAprobadas;

        public Extranjero(int identificador, string nombre, string apellido, string u_Origen, int e_MateriasAprobadas) : base(identificador, nombre, apellido)
        {
            this.u_Origen = u_Origen;
            this.e_MateriasAprobadas = e_MateriasAprobadas;
        }

        public string U_Origen { get => u_Origen; set => u_Origen = value; }
        public int E_MateriasAprobadas { get => e_MateriasAprobadas; set => e_MateriasAprobadas = value; }

        public void Modificar(string nombre, string apellido, string u_Origen, int e_MateriasAprobadas)
        {
            base.Modificar(nombre, apellido);
            this.u_Origen = u_Origen;
            this.e_MateriasAprobadas = e_MateriasAprobadas;
        }

    }
}
