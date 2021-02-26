using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesEstructurales
{
	public interface IAbstraction_Pizzeria
	{
		IImplementor_Pizzero pizzero { get; set; }
		string EntregarPizza();
		string ServirPizza();
	}
}
