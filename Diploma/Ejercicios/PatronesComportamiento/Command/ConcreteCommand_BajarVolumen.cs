using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
	public class ConcreteCommand_BajarVolumen : ICommand
	{
		public ConcreteCommand_BajarVolumen(Receiver_TV tV)
		{
			TV = tV;
		}

		public Receiver_TV TV { get; set; }

		private int volumenAnterior;
		public void Deshacer()
		{
			TV.ResetVolumen(volumenAnterior);
		}

		public ICommand Ejecutar()
		{
			volumenAnterior = TV.Volumen;
			TV.BajarVolumen();
			return this;
		}
	}
}
