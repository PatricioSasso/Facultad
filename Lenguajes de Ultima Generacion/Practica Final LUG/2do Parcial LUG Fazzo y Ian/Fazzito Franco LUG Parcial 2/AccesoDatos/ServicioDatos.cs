using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class ServicioDatos
    {
        private SqlCommandBuilder command;
        private SqlDataAdapter adapter;
        private const string SELECT = "select * from persona;";
        private const string CONNECTION = @"Data Source=MM;Initial Catalog=LUG2doParcialBD;Integrated Security=True";

        public ServicioDatos()
        {
            adapter = new SqlDataAdapter(SELECT, CONNECTION);
            command = new SqlCommandBuilder(adapter);
            adapter.InsertCommand = command.GetInsertCommand();
            adapter.DeleteCommand = command.GetDeleteCommand();
            adapter.UpdateCommand = command.GetUpdateCommand();
        }

        public DataTable getTableSchema()
        { 
            adapter.SelectCommand.CommandText = SELECT;
            DataTable datatable = new DataTable();
            DataTable datatableSchema = adapter.FillSchema(datatable, SchemaType.Mapped);
            return datatableSchema;
        }

        public void guardar(DataTable datatable)
        {
            this.adapter.Update(datatable);
        }

        public DataTable Leer()
        {
            adapter.SelectCommand.CommandText = SELECT;
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            return datatable;
        }

        public DataTable LeerFiltro(string filtro)
        {
            adapter.SelectCommand.CommandText = $"select * from persona where persona.nombre like '{filtro}%'";
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            return datatable;
        }
    }
}
