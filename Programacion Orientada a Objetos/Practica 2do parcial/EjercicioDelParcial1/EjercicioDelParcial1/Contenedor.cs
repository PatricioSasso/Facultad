using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDelParcial1
{
    public class Contenedor
    {
        string id;
        string descripcion;
        DateTime fecha;
        decimal peso;
        bool despachado;

        public Contenedor(string id, string descripcion, DateTime fecha, decimal peso)
        {
            this.Id = id;
            this.Descripcion = descripcion;
            this.Fecha = fecha;
            this.Peso = peso;
            this.Despachado = false;
        }

        public string Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public decimal Peso { get => peso; set => peso = value; }
        public bool Despachado { get => despachado; set => despachado = value; }

        public void Modificar(string descripcion, DateTime fecha, decimal peso)
        {
            this.descripcion = descripcion;
            this.fecha = fecha;
            this.peso = peso;
        }

        public void Despachar()
        {
            this.Despachado = true;
        }
    }
}
