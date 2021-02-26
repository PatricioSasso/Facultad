using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL_Practica2doPLUG;
using BLL_Practica2doPLUG;

namespace ORM_Practica2doPLUG
{
    public class MapperInmueble
    {
        DataSet dataSet;
        SqlDataAdapter adapter;
        DataTable table;

        public DataSet DataSet { get => dataSet; set => dataSet = value; }
        public SqlDataAdapter Adapter { get => adapter; set => adapter = value; }
        public DataTable Table { get => table; set => table = value; }

        public MapperInmueble(BaseDatos baseDatos)
        {
            DataSet = baseDatos.DataSet;
            Adapter = baseDatos.AdapterInmueble;
            Table = baseDatos.TableInmueble;
            table.PrimaryKey = new DataColumn[] { table.Columns["Id"] };
        }

        public void Alta(Inmueble i, Inmobiliaria inmobiliaria)
        {
            DataRow agregar = Table.NewRow();
            agregar[0] = i.Id;
            agregar[1] = i.Direccion;
            agregar[2] = i.Valor;
            agregar[3] = i.FechaVenta;
            agregar[4] = i.FechaPublicacion;
            agregar[5] = inmobiliaria.Id;
            Table.Rows.Add(agregar);
            Guardar();
        }

        public void Modificacion(Inmueble i)
        {
            DataRow modificar = Table.Rows.Find(i.Id);
            modificar[1] = i.Direccion;
            modificar[2] = i.Valor;
            modificar[3] = i.FechaVenta;
            modificar[4] = i.FechaPublicacion;
            Guardar();
        }

        public void Baja(Inmueble i)
        {
            Table.Rows.Find(i.Id).Delete();
            Guardar();
        }

        public void Guardar()
        {
            Adapter.Update(DataSet,"Inmueble");
            Table.AcceptChanges();
        }

        public List<Inmueble> GetListInmueble()
        {
            List<Inmueble> lista = new List<Inmueble>();
            DataView view = new DataView(Table, "", "", DataViewRowState.CurrentRows);
            if(lista != null)
            {
                foreach (DataRowView rowView in view)
                {
                    DataRow row = rowView.Row;
                    Inmueble inmueble = new Inmueble(row[0].ToString(), row[1].ToString(), double.Parse(row[2].ToString()),
                                                     DateTime.Parse(row[3].ToString()), DateTime.Parse(row[4].ToString()));
                    lista.Add(inmueble);
                }
            }
            return lista;
        }
    }

    public class MapperInmobiliaria
    {
        DataSet dataSet;
        SqlDataAdapter adapter;
        DataTable table;

        public MapperInmobiliaria(BaseDatos baseDatos)
        {
            DataSet = baseDatos.DataSet;
            Adapter = baseDatos.AdapterInmobiliaria;
            Table = baseDatos.TableInmobiliaria;
            table.PrimaryKey = new DataColumn[] { table.Columns["Id"] };
        }

        public DataSet DataSet { get => dataSet; set => dataSet = value; }
        public SqlDataAdapter Adapter { get => adapter; set => adapter = value; }
        public DataTable Table { get => table; set => table = value; }

        public void Alta(Inmobiliaria i)
        {
            DataRow agregar = Table.NewRow();
            agregar[0] = i.Id;
            agregar[1] = i.Nombre;
            agregar[2] = i.TotalRecaudado;
            table.Rows.Add(agregar);
            Guardar();
        }

        public void Modificacion(Inmobiliaria i)
        {
            DataRow modificar = Table.Rows.Find(i.Id);
            modificar[1] = i.Nombre;
            modificar[2] = i.TotalRecaudado;
            Guardar();
        }

        public void Baja(Inmobiliaria i)
        {
            Table.Rows.Find(i.Id).Delete();
            Guardar();
        }

        public void Guardar()
        {
            Adapter.Update(DataSet,"Inmobiliaria");
            Table.AcceptChanges();
        }

        public List<Inmobiliaria> GetListInmobiliaria()
        {
            List<Inmobiliaria> lista = new List<Inmobiliaria>();
            DataView view = new DataView(Table, "", "", DataViewRowState.CurrentRows);
            if(lista != null)
            {
                foreach (DataRowView rowView in view)
                {
                    DataRow row = rowView.Row;
                    Inmobiliaria add = new Inmobiliaria(int.Parse(row[0].ToString()), row[1].ToString());
                    GetListInmobiliariaInmueble(add);
                    lista.Add(add);
                }
            }
            return lista;
        }

        public List<Inmueble> GetListInmobiliariaInmueble(Inmobiliaria i)
        {
            List<Inmueble> lista = new List<Inmueble>();
            DataRow[] rowInmueble = table.Rows.Find(i.Id).GetChildRows(DataSet.Relations["Inmobiliaria-Inmueble"]);
            if(lista != null)
            {
                foreach (DataRow row in rowInmueble)
                {
                    Inmueble inmueble = new Inmueble(row[0].ToString(), row[1].ToString(), double.Parse(row[2].ToString()),
                                                     DateTime.Parse(row[3].ToString()), DateTime.Parse(row[4].ToString()));
                    lista.Add(inmueble);
                }
            }
            return lista;
        }
    }
}
