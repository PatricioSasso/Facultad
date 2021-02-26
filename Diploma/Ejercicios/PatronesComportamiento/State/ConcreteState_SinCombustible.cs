using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
	public class ConcreteState_SinCombustible : IState
	{
		private Context_Auto Auto;

		public ConcreteState_SinCombustible(Context_Auto auto)
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
			Auto.CambiarEstado(new ConcreteState_Apagado(Auto));
		}

		public void Encender()
		{
			
		}

		public string Estado()
		{
			return "Sin combustible";
		}

		public void Frenar()
		{
			
		}
	}
}
