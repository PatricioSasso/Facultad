using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using _2BLL;

namespace _3DAL_ORM
{
    public class MapperPersona
    {
        DataSet set;
        SqlDataAdapter adapter;
        DataTable table;

        public MapperPersona(AccesoBD accesoBD)
        {
            set = accesoBD.Set;
            adapter = accesoBD.AdapterPersona;
            table = set.Tables["Persona"];
        }

        public void Alta(Persona p)
        {
            DataRow agregar = table.NewRow();
            agregar["Id"] = p.Id;
            agregar["Nombre"] = p.Nombre;
            agregar["Apellido"] = p.Apellido;
            agregar["FechaNacimiento"] = p.FechaNacimiento;
            table.Rows.Add(agregar);
            Guardar();
        }

        public void Modificacion(Persona p)
        {
            DataRow modificar = table.Rows.Find(p.Id);
            modificar["Nombre"] = p.Nombre;
            modificar["Apellido"] = p.Apellido;
            modificar["FechaNacimiento"] = p.FechaNacimiento;
            Guardar();
        }

        public void Baja(Persona p)
        {
            table.Rows.Find(p.Id).Delete();
            Guardar();
        }

        void Guardar()
        {
            adapter.Update(set, "Persona");
            table.AcceptChanges();
        }

        public List<Persona> GetList()
        {
            List<Persona> lista = new List<Persona>();
            foreach (DataRow r in table.Rows)
            {
                Persona add = new Persona(int.Parse(r["Id"].ToString()),r["Nombre"].ToString(), r["Apellido"].ToString(), DateTime.Parse(r["FechaNacimiento"].ToString()));
                lista.Add(add);
            }
            return lista;
        }

        public List<Persona> GetList(string filtro)
        {
            List<Persona> lista = new List<Persona>();
            foreach (DataRow r in AccesoBD.BusquedaIncremental(filtro).Rows)
            {
                Persona add = new Persona(int.Parse(r["Id"].ToString()), r["Nombre"].ToString(), r["Apellido"].ToString(), DateTime.Parse(r["FechaNacimiento"].ToString()));
                lista.Add(add);
            }
            return lista;
        }

        public List<VistaPersona> GetListVista(List<Persona> personas)
        {
            List<VistaPersona> lista = new List<VistaPersona>();
            foreach (Persona p in personas)
            {
                VistaPersona add = new VistaPersona(p);
                lista.Add(add);
            }
            return lista;
        }
    }
}
