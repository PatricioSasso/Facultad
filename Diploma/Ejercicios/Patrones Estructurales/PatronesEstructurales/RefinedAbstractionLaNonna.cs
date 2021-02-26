using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesEstructurales
{
	//abstracción refinada
	public class RefinedAbstractionLaNonna : IAbstraction_Pizzeria
	{
		public RefinedAbstractionLaNonna()
		{
			pizzero = new ConcreteImplementorArtesanal();
		}

		public IImplementor_Pizzero pizzero { get; set; }

		public string EntregarPizza()
		{
			return "La Nonna no hace delivery ni take away";
		}

		public string ServirPizza()
		{
			return pizzero.PrepararPizza() + pizzero.CocinarPizza() + " Servir a la mesa";
			
		}
	}
}
