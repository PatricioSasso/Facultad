using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL___ORM
{
    public class BaseDatos
    {
        string connectionString = "Data Source=MM;Initial Catalog=LUGPractica2doParcialADODesconecta2;Integrated Security=True";
        DataSet dataSet;
        SqlConnection conexion;

        SqlDataAdapter adapterInmobiliaria;
        SqlCommandBuilder builderInmobiliaria;
        DataTable tableInmobiliaria;

        public BaseDatos()
        {
            DataSet = new DataSet();
            conexion = new SqlConnection(connectionString);
            TableInmobiliaria = new DataTable("Inmobiliaria");
            AdapterInmobiliaria = new SqlDataAdapter("Select * From Inmobiliaria", conexion);
            builderInmobiliaria = new SqlCommandBuilder(AdapterInmobiliaria);
            AdapterInmobiliaria.InsertCommand = builderInmobiliaria.GetInsertCommand();
            AdapterInmobiliaria.UpdateCommand = builderInmobiliaria.GetUpdateCommand();
            AdapterInmobiliaria.DeleteCommand = builderInmobiliaria.GetDeleteCommand();
            DataSet.Tables.Add(TableInmobiliaria);
            AdapterInmobiliaria.Fill(DataSet, "Inmobiliaria");
        }

        public DataSet DataSet { get => dataSet; set => dataSet = value; }
        public SqlDataAdapter AdapterInmobiliaria { get => adapterInmobiliaria; set => adapterInmobiliaria = value; }
        public DataTable TableInmobiliaria { get => tableInmobiliaria; set => tableInmobiliaria = value; }
    }
}
