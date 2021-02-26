using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Subsistema
{
	public class Catering
	{
        public enum TipoCatering { CocinaDeAutor, Clasico }


        private decimal mCosto = 0;
        public decimal Costo { get { return mCosto; } }

        public bool MesaDulce = true;
        public bool FinDeFiesta = false;
        public TipoCatering TipoDeCatering = TipoCatering.Clasico;

        public string Contratar(int pCantidad, DateTime pFecha )
		{
            int mCubierto;
            string mRes = "Menú: " + Environment.NewLine;
            if(TipoDeCatering==TipoCatering.Clasico)
			{
                mCubierto = 500;
                mRes += "Bandejeo de canapés de entrada" + Environment.NewLine;
                mRes += "Pollo al champignon con papas noissette" + Environment.NewLine;
                mRes += "Helado Charlotte" + Environment.NewLine;
                if(this.MesaDulce)
				{
                    mRes += "Mesa dulce con variedad de tortas y helado" + Environment.NewLine;
                    mCubierto += 150;
                }
                if(this.FinDeFiesta)
				{
                    mRes += "Chocolate con churros a las 6 am" + Environment.NewLine;
                    mCubierto += 100;
                }
                mRes += "Bebida: Vino tinto Norton, Agua y Gaseosas. Champagne Chandón para el brindis" + Environment.NewLine;
                mRes += "Costo del cubierto: " + mCubierto.ToString() + Environment.NewLine;
            }

            if(TipoDeCatering== TipoCatering.CocinaDeAutor)
			{
                mCubierto = 1000;
                mRes += "Tartare de samón" + Environment.NewLine;
                mRes += "Lomo al Malbec acompañado por paillason de papa" + Environment.NewLine;
                mRes += "Petit Gateau au Chocolat" + Environment.NewLine;

                if(this.MesaDulce)
				{
                    mRes += "Mesa dulce con tortas gourmette y fondue de chocolate" + Environment.NewLine;
                    mCubierto += 350;
                }
                if(this.FinDeFiesta)
				{
                    mRes += "Café de Colombia con petit fours y masa finas" + Environment.NewLine;
                    mCubierto += 300;
                }
                mRes += "Bebida: Vino DV Catena Cabertet y Champagne Don Perignon. Agua Evian y Gaseosas" + Environment.NewLine;
                mRes += "Costo del cubierto: " + mCubierto.ToString() + Environment.NewLine;
            }
            return mRes;
        }
       

    }
}
