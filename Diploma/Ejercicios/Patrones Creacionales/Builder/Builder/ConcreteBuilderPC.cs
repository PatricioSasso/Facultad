using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
	public class ConcreteBuilderPC : IBuilder
	{
		//CONCRETE BUILDER PARA LA PC DE ESCRITORIO
		public ConcreteBuilderPC()
		{
			this.computadora = new Producto_Computadora(Producto_Computadora.TipoComputadora.Escritorio);
		}
		private Producto_Computadora computadora;
		//property del campo computadora
		public Producto_Computadora Computadora {
			get { return computadora; }
		}

		public void ConstruirControl()
		{
			computadora.Control = "Mouse";
		}

		public void ConstruirCPU()
		{
			computadora.CPU = "i7";
		}

		public void ConstruirMonitor()
		{
			computadora.Monitor = "LED 29' '";
		}

		public void ConstruirTeclado()
		{
			computadora.Teclado = "QUERY extendido";
		}
	}
}
