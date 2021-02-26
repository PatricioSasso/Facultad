using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaAdoDesconecta2ConBD2
{
    class Alumno
    {
        public int legajo;
        public string nombre;
        public string apellido;
        public DateTime fecha_ingreso;
        public bool activo;

        public Alumno(int legajo, string nombre, string apellido, DateTime fecha_ingreso, bool activo)
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido ;
            this.fecha_ingreso = fecha_ingreso;
            this.activo = activo;
        }
    }

    class Telefono
    {
        public int id;
        public string numero;

        public Telefono(int id, string numero)
        {
            this.id = id;
            this.numero = numero;
        }
    }


}
