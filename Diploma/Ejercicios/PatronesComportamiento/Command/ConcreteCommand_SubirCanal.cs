using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
	public class ConcreteCommand_SubirCanal : ICommand
	{
		public ConcreteCommand_SubirCanal(Receiver_TV tV)
		{
			TV = tV;
		}

		public Receiver_TV TV { get; set; }
		private Receiver_TV.Canales canalAnterior;
		public void Deshacer()
		{
			TV.PonerCanal((int)canalAnterior);
		}

		public ICommand Ejecutar()
		{
			canalAnterior = TV.Canal;
			TV.SubirCanal();
			return this;
		}
	}
}
