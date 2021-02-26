using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
	public class ConcreteBuilderSmartPhone : IBuilder
	{
		//CONCRETE BUILDER DEL SMART PHONE
		public ConcreteBuilderSmartPhone()
		{
			this.computadora = new Producto_Computadora(Producto_Computadora.TipoComputadora.SmartPhone);
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
			computadora.CPU = "1.6GHZ OctaCore";
		}

		public void ConstruirMonitor()
		{
			computadora.Monitor = "Super AMOLED 5.5' '";
		}

		public void ConstruirTeclado()
		{
			computadora.Teclado = "";
		}
	}
}
