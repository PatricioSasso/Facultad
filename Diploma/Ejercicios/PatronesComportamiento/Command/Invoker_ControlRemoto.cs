using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
	public class Invoker_ControlRemoto
	{
		//Invoca todos los commands
		public Receiver_TV TV;

		public Invoker_ControlRemoto(Receiver_TV tV)
		{
			TV = tV;
			HistorialAcciones = new List<ICommand>();
		}

		List<ICommand> HistorialAcciones;

		public void EncenderApagar()
		{		
			HistorialAcciones.Add(GetCommandEncendidoApagado().Ejecutar());
		}
		public void SubirVolumen()
		{
			HistorialAcciones.Add(GetCommandSubirVolumen().Ejecutar());
		}
		public void BajarVolumen()
		{
			HistorialAcciones.Add(GetCommandBajarVolumen().Ejecutar());
		}
		public void SubirCanal()
		{
			HistorialAcciones.Add(GetCommandSubirCanal().Ejecutar());
		}
		public void BajarCanal()
		{
			HistorialAcciones.Add(GetCommandBajarCanal().Ejecutar());
		}
		public void PonerCanal(int canal)
		{
			HistorialAcciones.Add(GetCommandPonerCanal(canal).Ejecutar());
		}
		public void Deshacer()
		{
			if(HistorialAcciones.Count>0)
			{
				HistorialAcciones.Last().Deshacer();
				HistorialAcciones.Remove(HistorialAcciones.Last());
			}
		}
		private ICommand GetCommandBajarVolumen()
		{
			return new ConcreteCommand_BajarVolumen(TV);
		}
		private ICommand GetCommandSubirVolumen()
		{
			return new ConcreteCommand_SubirVolumen(TV);
		}
		private ICommand GetCommandBajarCanal()
		{
			return new ConcreteCommand_BajarCanal(TV);
		}
		private ICommand GetCommandSubirCanal()
		{
			return new ConcreteCommand_SubirCanal(TV);
		}
		private ICommand GetCommandPonerCanal(int canal)
		{
			return new ConcreteCommand_PonerCanal(TV, (Receiver_TV.Canales)canal);
		}
		private ICommand GetCommandEncendidoApagado()
		{
			return new ConcreteCommand_EncenderApagar(TV);
		}
	}
}
