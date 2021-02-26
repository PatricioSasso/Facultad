using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
	public class ConcreteHandler_GuruTecnologico : IHandler_Soporte
	{
		public ConcreteHandler_GuruTecnologico()
		{
			soporteSuperior = new ConcreteHandler_Dios();
		}

		public ConcreteHandler_GuruTecnologico(IHandler_Soporte soporteSuperior)
		{
			this.soporteSuperior = soporteSuperior;
		}

		public IHandler_Soporte soporteSuperior { get; set; }

		public string Resolver(Ticket ticket)
		{
			if (ticket.Nivel == Ticket.ComplejidadTecnica.tecnicoAtipico)
			{
				return "El guru tecnológico resolvió su problema:  " + ticket.Titulo;
			}
			else
			{
				if (soporteSuperior != null)
				{
					return soporteSuperior.Resolver(ticket);
				}
			}
			return "El guru tecnológico no pudo resolver su incidente";
		}
	}
}
