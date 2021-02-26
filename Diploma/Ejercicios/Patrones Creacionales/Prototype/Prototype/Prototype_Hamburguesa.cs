using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
	public abstract class Prototype_Hamburguesa : ICloneable
	{
		//PROTYPE
		protected string Nombre { get; set; }
		protected TiposCarne Carne { get; set; }
		protected int Medallones { get; set; }
		public int FetasQueso { get; set; }
		protected TiposQueso TiposQueso { get; set; }
		protected bool Tomate { get; set; }
		protected TiposSalsa Salsa { get; set; }
		protected int Pan { get; set; }
		public bool Panceta { get; set; }
		protected bool Lechuga { get; set; }
		protected bool Cebolla { get; set; }

		public object Clone()
		{
			return MemberwiseClone();
		}

		public string Descripcion()
		{
			string mensaje = "Nombre: "+ Nombre+ 
				" -Carne: " + Carne +
				" -Medallones: " + Medallones +
				" -FetasQueso: " + FetasQueso +
				" -Tipo de Queso: " + TiposQueso +
				" -Tipo de Salsa: " + Salsa +
				" -Pan: " + Pan;
			if (Tomate) { mensaje += "Tomate-"; }
			if (Lechuga) { mensaje += " Lechuga- "; }
			if (Cebolla) { mensaje += " Cebolla-"; }
			if (Panceta) { mensaje += " Panceta-"; }
			mensaje += Environment.NewLine;
			return mensaje;
		}
	}
	public enum TiposCarne { Vacuna, Pollo, Cerdo}
	public enum TiposQueso { Cheddar, Mozzarella, SinQueso}
	public enum TiposSalsa { BigMac, Mayonesa, BBQ, Ketchup, Mostaza, SinSalsa}

}
