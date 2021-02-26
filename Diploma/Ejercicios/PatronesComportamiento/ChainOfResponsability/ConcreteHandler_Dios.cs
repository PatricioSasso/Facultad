using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
	public class ConcreteHandler_Dios : IHandler_Soporte
	{
		public ConcreteHandler_Dios()
		{
			soporteSuperior = null;
		}

		public ConcreteHandler_Dios(IHandler_Soporte soporteSuperior)
		{
			this.soporteSuperior = soporteSuperior;
		}

		public IHandler_Soporte soporteSuperior { get; set; }

		public string Resolver(Ticket ticket)
		{
			if (ticket.Nivel == Ticket.ComplejidadTecnica.metafisico)
			{
				return "Dios resolvió su problema:  " + ticket.Titulo;
			}
			else
			{
				if (soporteSuperior != null)
				{
					return soporteSuperior.Resolver(ticket);
				}
			}
			return "Dios: Hijo, lo siento, estás perdido";
		}
	}
}
