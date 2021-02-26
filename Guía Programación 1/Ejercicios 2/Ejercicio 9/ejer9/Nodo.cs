using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer9
{
    class Nodo
    {
        public Nodo anterior;
        public Nodo siguiente;
        public Object valor;
        public Nodo(Object a)
        {
            this.valor = a;
        }
    }
}
