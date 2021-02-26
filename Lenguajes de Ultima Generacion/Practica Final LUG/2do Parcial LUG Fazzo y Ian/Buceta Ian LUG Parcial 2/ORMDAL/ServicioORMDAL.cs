using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Interfaces;
using Entities;


namespace ORMDAL
{
    public class ServicioORMDAL : IABMC<Persona>
    {
        DataSet Ds;
        SqlDataAdapter Da;
        SqlCommandBuilder Cb;
        DataTable Dt;
        public ServicioORMDAL()
        {
            Ds = new DataSet();
            Da = new SqlDataAdapter(Constantes.TABLAPERSONA_CONSULTATODOS, "Data Source=342-27-84597\\SQL_UAI;Initial Catalog=Parcial2LUG;Integrated Security=True");
            Cb = new SqlCommandBuilder(Da);

            Da.InsertCommand = Cb.GetInsertCommand();
            Da.UpdateCommand = Cb.GetUpdateCommand();
            Da.DeleteCommand = Cb.GetDeleteCommand();

            Da.Fill(Ds, Constantes.TABLAPERSONA_NOMBRE);
            Dt = Ds.Tables[Constantes.TABLAPERSONA_NOMBRE];
            Dt.PrimaryKey = new DataColumn[] { Dt.Columns[Constantes.PERSONA_ID] };
        }

        public void Alta(Persona objeto)
        {
            DataRow Dr = Dt.NewRow();
            Dr.ItemArray = new object[] { objeto.GetId(), objeto.Nombre, objeto.Apellido, objeto.GetFechaDeNacimiento() };
            Dt.Rows.Add(Dr);
        }

        public void Baja(Persona objeto)
        {
            Dt.Rows.Find(objeto.GetId()).Delete();
        }

        public void Modificacion(Persona objeto)
        {
            DataRow Dr = Dt.Rows.Find(objeto.GetId());
            Dr.ItemArray = new object[] { objeto.GetId(), objeto.Nombre, objeto.Apellido, objeto.GetFechaDeNacimiento() };
        }

        public Persona Consulta(int idObjeto)
        {
            DataRow Dr = Dt.Rows.Find(idObjeto);
            Persona persona = new Persona(Dr.Field<int>(0), Dr.Field<string>(1), Dr.Field<string>(2), Dr.Field<DateTime>(3));
            return persona;
        }

        public List<Persona> ConsultaTodos()
        {
            List<Persona> Personas = new List<Persona>();
            DataView Dv = new DataView(Dt, "", "", DataViewRowState.CurrentRows);
            foreach (DataRowView DrV in Dv)
            {
               Personas.Add(new Persona(DrV.Row.Field<int>(0), DrV.Row.Field<string>(1), DrV.Row.Field<string>(2), DrV.Row.Field<DateTime>(3)));
            }
            return Personas;
        }

        public void Guardar()
        {
            Da.Update(Dt);
        }

        public List<Persona> ConsultaFiltro(string filtro)
        {
            //Da.SelectCommand = new SqlCommand($"select * from Persona where Per_Nombre like { filtro }", "Data Source=342-27-84597\\SQL_UAI;Initial Catalog=Parcial2LUG;Integrated Security=True");
            //Da.Fill(Ds, "Persona");
            return ConsultaTodos();
        }
    }
}
