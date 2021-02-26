using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AdoDesconectadoConBdPractica
{
    class MapperTelefono
    {
        public void Agregar(DataSet DataSet, Telefono telefono)
        {
            DataRow agregar = DataSet.Tables["Telefono"].NewRow();
            agregar.ItemArray = new object[] { telefono.id, telefono.numero };
            DataSet.Tables["Telefono"].Rows.Add(agregar);
        }

        public void Modificar(DataSet DataSet, Telefono telefono)
        {
            DataSet.Tables["Telefono"].Rows.Find(telefono.id).ItemArray = new object[] { telefono.id, telefono.numero };
        }

        public void Eliminar(DataSet DataSet, Telefono telefono)
        {
            DataSet.Tables["Telefono"].Rows.Find(telefono.id).Delete();
        }
    }
}
