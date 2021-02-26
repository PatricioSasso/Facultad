using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
	//ABSTRACT TEMPLATE
	public abstract class Template_Venta
	{
		public enum FormasDePago {Efectivo, Credito, Debito	}

		private FormasDePago formapago;
		public FormasDePago FormasPago { get { return formapago; }}
		private decimal subtotal;

		protected Template_Venta()
		{
			Productos = new List<Producto>();
		}

		public decimal SubTotal { get { return subtotal; } }
		protected List<Producto> Productos { get; set; }
		public void Agregar(List<Producto> productos)
		{
			foreach (Producto item in productos)
			{
				Productos.Add(item);
			}
		}
		public void Agregar(Producto producto)
		{
			Productos.Add(producto);
		}
		//TEMPLATE METHOD
		public decimal CerrarVenta(FormasDePago forma)
		{
			formapago = forma;
			subtotal = CalcularTotal();
			subtotal -= CalcularDescuentos();
			subtotal += CalcularEmbalaje();
			subtotal += CalcularEnvio();
			return SubTotal;
		}
		//PRIMITIVE OPERATION
		public decimal CalcularTotal()
		{
			decimal total = 0;
			foreach(Producto prod in Productos)
			{
				total += prod.Precio;
			}
			return total;
		}
		//PRIMITIVE OPERATION
		public virtual decimal CalcularDescuentos()
		{
			decimal subtot = 0;
			if (formapago == FormasDePago.Efectivo) {				
				subtot = subtotal * 10/100; // descuento del 10% por ser en efectivo
			}
			else if(formapago==FormasDePago.Credito)
			{
				if (Productos.Count > 10)//hay descuento del 10% por comprar mas de 10 productos
				{
					subtot = subtotal * 10 / 100;
				}
			}
			return subtot;
		}
		//PRIMITIVE OPERATION
		public virtual decimal CalcularEmbalaje() { return 0; }
		//PRIMITIVE OPERATION
		public virtual decimal CalcularEnvio() { return 0; }
	}
}
