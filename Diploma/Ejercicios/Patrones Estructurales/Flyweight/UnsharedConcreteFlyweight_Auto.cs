using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
	//concrete flyweight que tiene atributos propios
	//tiene una instancia del concreteflyweight para tener sus valores generales
	public class UnsharedConcreteFlyweight_Auto : IModeloAuto_Flyweight
	{
		private ConcreteFlyweight_ModeloAuto modeloAuto;
		private string patente;
		private string titular;

		public UnsharedConcreteFlyweight_Auto(ConcreteFlyweight_ModeloAuto modeloAuto, string patente, string titular)
		{
			this.modeloAuto = modeloAuto;
			this.patente = patente;
			this.titular = titular;
		}

		public string Marca { get { return modeloAuto.Marca; } }

		public string Modelo { get { return modeloAuto.Modelo; } }

		public string Color { get { return modeloAuto.Color; } }

		public string Patente { get { return patente; } }

		public string Titular { get{ return titular; } }

		public string Describir()
		{
			return modeloAuto.Describir() + " Dominio: " + this.Patente + " de: " + this.Titular;
		}
	}
}
