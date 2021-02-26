using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
	//FLYWEIGHT QUE DEFINE LAS ESTRUCTURAS PARA LOS ConcreteFlyweight Y UnsharedConcreteFlyweight
	public interface IModeloAuto_Flyweight
	{
		string Marca { get;}
		string Modelo { get;}
		string Color { get;}
		string Describir();
	}
}
