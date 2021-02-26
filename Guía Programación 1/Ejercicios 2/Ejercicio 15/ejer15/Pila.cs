using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer15
{
    class Pila
    {
        public int cima;
        public int maximo;
        public int[] vector= new int[100];

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

        public void eliminar()
        {
            if (pilavacia() == false)
            {
                vector[cima] = 0;
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
    }
}
