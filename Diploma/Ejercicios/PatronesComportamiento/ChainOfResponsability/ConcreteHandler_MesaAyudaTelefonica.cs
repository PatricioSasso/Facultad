using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
	public class ConcreteHandler_MesaAyudaTelefonica : IHandler_Soporte
	{
		public ConcreteHandler_MesaAyudaTelefonica()
		{
			soporteSuperior = new ConcreteHandler_SoporteSegundoNivel();
		}

		public ConcreteHandler_MesaAyudaTelefonica(IHandler_Soporte soporteSuperior)
		{
			this.soporteSuperior = soporteSuperior;
		}

		public IHandler_Soporte soporteSuperior { get; set; }

		public string Resolver(Ticket ticket)
		{
			if(ticket.Nivel== Ticket.ComplejidadTecnica.nivelBasico)
			{
				return "Mesa de ayuda telefónica: hemos resuelto tu incidente: " + ticket.Titulo; 
			}
			else
			{
				if(soporteSuperior!=null)
				{
					return soporteSuperior.Resolver(ticket);
				}
			}
			return "La mesa de ayuda no pudo resolver tu problema";
		}
	}
}
