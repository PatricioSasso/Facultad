using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
	public class ConcreteHandler_SoporteSegundoNivel : IHandler_Soporte
	{
		public ConcreteHandler_SoporteSegundoNivel()
		{
			soporteSuperior = new ConcreteHandler_ConclaveIngenieros();
		}

		public ConcreteHandler_SoporteSegundoNivel(IHandler_Soporte soporteSuperior)
		{
			this.soporteSuperior = soporteSuperior;
		}

		public IHandler_Soporte soporteSuperior { get; set; }

		public string Resolver(Ticket ticket)
		{
			if(ticket.Nivel== Ticket.ComplejidadTecnica.tecnicoSencillo)
			{
				return "El soporte de segundo nivel solucionó tu problema: " + ticket.Titulo;
			}
			else
			{
				if(soporteSuperior!=null)
				{
					return soporteSuperior.Resolver(ticket);
				}
			}
			return "El soporte de segundo nivel no pudo resolver su incidente";
		}
	}
}
