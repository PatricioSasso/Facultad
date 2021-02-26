using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesEstructurales
{
	//abstracción refinada
	public class RefinedAbstractionRomario : IAbstraction_Pizzeria
	{
		public RefinedAbstractionRomario()
		{
			pizzero = new ConcreteImplementorIndustrial();
		}

		public IImplementor_Pizzero pizzero { get; set; }

		public string EntregarPizza()
		{
			return pizzero.PrepararPizza() + pizzero.CocinarPizza() + "Poner pizza en caja y entregar al cliente";
		}

		public string ServirPizza()
		{
			return pizzero.PrepararPizza() + pizzero.CocinarPizza() + "Servir a la mesa";
		}
	}
}
