using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
	public class ConcretePrototypeMcPollo : Prototype_Hamburguesa
	{
		public ConcretePrototypeMcPollo()
		{
            Carne = TiposCarne.Pollo;
            Medallones = 1;
            TiposQueso = TiposQueso.SinQueso;
            FetasQueso = 0;
            Salsa = TiposSalsa.Mayonesa;
            Tomate = false;
            Pan = 2;
            Nombre = "McPollo";
            Panceta = false;
            Lechuga = true;
            Cebolla = false;

        }
	}
}
