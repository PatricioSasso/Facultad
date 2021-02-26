using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoDesconectadoConBdPractica
{
    class Alumno
    {
        public int Legajo;
        public string Nombre;
        public string Apellido;
        public DateTime FechaIngreso;
        public bool Activo;
        public List<Telefono> ATelefonos;

        public Alumno(int legajo, string nombre, string apellido, DateTime fechaIngreso, bool activo)
        {
            Legajo = legajo;
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            Apellido = apellido ?? throw new ArgumentNullException(nameof(apellido));
            FechaIngreso = fechaIngreso;
            Activo = activo;
            ATelefonos = new List<Telefono>();
        }

        public void AgregarTelefono(Telefono telefono)
        {
            ATelefonos.Add(telefono);
        }

        public void EliminarTelefono(Telefono telefono)
        {
            ATelefonos.Add(telefono);
        }
    }
}
