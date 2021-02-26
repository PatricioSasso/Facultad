using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Epersona
    {
        public Epersona() { }
        public Epersona(int pId, string pNombre,string pApellido) { id = pId;Nombre = pNombre;Apellido = pApellido; }
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

    }
}
