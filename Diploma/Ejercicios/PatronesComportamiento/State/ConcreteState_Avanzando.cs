using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
	public class ConcreteState_Avanzando : IState
	{
		private Context_Auto Auto;

		public ConcreteState_Avanzando(Context_Auto auto)
		{
			Auto = auto;
		}
		public void Acelerar()
		{
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
			return "Avanzando";
		}

		public void Frenar()
		{
			Auto.Velocidad -= 1;
			Auto.Combustible -= 10;
			if(Auto.Combustible<=0)
			{
				Auto.CambiarEstado(new ConcreteState_SinCombustible(Auto));
			}
			if (Auto.Velocidad <= 0) { new ConcreteState_Detenido(Auto); }
		}
	}
}
