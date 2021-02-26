using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer11
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


        public void agregaralfinal(string n, string a, int e, int p, string s)
        {
            Nodo nuevo = new Nodo(n,a,e,p,s);
            if (listavacia() == true)
            {
                this.principal = nuevo;
                this.ultimo = nuevo;
                size++;
            }
            else
            {
                this.ultimo = nuevo;
                size++;
            }
        }

        public void agregaralprincipio(string n, string a, int e, int p, string s)
        {
            Nodo nuevo = new Nodo(n,a,e,p,s);
            if (listavacia() == true)
            {
                this.principal = nuevo;
                this.ultimo = nuevo;
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

        public void agregarenn(string n, string a, int e, int p, string s, int d2)
        {
            if (d2 == 0)
            {
                agregaralprincipio(n, a, e, p, s);
            }
            else
            {
                Nodo enc = buscarnodo(d2 - 1);
                Nodo nuevo = new Nodo(n, a, e, p, s);
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

        public void sacarenn(int d)
        {
            if (d == 0)
            {
                sacarprimero();
            }
            else
            {
                Nodo enc = buscarnodo(d - 1);
                Nodo temp = buscarnodo(d + 1);
                enc.siguiente = temp;
                size--;
            }
        }

        public void vaciar()
        {
            this.principal.siguiente = null;
            size = 0;
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

    class Nodo 
    {
        public string Nombre;
        public string Apellido;
        public int Edad;
        public int Peso;
        public string Sexo;
        public Nodo siguiente;
        public Nodo(string n, string a, int e, int p, string s)
        {
            this.Nombre = n;
            this.Apellido = a;
            this.Edad = e;
            this.Peso = p;
            this.Sexo = s;
        }
    }
}
