using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer10
{
    class Nodo
    {
        public Object valor;
        public Nodo anterior;
        public Nodo siguiente;
        public Nodo(Object a)
        {
            valor = a;
        }
    }
}
