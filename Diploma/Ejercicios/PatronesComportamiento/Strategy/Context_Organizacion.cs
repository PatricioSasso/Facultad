using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
	public class Context_Organizacion
	{
		public string PonerMesa(IStrategy_PreparacionMesa preparacionMesa)
		{
			return preparacionMesa.PonerLaMesa();
		}
	}
}
