using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADODesconectado3
{
	public class Persona
	{
		public int Codigo { get; set; }
		public string Nombre { get; set; }
		public string Apellido { get; set; }
		List<Telefono> telefonosalumno;
	}

	public class Telefono
	{
		public int Codigo { get; set; }
		public int Numero { get; set; }
	}
}
