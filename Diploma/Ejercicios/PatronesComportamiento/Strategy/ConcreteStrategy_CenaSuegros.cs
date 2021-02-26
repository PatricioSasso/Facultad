using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
	public class ConcreteStrategy_CenaSuegros : IStrategy_PreparacionMesa
	{
		public string PonerLaMesa()
		{
            return "Mantel floreado" + Environment.NewLine +
         "4 platos de porcelana" + Environment.NewLine +
         "2 cuchillos finos" + Environment.NewLine +
         "2 cuchillos sin filo (para los suegros)" + Environment.NewLine +
         "4 tenedores finos" + Environment.NewLine +
         "4 servilletas blancas" + Environment.NewLine +
         "4 copas de vino" + Environment.NewLine +
         "4 copas de agua" + Environment.NewLine +
         "Salero y pimentero con roscas de tapa falseadas";

        }
	}
}
