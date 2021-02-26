using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejer14
{
    class Lista
    {
        public Nodo principal;
        public Nodo ultimo;
        public int size;
        public void lista()
        {
            this.size = 0;
        }

        public Boolean listavacia()
        {
            if (size == 0)
            { return true; }
            else { return false; }
        }


        public void agregaralfinal(int a, int b)
        {
            Nodo nuevo = new Nodo(a, b);
            if (listavacia() == true)
            {
                this.principal = nuevo;
                this.ultimo = nuevo;
                size++;
            }
            else if (principal.siguiente == null)
            {
                this.principal.siguiente = nuevo;
                this.ultimo = nuevo;
                size++;
            }
            else
            {
                this.ultimo = nuevo;
                size++;
            }
        }

        public void agregaralprincipio(int a, int b)
        {
            Nodo nuevo = new Nodo(a, b);
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
                size++;
            }
        }

        public void agregarenn(int a, int b, int c)
        {
            Nodo nuevoo = new Nodo(a, b);
            if (c == 0)
            {
                agregaralprincipio(a, b);
            }
            else
            {
                Nodo enc = buscarnodo(c - 1);
                Nodo nuevo = new Nodo(a, b);
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
                this.principal = buscarnodo(0);
                this.size--;
            }
            else
            {
                this.principal = principal.siguiente;
                size--;
            }
        }

        public void sacarenn(int c)
        {
            if (c == 0)
            {
                sacarprimero();
            }
            else
            {
                Nodo enc = buscarnodo(c - 1);
                Nodo temp = buscarnodo(c + 1);
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
                MessageBox.Show("El número elegido excede del límite");
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

        public void ordenar(Lista L)
        {
            if (L.size > 1)
            {
                for (int i = 0; i < L.size; i++)
                {
                    for (int j = 0; j < L.size; j++)
                    {
                        Nodo a = buscarnodo(i);
                        Nodo b = buscarnodo(j + 1);
                        if (a != null && b != null)
                        {
                            if (a.nro > b.nro)
                            {
                                Nodo temp = a;
                                a = b;
                                b = temp;
                            }
                        }
                    }
                }
            }
        }

        public int MenosTareas(Lista L, int size)
        {
            int[] vl = new int[size];
            if (L.size > 1)
            {
                for (int i = 0; i < L.size; i++)
                {
                    vl[i] = buscarnodo(i).cant;
                }
                int min = vl[0];
                int menor = 0;
                for (int i = 0; i < L.size; i++)
                {
                    for (int j = 0; j < L.size; j++)
                    {
                        if (vl[i] < min)
                        {
                            min = vl[i];
                            menor = i;
                        }
                    }
                }
                return menor;
            }
            return 0;
        }

        public int MasTareas(Lista L, int size)
        {
            int[] vl = new int[size];
            if (L.size > 1)
            {
                for (int i = 0; i < L.size; i++)
                {
                    vl[i] = buscarnodo(i).cant;
                }
                int max = vl[0];
                int mayor = 0;
                for (int i = 0; i < L.size; i++)
                {
                    for (int j = 0; j < L.size; j++)
                    {
                        if (vl[i] > max)
                        {
                            max = vl[i];
                            mayor = i;
                        }
                    }
                }
                return mayor;
            }
            return 0;
        }
    }
    class Nodo
    {
        public int nro;
        public int cant;
        public Nodo siguiente;
        public Nodo(int a, int b)
        {
            this.nro = a;
            this.cant = b;

        }
    }
}
