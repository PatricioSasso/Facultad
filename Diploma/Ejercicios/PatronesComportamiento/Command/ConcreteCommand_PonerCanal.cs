using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
	public class ConcreteCommand_PonerCanal : ICommand
	{
		public ConcreteCommand_PonerCanal(Receiver_TV tV, Receiver_TV.Canales canal)
		{
			TV = tV;
			canalCambiar = canal;
		}

		public Receiver_TV TV { get; set; }
		private Receiver_TV.Canales canalAnterior;
		private Receiver_TV.Canales canalCambiar;
		public void Deshacer()
		{
			TV.PonerCanal((int)canalAnterior);
		}

		public ICommand Ejecutar()
		{
			canalAnterior = TV.Canal;
			TV.PonerCanal((int)canalCambiar);
			return this;
		}
	}
}
