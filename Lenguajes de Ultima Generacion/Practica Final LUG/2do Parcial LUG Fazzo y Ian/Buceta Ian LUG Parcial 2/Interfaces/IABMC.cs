using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IABMC<T>
    {
        void Alta(T objeto);
        void Baja(T objeto);
        void Modificacion(T objeto);
        T Consulta(int idObjeto);
        List<T> ConsultaFiltro(string filtro);
        List<T> ConsultaTodos();
        void Guardar();
    }
}
