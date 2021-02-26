using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
	public class ConcreteState_Apagado : IState
	{
		private Context_Auto Auto;

		public ConcreteState_Apagado(Context_Auto auto)
		{
			Auto = auto;
		}

		public void Acelerar()
		{
			
		}

		public void Apagar()
		{
			
		}

		public void CargarCombutible(int pCantidad)
		{
			Auto.Combustible += pCantidad;
		}

		public void Encender()
		{
			Auto.CambiarEstado(new ConcreteState_Detenido(Auto));
		}

		public string Estado()
		{
			return "Apagado";
		}

		public void Frenar()
		{
			
		}
	}
}
