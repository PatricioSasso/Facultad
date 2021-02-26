using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoDesconectadoConBdPractica
{
    class Telefono
    {
        public int id;
        public string numero;

        public Telefono(int id, string numero)
        {
            this.id = id;
            this.numero = numero ?? throw new ArgumentNullException(nameof(numero));
        }
    }
}
