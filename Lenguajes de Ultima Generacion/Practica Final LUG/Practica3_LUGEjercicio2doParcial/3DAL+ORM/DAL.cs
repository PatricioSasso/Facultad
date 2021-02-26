using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace _3DAL_ORM
{
    public class AccesoBD
    {
        string connectionString = "Data Source=MM;Initial Catalog=LUG2doParcialBD;Integrated Security=True";
        static SqlConnection conexion;
        DataSet set;
        SqlDataAdapter adapterPersona;
        SqlCommandBuilder builderPersona;

        public AccesoBD()
        {
            conexion = new SqlConnection(connectionString);
            Set = new DataSet();
            CrearTablePersona();
        }

        public DataSet Set { get => set; set => set = value; }
        public SqlDataAdapter AdapterPersona { get => adapterPersona; set => adapterPersona = value; }

        void CrearTablePersona()
        {
            AdapterPersona = new SqlDataAdapter("Select * from Persona", conexion);
            builderPersona = new SqlCommandBuilder(AdapterPersona);
            AdapterPersona.InsertCommand = builderPersona.GetInsertCommand();
            AdapterPersona.UpdateCommand = builderPersona.GetUpdateCommand();
            AdapterPersona.DeleteCommand = builderPersona.GetDeleteCommand();
            AdapterPersona.Fill(Set, "Persona");
            Set.Tables["Persona"].PrimaryKey = new DataColumn[] { Set.Tables["Persona"].Columns["Id"] };
        }

        public static DataTable BusquedaIncremental(string filtro)
        {
            SqlDataAdapter adapterConsulta = new SqlDataAdapter($"Select * from Persona where Persona.Nombre like '{ filtro }%'",conexion);
            DataTable tableConsulta = new DataTable();
            adapterConsulta.Fill(tableConsulta);
            return tableConsulta;
        }
    }
}
