using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
	public class ConcreteState_Detenido : IState
	{
		private Context_Auto Auto;

		public ConcreteState_Detenido(Context_Auto auto)
		{
			Auto = auto;
			Auto.Velocidad = 0;
		}

		public void Acelerar()
		{
			Auto.CambiarEstado(new ConcreteState_Avanzando(Auto));
			Auto.Velocidad += 1;
			Auto.Combustible -= 10;
			if (Auto.Combustible <= 0) { Auto.CambiarEstado(new ConcreteState_SinCombustible(Auto)); }
		}

		public void Apagar()
		{
			Auto.CambiarEstado(new ConcreteState_Apagado(Auto));
		}

		public void CargarCombutible(int pCantidad)
		{
			Auto.Combustible += pCantidad;
		}

		public void Encender()
		{
			
		}

		public string Estado()
		{
			return "Detenido";
		}

		public void Frenar()
		{
			
		}
	}
}
