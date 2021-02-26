using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
	public class Receiver_TV
	{
		//utilizado por todos los commands para hacer acciones
        public bool Encendido { get; set; }
		public Canales Canal { get; set; }

        private int volumen;
        public int Volumen { get { return volumen; } }
		public enum Canales {
            TVPublica = 1,
            Telefe = 2,
            Nueve = 3,
            America = 4,
            Trece = 5,
            TN = 6,
            A24 = 7,
            Fox = 8,
            HBO = 9,
            ISat = 10,
            Space = 11,
            Warner = 12,
            Sony = 13
        }

        public void Encender()
		{
            Encendido = true;
		}
        public void Apagar()
		{
            Encendido = false;
		}
        public void SubirVolumen()
		{
			if (Volumen < 100) { volumen++; }
		}
        public void BajarVolumen()
		{
			if (Volumen > 0) { volumen--; }
		}
        public void ResetVolumen(int pVol)
		{
            volumen = pVol;
			if (Volumen > 100) { volumen = 100; }
            else if (Volumen < 0) { volumen = 0; }
		}
        public void SubirCanal()
		{
			if (Canal < (Canales)13) { Canal++; }
		}
        public void BajarCanal()
        {
            if (Canal > (Canales)1) { Canal--; }
        }
        public void PonerCanal(int pCanal)
        {
            Canal = (Canales)pCanal;
            if (Canal>(Canales)13) { Canal = (Canales)13; }
            else if (Canal < (Canales)1) { Canal = (Canales)1; }
        }

        public string Estado()
        {
            if(Encendido)
			{
                return "TV. Encendida: " + Environment.NewLine +
                "Canal: " + Canal.ToString() + Environment.NewLine +
                "Volumen: " + volumen.ToString();
			}
			else
			{
                return "Apagado";
			}
        }
    }
}
