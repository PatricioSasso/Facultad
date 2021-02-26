using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
	public class ConcreteStrategy_CenaRomantica : IStrategy_PreparacionMesa
	{
		public string PonerLaMesa()
		{
            return "Mantel rojo" + Environment.NewLine +
            "2 platos de porcelana" + Environment.NewLine +
            "2 platos de sitio" + Environment.NewLine +
            "2 cuchillos finos" + Environment.NewLine +
            "2 tenedores finos" + Environment.NewLine +
            "2 servilletas con motivos románticos" + Environment.NewLine +
            "2 copas de vino" + Environment.NewLine +
            "2 copas de agua" + Environment.NewLine +
            "Hornillo con aroma a sándalo" + Environment.NewLine +
            "Candelabro con vela";

        }
	}
}
