using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejer12
{
    class lista
    {
        public Nodo principal;
        public Nodo ultimo;
        public int size;
        public void Lista()
        {
            this.size = 0;
        }

        public Boolean listavacia()
        {
            if (size == 0)
            { return true; }
            else { return false; }
        }


        public void agregaralfinal(string a, int b, decimal c, string d)
        {
            Nodo nuevo = new Nodo(a, b, c, d);
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

        public void agregaralprincipio(string a, int b, decimal c, string d)
        {
            Nodo nuevo = new Nodo(a, b, c, d);
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

        public void agregarenn(string a, int b, decimal c, string d, int e)
        {
            Nodo nuevoo = new Nodo(a, b, c, d);
            if (e == 0)
            {
                agregaralprincipio(a, b, c, d);
            }
            else
            {
                Nodo enc = buscarnodo(e - 1);
                Nodo nuevo = new Nodo(a, b, c, d);
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

        public void sacarenn(int e)
        {
            if (e == 0)
            {
                sacarprimero();
            }
            else
            {
                Nodo enc = buscarnodo(e - 1);
                Nodo temp = buscarnodo(e + 1);
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

        public void ordenar(lista L)
        {
            if (L.size > 1)
            {
                for (int i = 0; i < L.size; i++)
                {
                    for (int j = 0; j < L.size; j++)
                    {
                        Nodo a = buscarnodo(i);
                        Nodo b = buscarnodo(j + 1);
                        int c = int.Parse(a.fecha.Split('-')[0]);
                        int e = int.Parse(b.fecha.Split('-')[0]);
                        if (a != null && b != null)
                        {
                            if (int.Parse(a.fecha.Split('-')[0]) > int.Parse(b.fecha.Split('-')[0]))
                            {
                                Nodo temp = a;
                                a = b;
                                b = temp;
                            }
                            if (int.Parse(a.fecha.Split('-')[1]) > int.Parse(b.fecha.Split('-')[1]))
                            {
                                Nodo temp = a;
                                a = b;
                                b = temp;
                            }
                            if (int.Parse(a.fecha.Split('-')[2]) > int.Parse(b.fecha.Split('-')[2]))
                            {
                                Nodo temp = a;
                                a = b;
                                b = temp;
                            }
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
    }
    class Nodo
    {
        public string fecha;
        public int nro;
        public decimal monto;
        public string tipo;
        public Nodo siguiente;
        public Nodo(string a, int b, decimal c, string d)
        {
            this.fecha = a;
            this.nro = b;
            this.monto = c;
            this.tipo = d;
        }
    }
}
