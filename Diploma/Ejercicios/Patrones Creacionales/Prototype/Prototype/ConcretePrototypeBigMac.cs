using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
	public class ConcretePrototypeBigMac : Prototype_Hamburguesa
	{
		public ConcretePrototypeBigMac()
		{
            Carne=TiposCarne.Vacuna;
            Medallones = 2;
            TiposQueso = TiposQueso.Cheddar;
            FetasQueso = 2;
            Salsa = TiposSalsa.BigMac;
            Tomate = false;
            Pan = 2;
            Nombre = "Big Mac";
            Panceta = false;
            Lechuga = true;
            Cebolla = true;

        }
	}
}
