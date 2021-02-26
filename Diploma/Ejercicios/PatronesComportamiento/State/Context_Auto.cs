using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
	//CONTEXT
	public class Context_Auto
	{
		IState estado;

		public Context_Auto()
		{
			estado = new ConcreteState_SinCombustible(this);
		}
		public int Combustible { get; set; }
		public int Velocidad { get; set; }

		public void CambiarEstado(IState state)
		{
			estado = state;
		}
        public void Encender() { estado.Encender(); }

        public void Apagar() { estado.Apagar(); }

		public void Acelerar() { estado.Acelerar(); }
		public void Frenar() { estado.Frenar(); }
		public void CargarCombustible(int pCantidad) { estado.CargarCombutible(pCantidad); }
		public string DescribirEstado()
		{
			return "Estado: " + estado.Estado() + Environment.NewLine +
			"Velocidad: " + Velocidad + Environment.NewLine +
			"Combustible: " + Combustible + Environment.NewLine;
		}
    }
}
