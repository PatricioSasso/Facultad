using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_Practica2doPLUG
{
    public class BaseDatos
    {
        string connectionString = $@"Data Source=MM;Initial Catalog=LUGPractica2doParcialADODesconecta2;Integrated Security=True";
        DataSet dataSet;
        SqlConnection conexion;
        DataRelation relacion;

        SqlDataAdapter adapterInmobiliaria;
        SqlCommandBuilder builderInmobiliaria;
        DataTable tableInmobiliaria;

        SqlDataAdapter adapterInmueble;
        SqlCommandBuilder builderInmueble;
        DataTable tableInmueble;

        public BaseDatos()
        {
            DataSet = new DataSet();
            Conexion = new SqlConnection(connectionString);
            CrearTablaInmobiliaria();
            CrearTablaInmueble();
            CrearRelacion();
        }

        public DataSet DataSet { get => dataSet; set => dataSet = value; }
        public SqlConnection Conexion { get => conexion; set => conexion = value; }
        public SqlDataAdapter AdapterInmueble { get => adapterInmueble; set => adapterInmueble = value; }
        public SqlCommandBuilder BuilderInmueble { get => builderInmueble; set => builderInmueble = value; }
        public DataTable TableInmueble { get => tableInmueble; set => tableInmueble = value; }
        public SqlDataAdapter AdapterInmobiliaria { get => adapterInmobiliaria; set => adapterInmobiliaria = value; }
        public SqlCommandBuilder BuilderInmobiliaria { get => builderInmobiliaria; set => builderInmobiliaria = value; }
        public DataTable TableInmobiliaria { get => tableInmobiliaria; set => tableInmobiliaria = value; }
        public DataRelation Relacion { get => relacion; set => relacion = value; }

        public void CrearTablaInmueble()
        {
            TableInmueble = new DataTable("Inmueble");
            AdapterInmueble = new SqlDataAdapter("Select * from Inmueble", Conexion);
            BuilderInmueble = new SqlCommandBuilder(AdapterInmueble);
            AdapterInmueble.InsertCommand = BuilderInmueble.GetInsertCommand();
            AdapterInmueble.UpdateCommand = BuilderInmueble.GetUpdateCommand();
            AdapterInmueble.DeleteCommand = BuilderInmueble.GetDeleteCommand();
            DataSet.Tables.Add(TableInmueble);
            AdapterInmueble.Fill(DataSet, "Inmueble");
        }

        public void CrearTablaInmobiliaria()
        {
            TableInmobiliaria = new DataTable("Inmobiliaria");
            AdapterInmobiliaria = new SqlDataAdapter("Select * From Inmobiliaria", Conexion);
            BuilderInmobiliaria = new SqlCommandBuilder(AdapterInmobiliaria);
            AdapterInmobiliaria.InsertCommand = BuilderInmobiliaria.GetInsertCommand();
            AdapterInmobiliaria.UpdateCommand = BuilderInmobiliaria.GetUpdateCommand();
            AdapterInmobiliaria.DeleteCommand = BuilderInmobiliaria.GetDeleteCommand();
            DataSet.Tables.Add(TableInmobiliaria);
            AdapterInmobiliaria.Fill(DataSet, "Inmobiliaria");
        }

        public void CrearRelacion()
        {
            DataColumn padre = TableInmobiliaria.Columns["Id"];
            DataColumn hijo = TableInmueble.Columns["Inmueble_Inmobiliaria_Id"];
            relacion = new DataRelation("Inmobiliaria-Inmueble",padre,hijo);
            dataSet.Relations.Add(relacion);
        }

    }
}
