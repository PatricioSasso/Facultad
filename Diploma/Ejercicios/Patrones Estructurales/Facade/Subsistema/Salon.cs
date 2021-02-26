using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Subsistema
{
	public class Salon
	{
		const decimal SalonChicoCosto = 40000;
		const decimal SalonMedianoCosto = 70000;
		const decimal SalonGrandeCosto = 100000;

		private decimal costo;
		public decimal Costo { get { return costo; } }

		public string Reservar(int invitados, DateTime fecha)
		{
			string mensaje = "Verificando disponibilidad..." + Environment.NewLine + "Salón diponible: ";
			if (invitados <= 100) { costo = SalonChicoCosto; mensaje += " chico. "+ Environment.NewLine; }
			else if (invitados >100 && invitados<=500) { costo = SalonMedianoCosto; mensaje += " mediano. " + Environment.NewLine; }
			else if (invitados > 500) { costo = SalonGrandeCosto; mensaje += " grande. " + Environment.NewLine; }

			if(fecha.Month==11 || fecha.Month==12)
			{
				costo = costo * 20 / 100;
				mensaje += "El salón sale un 20% más caro en los meses de Noviembre y Diciembre" + Environment.NewLine;
			}
			mensaje += "El costo total del salon es: "+ Costo.ToString() + Environment.NewLine;
			return mensaje;
		}
	}
}
