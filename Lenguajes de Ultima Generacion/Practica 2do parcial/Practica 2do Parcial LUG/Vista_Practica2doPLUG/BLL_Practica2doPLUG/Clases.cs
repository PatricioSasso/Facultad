using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Practica2doPLUG
{
    public class Inmueble
    {
        string id;
        string direccion;
        double valor;
        DateTime fechaPublicacion;
        DateTime fechaVenta;

        public Inmueble(string id, string direccion, double valor, DateTime fechaPublicacion, DateTime fechaVenta)
        {
            this.id = id;
            this.direccion = direccion ?? throw new ArgumentNullException(nameof(direccion));
            this.valor = valor;
            this.fechaPublicacion = fechaPublicacion;
            this.fechaVenta = fechaVenta;
        }

        public string Id { get => id; set => id = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public double Valor { get => valor; set => valor = value; }
        public DateTime FechaPublicacion { get => fechaPublicacion; set => fechaPublicacion = value; }
        public DateTime FechaVenta { get => fechaVenta; set => fechaVenta = value; }
    }

    public class Inmobiliaria
    {
        int id;
        string nombre;
        double totalRecaudado;
        List<Inmueble> inmuebles;
        public static EventHandler<EventoTotalRecaudadoMayorQue1Millon> Evento;

        public Inmobiliaria(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
            TotalRecaudado = 0;
            Inmuebles = new List<Inmueble>();
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double TotalRecaudado { get => totalRecaudado; set => totalRecaudado = value; }
        public List<Inmueble> Inmuebles { get => inmuebles; set => inmuebles = value; }

        public double CalcularTotalRecaudado()
        {
            double total = 0;
            if (Inmuebles != null)
            {
                foreach (Inmueble i in Inmuebles)
                {
                    total += i.Valor;
                }
            }
            if (total >= 1000000)
            {
                Evento.Invoke(this, new EventoTotalRecaudadoMayorQue1Millon(this));
            }
            TotalRecaudado = total;
            return total;
        }

        public void AgregarInmueble(Inmueble i)
        {
            Inmuebles.Add(i);
            CalcularTotalRecaudado();
        }

        public void SacarInmueble(Inmueble i)
        {
            Inmuebles.Remove(i);
            CalcularTotalRecaudado();
        }
    }

    public class EventoTotalRecaudadoMayorQue1Millon : EventArgs
    {
        Inmobiliaria i;

        public EventoTotalRecaudadoMayorQue1Millon(Inmobiliaria inmobiliaria)
        {
            I = inmobiliaria;
        }

        public Inmobiliaria I { get => i; set => i = value; }

        public string Mensaje()
        {
            return $"Id: {i.Id} , Nombre: {i.Nombre} .";
        }
    }

    public class VistaInmobiliaria
    {
        int id;
        string nombre;
        double totalRecaudado;

        public VistaInmobiliaria(int id, string nombre, double totalRecaudado)
        {
            Id = id;
            Nombre = nombre;
            TotalRecaudado = totalRecaudado;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double TotalRecaudado { get => totalRecaudado; set => totalRecaudado = value; }
    }
}
