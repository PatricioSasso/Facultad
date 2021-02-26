using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
	public class Implementation_VentaEnvio : Template_Venta
	{
		//Primitive operation
		public override decimal CalcularEmbalaje()
		{
			int peso = 0;
			decimal pago = 0;
			foreach (Producto item in Productos)
			{
				peso += item.Peso;				
			}
			if (peso > 10)
			{
				pago= SubTotal * 20 / 100; //20% de recargo por más de 10 kilos
			}
			return pago;
		}
		//Primitive operation
		public override decimal CalcularEnvio()
		{
			return 40 * Productos.Count; //$40 por producto
		}
	}
}
