using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ORM___DAL
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
            CreateTablePersona();
        }

        public DataSet Set { get => set; set => set = value; }
        public SqlDataAdapter AdapterPersona { get => adapterPersona; set => adapterPersona = value; }

        void CreateTablePersona()
        {
            AdapterPersona = new SqlDataAdapter("Select * from Persona", conexion);
            builderPersona = new SqlCommandBuilder(AdapterPersona);
            AdapterPersona.InsertCommand = builderPersona.GetInsertCommand();
            AdapterPersona.UpdateCommand = builderPersona.GetUpdateCommand();
            AdapterPersona.DeleteCommand = builderPersona.GetDeleteCommand();
            AdapterPersona.Fill(Set, "Persona");
            set.Tables["Persona"].PrimaryKey = new DataColumn[] { set.Tables["Persona"].Columns["Id"] };
        }

        static public DataTable BusquedaFiltro(string texto)
        {
            SqlDataAdapter adapterFiltro = new SqlDataAdapter($"Select * from Persona where Persona.Nombre like '{ texto }%'",conexion);
            DataTable tableFiltro = new DataTable("Filtro");
            adapterFiltro.Fill(tableFiltro);
            return tableFiltro;
        }
    }
}
