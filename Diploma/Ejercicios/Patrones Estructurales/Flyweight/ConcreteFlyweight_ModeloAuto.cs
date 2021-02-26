using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
	//Flyweight concreto con los campos extrínsecos (compartidos)
	public class ConcreteFlyweight_ModeloAuto : IModeloAuto_Flyweight
	{
		private string marca;
		private string modelo;
		private string color;
		public ConcreteFlyweight_ModeloAuto(string marca, string modelo, string color)
		{
			this.marca = marca;
			this.modelo = modelo;
			this.color = color;
		}

		public string Marca { get{ return marca; } }
		public string Modelo { get{ return modelo; } }
		public string Color { get{ return color; } }

		public string Describir()
		{
			string mensaje= "Marca: " + Marca+Environment.NewLine;
			mensaje += "Modelo: " + Modelo + Environment.NewLine;
			mensaje += "Color: " + Color + Environment.NewLine;
			return mensaje;
		}
	}
}
