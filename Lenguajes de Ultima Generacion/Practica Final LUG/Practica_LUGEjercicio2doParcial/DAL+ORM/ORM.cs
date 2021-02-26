using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace DAL_ORM
{
    public class MapperPersona
    {
        DataSet dataSet;
        SqlDataAdapter adapter;
        DataTable table;

        public MapperPersona(DatabaseAccess dataBase)
        {
            dataSet = dataBase.DataSet;
            adapter = dataBase.AdapterPersona;
            table = dataSet.Tables["Persona"];
        }

        public void Alta(Persona persona)
        {
            DataRow agregar = table.NewRow();
            agregar["Id"] = persona.Id;
            agregar["Nombre"] = persona.Nombre;
            agregar["Apellido"] = persona.Apellido;
            agregar["FechaNacimiento"] = persona.FechaNacimiento;
            table.Rows.Add(agregar);
            Guardar();
        }

        public void Modificacion(Persona persona)
        {
            DataRow modificar = table.Rows.Find(persona.Id);
            modificar["Id"] = persona.Id;
            modificar["Nombre"] = persona.Nombre;
            modificar["Apellido"] = persona.Apellido;
            modificar["FechaNacimiento"] = persona.FechaNacimiento;
            Guardar();
        }

        public void Baja(Persona persona)
        {
            table.Rows.Find(persona.Id).Delete();
            Guardar();
        }

        void Guardar()
        {
            adapter.Update(dataSet, table.TableName);
            table.AcceptChanges();
        }

        public List<Persona> GetList()
        {
            List<Persona> lista = new List<Persona>();
            foreach (DataRow r in table.Rows)
            {
                Persona add = new Persona(int.Parse(r["Id"].ToString()), r["Nombre"].ToString(), 
                                          r["Apellido"].ToString(), DateTime.Parse(r["FechaNacimiento"].ToString()));
                lista.Add(add);
            }
            return lista;
        }

        public List<VistaPersona> GetListVista()
        {
            List<VistaPersona> lista = new List<VistaPersona>();
            foreach (Persona p in GetList())
            {
                VistaPersona add = new VistaPersona(p.Id,p.Nombre,p.Apellido,p.Edad,p);
                lista.Add(add);
            }
            return lista;
        }

        public List<VistaPersona> GetListVista(List<Persona> personas)
        {
            List<VistaPersona> lista = new List<VistaPersona>();
            foreach (Persona p in personas)
            {
                VistaPersona add = new VistaPersona(p.Id, p.Nombre, p.Apellido, p.Edad, p);
                lista.Add(add);
            }
            return lista;
        }

        public List<Persona> BuscarIncremental(string texto)
        {
            List<Persona> lista = new List<Persona>();
            foreach (DataRow r in DatabaseAccess.BuscarIncremental(texto).Rows)
            {
                Persona add = new Persona(int.Parse(r["Id"].ToString()), r["Nombre"].ToString(),
                                          r["Apellido"].ToString(), DateTime.Parse(r["FechaNacimiento"].ToString()));
                lista.Add(add);
            }
            return lista;
        }
    }
}
