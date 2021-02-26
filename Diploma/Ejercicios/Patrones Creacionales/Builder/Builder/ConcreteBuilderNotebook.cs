using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
	public class ConcreteBuilderNotebook : IBuilder
	{
		public ConcreteBuilderNotebook()
		{
			this.computadora = new Producto_Computadora(Producto_Computadora.TipoComputadora.Notebook);
		}

		private Producto_Computadora computadora;
		//property del campo computadora
		public Producto_Computadora Computadora
		{
			get { return computadora; }
		}
		public void ConstruirControl()
		{
			computadora.Control = "Pad";
		}

		public void ConstruirCPU()
		{
			computadora.CPU = "i7";
		}

		public void ConstruirMonitor()
		{
			computadora.Monitor = "LED 15.5 ' '";
		}

		public void ConstruirTeclado()
		{
			computadora.Teclado = "QUERTY";
		}
	}
}
