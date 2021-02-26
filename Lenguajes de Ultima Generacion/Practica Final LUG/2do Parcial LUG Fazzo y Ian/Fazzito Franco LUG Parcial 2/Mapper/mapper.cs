using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using AccesoDatos;
using Interfaces;
using Entidades;

namespace Mapper
{
    public class mapper : IABMC_Generico<Persona>
    {
        private ServicioDatos servicioDatos;

        public mapper()
        {
            servicioDatos = new ServicioDatos();
        }
        public void Alta(Persona value)
        {
            DataTable datatable = servicioDatos.getTableSchema();
            DataRow row = datatable.NewRow();
            row[Campos.id] = value.Id;
            row[Campos.nombre] = value.Nombre;
            row[Campos.apellido] = value.Apellido;
            row[Campos.fecha] = value.FechaNacimiento;
            datatable.Rows.Add(row);
            servicioDatos.guardar(datatable);
        }

        public void Baja(Persona value)
        {
            DataTable datatable = servicioDatos.Leer();
            datatable.PrimaryKey = new DataColumn[] { datatable.Columns[Campos.id] };
            datatable.Rows.Find(value.Id).Delete();
            servicioDatos.guardar(datatable);
        }

        public List<Persona> Consultar()
        {
            DataTable datatable = servicioDatos.Leer();
            List<Persona> personas = new List<Persona>();
            foreach (DataRow row in datatable.Rows)
            {
                Persona persona = new Persona();
                persona.Id = Convert.ToInt32(row[Campos.id]);
                persona.Nombre = Convert.ToString(row[Campos.nombre]);
                persona.Apellido = Convert.ToString(row[Campos.apellido]);
                persona.FechaNacimiento = Convert.ToDateTime(row[Campos.fecha]);
                personas.Add(persona);
            }
            return personas;
        }

        public List<Persona> ConsultarFiltro(string filtro)
        {
            DataTable datatable = servicioDatos.LeerFiltro(filtro);
            List<Persona> personas = new List<Persona>();
            foreach (DataRow row in datatable.Rows)
            {
                Persona persona = new Persona();
                persona.Id = Convert.ToInt32(row[Campos.id]);
                persona.Nombre = Convert.ToString(row[Campos.nombre]);
                persona.Apellido = Convert.ToString(row[Campos.apellido]);
                persona.FechaNacimiento = Convert.ToDateTime(row[Campos.fecha]);
                personas.Add(persona);
            }
            return personas;
        }

        public void Modificacion(Persona value)
        {
            DataTable datatable = servicioDatos.Leer();
            datatable.PrimaryKey = new DataColumn[] { datatable.Columns[Campos.id] };
            DataRow row = datatable.Rows.Find(value.Id);
            row[Campos.nombre] = value.Nombre;
            row[Campos.apellido] = value.Apellido;
            row[Campos.fecha] = value.FechaNacimiento;
            servicioDatos.guardar(datatable);
        }
    }

    public static class Campos
    {
        public const string id = "id";
        public const string nombre = "nombre";
        public const string apellido = "apellido";
        public const string fecha = "fechaNacimiento";
    }
}
