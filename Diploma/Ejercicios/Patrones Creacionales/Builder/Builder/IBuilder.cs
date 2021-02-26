using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
	public interface IBuilder
	{
		//ESTA CLASE REPRESENTA AL BUILDER QUE LE DARA
		//SU ESTRUCTURA A LOS CONCRETE BUILDER
		Producto_Computadora Computadora { get; }

		void ConstruirMonitor();//BuildPart
		void ConstruirTeclado();//BuildPart
		void ConstruirCPU();//BuildPart
		void ConstruirControl();//BuildPart
	}
}
