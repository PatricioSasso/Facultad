using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
	public class ConcreteCommand_EncenderApagar : ICommand
	{
		public ConcreteCommand_EncenderApagar(Receiver_TV tV)
		{
			TV = tV;
		}

		public Receiver_TV TV { get; set; }

		public void Deshacer()
		{
			
		}

		public ICommand Ejecutar()
		{
			if (TV.Encendido) { TV.Apagar(); }
			else { TV.Encender(); }
			return this;
		}
	}
}
