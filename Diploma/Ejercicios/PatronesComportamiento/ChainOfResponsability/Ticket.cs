using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
	public class Ticket
	{
		public enum ComplejidadTecnica { 
			nivelBasico=1, tecnicoSencillo=2, tecnicoComplejo=3, tecnicoAtipico=4,
			metafisico=5, imposibleDeResolver=6
		}

		public string Titulo { get; set; }
		public ComplejidadTecnica Nivel { get; set; }
	}
}
