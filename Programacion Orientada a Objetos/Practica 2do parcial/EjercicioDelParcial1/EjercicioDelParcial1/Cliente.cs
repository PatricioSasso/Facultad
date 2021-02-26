using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioDelParcial1
{
    public class Cliente
    {
        string legajo;
        string nombre;
        string apellido;
        List<Contenedor> cliente_contenedores;

        public Cliente(string legajo, string nombre, string apellido)
        {
            this.Legajo = legajo;
            this.Nombre = nombre;
            this.Apellido = apellido;
            Cliente_contenedores = new List<Contenedor>();
        }

        public string Legajo { get => legajo; set => legajo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        internal List<Contenedor> Cliente_contenedores { get => cliente_contenedores; set => cliente_contenedores = value; }

        public void Modificar(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public virtual void Despachar(Contenedor contenedor)
        {
            if(contenedor.Despachado == false)
            {
                contenedor.Despachar();
                cliente_contenedores.Add(contenedor);
            }
            else
            {
                MessageBox.Show("El contenedor ya fue despachado por otro cliente.");
            }

        }
    }

    class Comun : Cliente
    {
        public static EventHandler<EventoDespachar> EventoDespachar;

        public Comun(string legajo, string nombre, string apellido) : base(legajo, nombre, apellido)
        {

        }

        public override void Despachar(Contenedor contenedor)
        {
            if (Cliente_contenedores.Count > 2)
            {
                EventoDespachar.Invoke(this, new EventoDespachar(contenedor));
            }
            else
            {
                base.Despachar(contenedor);
            }
        }
    }

    class Especial : Cliente
    {
        public Especial(string legajo, string nombre, string apellido) : base(legajo, nombre, apellido)
        {

        }
    }

    public class EventoDespachar : EventArgs
    {
        Contenedor contenedor;

        public EventoDespachar(Contenedor contenedor)
        {
            this.Contenedor = contenedor;
        }

        public Contenedor Contenedor { get => contenedor; set => contenedor = value; }

        public string Mensaje()
        {
            return "Id: "+ contenedor.Id + 
                   "\r\nDescripción: " + contenedor.Descripcion + 
                   "\r\nFecha de Vencimiento" + contenedor.Fecha + 
                   "\r\nPeso: " + contenedor.Peso + ".";
        }
    }

}
