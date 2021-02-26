using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
	//tiene un diccionario para llevar el control de los extrínsecos usados
	//devuelve un unshared concrete flyweight (el que tiene atributos propios)
	public class FlyweightFactory_Concesionario
	{
		Dictionary<string, IModeloAuto_Flyweight> Diccionario = new Dictionary<string, IModeloAuto_Flyweight>();

		public IModeloAuto_Flyweight Vender(string marca, string modelo, string color, string patente, string titular)
		{
			string Key = marca + modelo + color;
			if(!Diccionario.ContainsKey(Key))
			{
				Diccionario.Add(Key, new ConcreteFlyweight_ModeloAuto(marca, modelo, color));
			}
			return new UnsharedConcreteFlyweight_Auto((ConcreteFlyweight_ModeloAuto)Diccionario[Key], patente, titular);
		}
	}
}
