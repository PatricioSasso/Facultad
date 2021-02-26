using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Subsistema
{
	public class Transporte
	{
		public enum TipoTransporte
		{
			Limo, CocheClasico, Trencito
		}

		public TipoTransporte Tipo { get; set; }

		private decimal costo;
		public decimal Costo { get{return costo; } }

		public string Contratar(DateTime fecha)
		{
			string mensaje = "Transporte para la fecha:  "+ fecha.ToString() + Environment.NewLine;
			if (Tipo == TipoTransporte.Limo) {
				costo = 15000;
				mensaje += "Limousina para 6 pasajeros Lincoln: " + Costo.ToString() + Environment.NewLine;

			}
			else if( Tipo== TipoTransporte.CocheClasico) {
				costo = 8000;
				mensaje += "Cadillac '56: " + Costo.ToString() + Environment.NewLine; 
			}
			else if(Tipo== TipoTransporte.Trencito) {
				costo = 4000;
				mensaje += "Trencito de la alegría para 35 pasajeros: " + Costo.ToString() + Environment.NewLine; 
			}
			return mensaje;
		}

	}
}
