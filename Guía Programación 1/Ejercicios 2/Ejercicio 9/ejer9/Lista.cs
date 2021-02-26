using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer9
{
    class Lista
    {
        public Nodo principal;
        public Nodo ultimo;
        public int size;
        public Lista()
        {
            this.size = 0;
        }

        public Boolean listavacia()
        {
            if (size == 0)
            { return true; }
            else { return false; }
        }


        public void agregaralfinal(Object a)
        {
            Nodo nuevo = new Nodo(a);
            if (listavacia() == true)
            {
                this.principal = nuevo;
                this.ultimo = nuevo;
                this.ultimo.siguiente = principal;
                size++;
            }
            else
            {
                this.ultimo = nuevo;
                this.ultimo.siguiente = principal;
                size++;
            }
        }

        public void agregaralprincipio(Object a)
        {
            Nodo nuevo = new Nodo(a);
            if (listavacia() == true)
            {
                this.principal = nuevo;
                this.ultimo = nuevo;
                this.ultimo.siguiente = principal;
                size++;

            }
            else
            {
                Nodo temp;
                temp = this.principal;
                this.principal = nuevo;
                this.principal.siguiente = temp;
            }
        }

        public void agregarenn(Object a, int b)
        {
            Nodo nuevoo = new Nodo(a);
            if (b == 0)
            {
                agregaralprincipio(a);
            }
            else
            {
                Nodo enc = buscarnodo(b - 1);
                Nodo nuevo = new Nodo(a);
                Nodo temp = enc.siguiente;
                enc.siguiente = nuevo;
                nuevo.siguiente = temp;
                size++;
            }
        }

        public void sacarultimo()
        {
            if (buscarnodo(size - 1) != null)
            {
                Nodo anterior = buscarnodo(size - 1);
                anterior.siguiente = null;
                size--;
            }

            this.ultimo = null;
            size--;
        }

        public void sacarprimero()
        {
            if (principal.siguiente != null)
            {
                this.principal = buscarnodo(1);
                this.size--;
            }
            else
            {
                this.principal = principal.siguiente;
                size--;
            }
        }

        public void sacarenn(int b)
        {
            if (b == 0)
            {
                sacarprimero();
            }
            else
            {
                Nodo enc = buscarnodo(b - 1);
                Nodo temp = buscarnodo(b + 1);
                enc.siguiente = temp;
                size--;
            }
        }

        public void vaciar()
        {
            this.principal.siguiente = null;
            size = 0;
        }

        public void cambiarder(int a)
        {
            Nodo prin = buscarnodo(a);
            Nodo ant = buscarnodo(a - 1);
            Nodo post = buscarnodo(a + 1);
            Nodo temp = post.siguiente;
            ant.siguiente = post;
            post.siguiente = prin;
            prin.siguiente = temp;
        }
        public void cambiarizq(int a)
        {
            Nodo prin = buscarnodo(a);
            Nodo ant = buscarnodo(a - 1);
            Nodo ant2 = buscarnodo(a - 2);
            Nodo temp = prin.siguiente;
            ant2.siguiente = prin;
            prin.siguiente = ant;
            ant.siguiente = temp;
        }

        public Nodo buscarnodo(int pos)
        {
            Nodo encontrado = principal;
            if (pos > size)
            {
                throw new Exception("El número elegido excede del límite");
            }
            else
            {
                int i;
                for (i = 0; i < pos; i++)
                {
                    Nodo sig = encontrado.siguiente;
                    encontrado = sig;
                }
            }
            return encontrado;
        }
    }
}
