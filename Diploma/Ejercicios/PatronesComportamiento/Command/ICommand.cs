using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
	public interface ICommand
	{
		Receiver_TV TV { get; set; }
		ICommand Ejecutar();
		void Deshacer();
	}
}
