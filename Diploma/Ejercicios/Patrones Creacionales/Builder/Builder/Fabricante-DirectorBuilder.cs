using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
	public class Fabricante_DirectorBuilder
	{
		//DIRECTOR QUE INVOCA LOS BUILDPART DE LOS CONCRETE BUILDERS
		//SEGUN SEA PARAMETRIZADO
		public Producto_Computadora ConstruirComputadora(IBuilder builder)
		{
			builder.ConstruirCPU();
			builder.ConstruirControl();
			builder.ConstruirMonitor();
			builder.ConstruirTeclado();

			return builder.Computadora;
		}
	}
}
