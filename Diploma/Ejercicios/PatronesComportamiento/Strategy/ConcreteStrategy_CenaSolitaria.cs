using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
	public class ConcreteStrategy_CenaSolitaria : IStrategy_PreparacionMesa
	{
		public string PonerLaMesa()
		{
			return "1 mantel individual" + Environment.NewLine +

			"1 plato diario" + Environment.NewLine +

			"1 cuchillo Tramontina" + Environment.NewLine +

			"1 tenedor Tramontina" + Environment.NewLine +

			"1 rollo de papel de cocina" + Environment.NewLine +

			"1 chop de cerveza" + Environment.NewLine +

			"Control remoto de la tele";
		}
	}
}
