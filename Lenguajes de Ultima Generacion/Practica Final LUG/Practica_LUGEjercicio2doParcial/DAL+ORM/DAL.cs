using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace DAL_ORM
{
    public class DatabaseAccess
    {
        string connection = @"Data Source=MM;Initial Catalog=LUG2doParcialBD;Integrated Security=True";
        DataSet dataSet;
        static SqlConnection conexion;

        SqlDataAdapter adapterPersona;
        SqlCommandBuilder builderPersona;

        public DatabaseAccess()
        {
            DataSet = new DataSet();
            conexion = new SqlConnection(connection);
            CreateTablePersona();
        }

        public DataSet DataSet { get => dataSet; set => dataSet = value; }
        public SqlDataAdapter AdapterPersona { get => adapterPersona; set => adapterPersona = value; }

        void CreateTablePersona()
        {
            AdapterPersona = new SqlDataAdapter("Select * from Persona", conexion);
            builderPersona = new SqlCommandBuilder(AdapterPersona);
            AdapterPersona.InsertCommand = builderPersona.GetInsertCommand();
            AdapterPersona.UpdateCommand = builderPersona.GetUpdateCommand();
            AdapterPersona.DeleteCommand = builderPersona.GetDeleteCommand();
            DataSet.Tables.Add("Persona");
            AdapterPersona.Fill(DataSet,"Persona");
            DataSet.Tables["Persona"].PrimaryKey = new DataColumn[] { DataSet.Tables["Persona"].Columns["Id"] };
        }

        static public DataTable BuscarIncremental(string texto)
        {
            SqlDataAdapter adapterIncremental = new SqlDataAdapter($"Select * from Persona where Persona.Nombre like '{texto}%'", conexion);
            DataTable incremental = new DataTable("Incremental");
            adapterIncremental.Fill(incremental);
            return incremental;
        }
    }
}
