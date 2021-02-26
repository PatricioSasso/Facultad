using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesconectadoPractica3
{
    class Persona
    {
        public int codigo;
        public string nombre;
        public string apellido;

        public Persona(int codigo, string nombre, string apellido)
        {
            this.codigo = codigo;
            this.nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            this.apellido = apellido ?? throw new ArgumentNullException(nameof(apellido));
        }
    }

    class Telefono
    {
        public int codigo;
        public string numero;

        public Telefono(int codigo, string numero)
        {
            this.codigo = codigo;
            this.numero = numero ?? throw new ArgumentNullException(nameof(numero));
        }
    }
}
