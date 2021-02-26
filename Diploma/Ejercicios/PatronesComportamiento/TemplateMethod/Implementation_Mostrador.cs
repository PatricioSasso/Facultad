using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
	public class Implementation_Mostrador : Template_Venta
	{
		public override decimal CalcularDescuentos()
		{
			return base.CalcularDescuentos()*2;//descuento doble por comprar en mostrador
		}
		public override decimal CalcularEmbalaje()
		{
			return 20; //$20 es el mínimo por llevarlo.
		}
		public override decimal CalcularEnvio()
		{
			return 0;
		}
	}
}
