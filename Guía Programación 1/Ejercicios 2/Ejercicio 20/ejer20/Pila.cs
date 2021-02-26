using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer20
{
    class Pila
    {
        public int cima;
        public int maximo;
        public int[] vector = new int[100];

        public Boolean pilavacia()
        {
            if (cima == -1)
            {
                return true;
            }
            else { return false; }
        }
        public int agregar(int n)
        {
            if (pilavacia() == true)
            {
                vector[0] = n;
                cima = n;
            }
            else
            {
                cima++;
                vector[cima] = n;
            }
            return n;
        }
    }
}
