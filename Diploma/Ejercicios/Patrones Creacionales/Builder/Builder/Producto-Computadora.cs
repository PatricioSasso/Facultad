using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
	public class Producto_Computadora
	{
		public Producto_Computadora(TipoComputadora tipo)
		{
			Tipo = tipo;
		}

		//ESTA CLASE REPRESENTA AL PRODUCTO QUE SE CREARÁ
		public enum TipoComputadora { Escritorio, Notebook, Tablet, SmartPhone}

		public TipoComputadora Tipo { get; set; }
		public string Monitor { get; set; }
		public string Teclado { get; set; }
		public string CPU { get; set; }
		public string Control { get; set; }

		public string MostrarDescripcion()
		{
			return "CPU: " + CPU + Environment.NewLine +
				"Monitor: " + Monitor + Environment.NewLine +
				"Teclado: " + Teclado + Environment.NewLine +
				"Control: " + Control + Environment.NewLine;
		}
	}
}
