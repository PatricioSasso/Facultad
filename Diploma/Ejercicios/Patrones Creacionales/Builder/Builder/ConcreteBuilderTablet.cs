using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
	public class ConcreteBuilderTablet : IBuilder
	{
		//CONCRETE BUILDER DE LA TABLET
		public ConcreteBuilderTablet()
		{
			this.computadora = new Producto_Computadora(Producto_Computadora.TipoComputadora.Tablet);
		}
		private Producto_Computadora computadora;
		//property del campo computadora
		public Producto_Computadora Computadora
		{
			get { return computadora; }
		}
		public void ConstruirControl()
		{
			computadora.Control = "Touch screen";
		}

		public void ConstruirCPU()
		{
			computadora.CPU = "MT8163";
		}

		public void ConstruirMonitor()
		{
			computadora.Teclado = "";
		}

		public void ConstruirTeclado()
		{
			computadora.Monitor = "Touch LED 10.1";
		}
	}
}
