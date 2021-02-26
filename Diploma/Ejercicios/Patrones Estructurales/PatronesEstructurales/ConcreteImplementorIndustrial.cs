using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesEstructurales
{
	//Implementor concreto 
	public class ConcreteImplementorIndustrial : IImplementor_Pizzero
	{
		public string CocinarPizza()
		{
			return "Colocar pizza en el horno indistrial a 230 grados por 10 minutos" + Environment.NewLine +

			"Desmoldar pizza cocinada" + Environment.NewLine;
		}

		public string PrepararPizza()
		{
			return "Tomar prepizza de la cámara de frío" + Environment.NewLine +

			"Tomar porción de muzzarella trozada de envases de cámara" + Environment.NewLine +

			"Esparcir trozos de muzzarella en prepizza" + Environment.NewLine +

			"Condimentar y colocar aceitunas" + Environment.NewLine;
		}
	}
}
