using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
	public class Producto
	{
		public Producto(string codigo, string nombre, int precio, int peso )
		{
			Precio = precio;
			Nombre = nombre;
			Peso = peso;
			Codigo = codigo;
		}

		public int Precio { get; set; }
		public string Nombre { get; set; }
		public int Peso { get; set; }
		public string Codigo { get; set; }
	}
}
