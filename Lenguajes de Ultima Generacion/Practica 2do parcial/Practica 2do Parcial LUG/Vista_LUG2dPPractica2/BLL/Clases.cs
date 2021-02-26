using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BLL
{
    public class Inmobiliaria
    {
        int id;
        string nombre;
        double totalRecaudado;

        public Inmobiliaria(int id, string nombre, double totalRecaudado)
        {
            this.Id = id;
            this.Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            this.TotalRecaudado = totalRecaudado;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double TotalRecaudado { get => totalRecaudado; set => totalRecaudado = value; }
    }

    public class VistaInmobiliaria
    {
        int id;
        string nombre;
        double totalRecaudado;

        public VistaInmobiliaria(int id, string nombre, double totalRecaudado)
        {
            this.Id = id;
            this.Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            this.TotalRecaudado = totalRecaudado;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double TotalRecaudado { get => totalRecaudado; set => totalRecaudado = value; }
    }
}
