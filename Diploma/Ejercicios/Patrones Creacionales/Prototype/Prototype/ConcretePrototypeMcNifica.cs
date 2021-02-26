using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
	public class ConcretePrototypeMcNifica : Prototype_Hamburguesa
	{
		public ConcretePrototypeMcNifica()
		{
            Carne = TiposCarne.Vacuna;
            Medallones = 1;
            TiposQueso = TiposQueso.Cheddar;
            FetasQueso = 1;
            Salsa = TiposSalsa.Mostaza;
            Tomate = true;
            Pan = 2;
            Nombre = "McNífica";
            Panceta = false;
            Lechuga = true;
            Cebolla = true;

        }
	}
}
