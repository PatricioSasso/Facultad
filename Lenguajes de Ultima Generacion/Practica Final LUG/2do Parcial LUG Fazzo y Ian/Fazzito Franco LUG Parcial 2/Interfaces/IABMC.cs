using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IABMC
    {
        void Alta();
        void Baja();
        void Modificacion();
        void Consultar();
        void ConsultarFiltro();
    }
    public interface IABMC_Generico<T>
    {
        void Alta(T value);
        void Baja(T value);
        void Modificacion(T value);
        List<T> Consultar();
        List<T> ConsultarFiltro(string filtro);
    }
}
