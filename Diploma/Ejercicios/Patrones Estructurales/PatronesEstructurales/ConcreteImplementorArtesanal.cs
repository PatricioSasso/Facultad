using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesEstructurales
{
	//Implementor concreto 
	public class ConcreteImplementorArtesanal : IImplementor_Pizzero
	{
		public string CocinarPizza()
		{
			return "Colocar pizza en el horno a 180 grados por 20 minutos" + Environment.NewLine +

			"Desmoldar pizza cocinar" + Environment.NewLine;
		}

		public string PrepararPizza()
		{
			return "Amasar harina + agua + levadura + sal" + Environment.NewLine +

				  "Dejar levar masa" + Environment.NewLine +

				  "Estirar masa en pizzera" + Environment.NewLine +

				  "Pintar con salsa" + Environment.NewLine +

				  "Cortar 400 gr de muzzarella en dados" + Environment.NewLine +

				  "Esparcir muzzarella" + Environment.NewLine +

				  "Condimentar y colocar aceitunas" + Environment.NewLine;
		}
	}
}
