using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
	class ConcreteHandler_ConclaveIngenieros : IHandler_Soporte
	{
		public ConcreteHandler_ConclaveIngenieros()
		{
			soporteSuperior = new ConcreteHandler_GuruTecnologico();
		}

		public ConcreteHandler_ConclaveIngenieros(IHandler_Soporte soporteSuperior)
		{
			this.soporteSuperior = soporteSuperior;
		}

		public IHandler_Soporte soporteSuperior { get; set; }

		public string Resolver(Ticket ticket)
		{
			if (ticket.Nivel == Ticket.ComplejidadTecnica.tecnicoComplejo)
			{
				return "La conclave de ingenieros resolvió su problema:  " + ticket.Titulo;
			}
			else
			{
				if (soporteSuperior != null)
				{
					return soporteSuperior.Resolver(ticket);
				}
			}
			return "La conclave de ingenieros no pudo resolver su incidente";
		}
	}
}
