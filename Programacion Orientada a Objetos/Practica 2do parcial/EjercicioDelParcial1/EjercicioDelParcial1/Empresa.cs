using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioDelParcial1
{
    class Empresa
    {
        List<Cliente> clientes;
        List<Contenedor> contenedores;

        public Empresa()
        {
            Clientes = new List<Cliente>();
            Contenedores = new List<Contenedor>();
        }

        internal List<Cliente> Clientes { get => clientes; set => clientes = value; }
        internal List<Contenedor> Contenedores { get => contenedores; set => contenedores = value; }

        #region ABM Clientes
        public void AltaCliente(string legajo, string nombre, string apellido, int tipo)
        {
            if(clientes.Exists(c => c.Legajo == legajo))
            {
                MessageBox.Show("El legajo ya está siendo utilizado por otro cliente.");
            }
            else
            {
                if(tipo == 0)
                {
                    clientes.Add(new Comun(legajo, nombre, apellido));
                }
                else
                {
                    clientes.Add(new Especial(legajo, nombre, apellido));
                }
            }
        }

        public void ModificarCliente(string legajo, string Nnombre, string Napellido)
        {
            Cliente modificar = clientes.Find(c => c.Legajo == legajo);
            if (modificar == null)
            {
                MessageBox.Show("El legajo no existe.");
            }
            else
            {
                if (modificar is Comun c)
                {
                    c.Modificar(Nnombre, Napellido);
                }
                else if (modificar is Especial e)
                {
                    e.Modificar(Nnombre, Napellido);
                }
                else
                {
                    MessageBox.Show("Error bro");
                }
            }
        }

        public void EliminarCliente(string legajo)
        {
            Cliente eliminar = clientes.Find(c => c.Legajo == legajo);
            if (eliminar == null)
            {
                MessageBox.Show("El legajo no existe.");
            }
            else
            {
                clientes.Remove(eliminar);
            }
        }
        #endregion

        #region ABM Contenedores
        public void AltaContenedor(string id, string descripcion, DateTime fecha, decimal peso)
        {
            if (contenedores.Exists(c => c.Id == id))
            {
                MessageBox.Show("El id ya está siendo utilizado por otro contenedor.");
            }
            else
            {
                contenedores.Add(new Contenedor(id, descripcion, fecha, peso));
            }
        }

        public void ModificarContenedor(string id, string Ndescripción, DateTime Nfecha, decimal Npeso)
        {
            Contenedor modificar = contenedores.Find(c => c.Id == id);
            if (modificar == null)
            {
                MessageBox.Show("El contenedor no existe.");
            }
            else
            {
                modificar.Modificar(Ndescripción, Nfecha, Npeso);
            }
        }

        public void EliminarContenedor(string id)
        {
            Contenedor eliminar = contenedores.Find(c => c.Id == id);
            if (eliminar == null)
            {
                MessageBox.Show("El legajo no existe.");
            }
            else
            {
                contenedores.Remove(eliminar);
            }
        }
        #endregion

        public void OrdenarApellidosAsc()
        {
            Clientes.Sort(new OrdenarClientesPorApellidoAscendentemente());
        }

        public void OrdenarApellidosDesc()
        {
            Clientes.Sort(new OrdenarClientesPorApellidoDescendentemente());
        }
    }

    public class OrdenarClientesPorApellidoAscendentemente : IComparer<Cliente>
    {
        public int Compare(Cliente x, Cliente y)
        {
            return x.Apellido.CompareTo(y.Apellido);
        }
    }

    public class OrdenarClientesPorApellidoDescendentemente : IComparer<Cliente>
    {
        public int Compare(Cliente x, Cliente y)
        {
            return -1 * x.Apellido.CompareTo(y.Apellido);
        }
    }

}
