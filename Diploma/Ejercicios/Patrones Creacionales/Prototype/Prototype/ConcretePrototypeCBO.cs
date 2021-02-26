using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
	public class ConcretePrototypeCBO : Prototype_Hamburguesa
	{
		//ES UN CONCRETE PROTOTYPE
        public ConcretePrototypeCBO()
		{
			Carne = TiposCarne.Pollo;
            Medallones = 1;
            TiposQueso = TiposQueso.Cheddar;
            FetasQueso = 1;
            Salsa = TiposSalsa.Mayonesa;
            Tomate = false;
            Pan = 2;
            Nombre = "CBO";
            Panceta = true;
            Lechuga = true;
            Cebolla = true;
        }
	}
}
