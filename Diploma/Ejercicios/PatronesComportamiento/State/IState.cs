using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
	//STATE
	public interface IState
    {
        void Acelerar();
        void Frenar();
        void Encender();
        void Apagar();
        void CargarCombutible(int pCantidad);
        string Estado();
    }
}
