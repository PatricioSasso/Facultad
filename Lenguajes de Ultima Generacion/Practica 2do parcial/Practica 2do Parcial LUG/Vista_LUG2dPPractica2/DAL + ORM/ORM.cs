using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BLL;

namespace DAL___ORM
{
    public class MapperInmobiliaria
    {
        DataSet dataSet;
        SqlDataAdapter adapter;
        DataTable table;

        public MapperInmobiliaria(BaseDatos Base)
        {
            dataSet = Base.DataSet;
            adapter = Base.AdapterInmobiliaria;
            table = Base.TableInmobiliaria;
            table.PrimaryKey = new DataColumn[] { table.Columns["Id"] };
        }

        public void Alta(Inmobiliaria inmobiliaria)
        {
            DataRow agregar = table.NewRow();
            agregar[0] = inmobiliaria.Id;
            agregar[1] = inmobiliaria.Nombre;
            agregar[2] = inmobiliaria.TotalRecaudado;
            table.Rows.Add(agregar);
            Guardar();
        }

        public void Modificar(Inmobiliaria inmobiliaria)
        {
            DataRow modificar = table.Rows.Find(inmobiliaria.Id);
            modificar[1] = inmobiliaria.Nombre;
            modificar[2] = inmobiliaria.TotalRecaudado;
            Guardar();
        }

        public void Eliminar(Inmobiliaria inmobiliaria)
        {
            table.Rows.Find(inmobiliaria.Id).Delete();
            Guardar();
        }

        public void Guardar()
        {
            adapter.Update(dataSet,"Inmobiliaria");
            table.AcceptChanges();
        }

        public List<VistaInmobiliaria> GetInmobiliarias()
        {
            List<VistaInmobiliaria> lista = new List<VistaInmobiliaria>();
            DataView view = new DataView(table, "", "", DataViewRowState.CurrentRows);
            foreach (DataRowView rowView in view)
            {
                DataRow row = rowView.Row;
                VistaInmobiliaria add = new VistaInmobiliaria(int.Parse(row[0].ToString()), row[1].ToString(), double.Parse(row[2].ToString()));
                lista.Add(add);
            }
            return lista;
        }
    }
}
