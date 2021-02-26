using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL


{
    public class DALServicio
    {
        DataSet DS;
        SqlDataAdapter DA;
        SqlCommandBuilder CB;

        public DALServicio()
        {
            DS = new DataSet("Prueba");
            DA = new SqlDataAdapter("Select * from Persona", "Data Source=.;Initial Catalog=Prueba;Integrated Security=True");
            CB = new SqlCommandBuilder(DA);
            DA.InsertCommand = CB.GetInsertCommand();
            DA.UpdateCommand = CB.GetUpdateCommand();
            DA.DeleteCommand = CB.GetDeleteCommand();
        }
        public DataTable RetornaDataTableVacio(string pPersona)
        {
            DA.SelectCommand.CommandText = $"Select * from {pPersona}";
            DataTable DT = new DataTable();
            return DA.FillSchema(DT, SchemaType.Mapped);
        }
        public void Guardar(DataTable pDT)
        {
            DA.Update(pDT);
        }
        public DataTable Leer(string pSQL)
        {
            DataTable DT = new DataTable();
            DA.SelectCommand.CommandText = pSQL;
            DA.Fill(DT);
            return DT;
        }
    }
}
