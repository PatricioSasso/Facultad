using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facade.Subsistema; //USA LO DEL SUBSISTEMA A TRAVES DEL FACADE

namespace Facade
{
    //Facade 
	public class FacadeOrganizadorEventos
	{
		public enum TipoGasto { FestejoCompleto, FiestaModerada }

		public string OrganizarCasamiento(int invitados, DateTime fecha, TipoGasto gasto)
		{
            string mRes = "CASAMIENTO PARA: " + invitados + " INVITADOS";
            decimal costoTotal = 0;

           if(gasto==TipoGasto.FestejoCompleto)
			{
                Salon mSalon = new Salon();
                mRes += mSalon.Reservar(invitados, fecha);
                costoTotal += mSalon.Costo;

                Catering mCat = new Catering();

                mCat.TipoDeCatering = Catering.TipoCatering.CocinaDeAutor;
                mCat.FinDeFiesta = true;
                mCat.MesaDulce = true;
                mRes += mCat.Contratar(invitados, fecha); 
                costoTotal += mCat.Costo;

                Transporte mTr = new Transporte();
                mTr.Tipo = Transporte.TipoTransporte.Limo;
                mRes += mTr.Contratar(fecha);
                costoTotal += mTr.Costo;
			}
           else if( gasto== TipoGasto.FiestaModerada)
			{
                Salon mSalon = new Salon();
                mRes += mSalon.Reservar(invitados, fecha);
                costoTotal += mSalon.Costo;

                Catering mCat = new Catering();
                mCat.TipoDeCatering = Catering.TipoCatering.Clasico;
                mCat.FinDeFiesta = false;
                mCat.MesaDulce = false;
                mRes += mCat.Contratar(invitados, fecha);
                costoTotal += mCat.Costo;

                Transporte mTr = new Transporte();
                mTr.Tipo = Transporte.TipoTransporte.CocheClasico;
                mRes += mTr.Contratar(fecha);
                costoTotal += mTr.Costo;
            }
            return mRes;
        }
	}
}
