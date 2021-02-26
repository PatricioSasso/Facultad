using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer18
{
    class pila
    {
        public int cima = -1;
        public int maximo;
        public char[] vector = new char[999];

        public Boolean pilavacia()
        {
            if (cima == -1)
            {
                return true;
            }
            else { return false; }
        }
        public Boolean pilallena()
        {
            if (cima == maximo)
            {
                return true;
            }
            else { return false; }
        }

        public int agregar(char n)
        {
            if (pilavacia() == true)
            {
                cima++;
                vector[0] = n;
            }
            else
            {
                cima++;
                vector[cima] = n;
            }
            return n;
        }

        public void eliminar()
        {
            if (pilavacia() == false)
            {
                cima--;
            }
        }

        public int ver()
        {
            if (pilavacia() == false)
            {
                return vector[cima];
            }
            else { return 0; }
        }

        public void vaciar()
        {
            cima = -1;
        }
    }
}
