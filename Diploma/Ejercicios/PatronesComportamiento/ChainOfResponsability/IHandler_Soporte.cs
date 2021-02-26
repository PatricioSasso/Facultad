using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
	public interface IHandler_Soporte
	{
		//HANDLER. DEFINE EL COMPORTAMIENTO DE TODOS LOS CONCRETE HANDLER
		IHandler_Soporte soporteSuperior { get; set; }
		string Resolver(Ticket ticket);
	}
}
