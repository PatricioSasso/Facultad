using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PracticaAdoDesconecta2ConBD2
{
    class Gestor
    {
        string connectionString = @"Data Source=MM;Initial Catalog=Gestion;Integrated Security=True";
        public DataSet dataSet;
        SqlConnection conexion;
        DataRelation RelacionAlumnoTelefono;

        SqlDataAdapter adapterAlumno;
        SqlCommandBuilder commandAlumno;
        DataView viewAlumno;
        DataTable TableAlumno;

        SqlDataAdapter adapterTelefono;
        SqlCommandBuilder commandTelefono;
        DataView viewTelefono;

        public Gestor()
        {
            dataSet = new DataSet();
            conexion = new SqlConnection(connectionString);
            CrearTableAlumno();
            CrearTableTelefono();
            CrearRelacionAlumnoTelefono();
        }

        private void CrearTableAlumno()
        {
            TableAlumno = new DataTable("Alumno");
            adapterAlumno = new SqlDataAdapter("Select * from Alumno", conexion);
            commandAlumno = new SqlCommandBuilder(adapterAlumno);
            adapterAlumno.InsertCommand = commandAlumno.GetInsertCommand();
            adapterAlumno.UpdateCommand = commandAlumno.GetUpdateCommand();
            adapterAlumno.DeleteCommand = commandAlumno.GetDeleteCommand();
            dataSet.Tables.Add(TableAlumno);
            adapterAlumno.Fill(dataSet, "Alumno");
            dataSet.Tables[0].PrimaryKey = new DataColumn[] { dataSet.Tables[0].Columns[0] };
        }

        private void CrearTableTelefono()
        {
            adapterTelefono = new SqlDataAdapter("Select * from Telefono", conexion);
            commandTelefono = new SqlCommandBuilder(adapterTelefono);
            adapterTelefono.InsertCommand = commandTelefono.GetInsertCommand();
            adapterTelefono.UpdateCommand = commandTelefono.GetUpdateCommand();
            adapterTelefono.DeleteCommand = commandTelefono.GetDeleteCommand();
            adapterTelefono.Fill(dataSet, "Telefono");
        }

        private void CrearRelacionAlumnoTelefono()
        {
            DataColumn padre = dataSet.Tables[0].PrimaryKey[0];
            DataColumn hijo = dataSet.Tables[1].Columns["Tel_Alu_Legajo"];
            RelacionAlumnoTelefono = new DataRelation("AlumnoTelefono", padre, hijo);
            dataSet.Relations.Add(RelacionAlumnoTelefono);
        }

        public void AltaAlumno(Alumno alumno)
        {
            DataRow agregar = dataSet.Tables[0].NewRow();
            agregar.ItemArray = new object[] { alumno.legajo, alumno.nombre, alumno.apellido, alumno.fecha_ingreso, alumno.activo };
            dataSet.Tables[0].Rows.Add(agregar);
        }

        public void ModificarAlumno(Alumno alumno)
        {
            dataSet.Tables[0].Rows.Find(alumno.legajo).ItemArray = new object[] { alumno.legajo, alumno.nombre, alumno.apellido, alumno.fecha_ingreso, alumno.activo };
        }

        public void EliminarAlumno(Alumno alumno)
        {
            dataSet.Tables[0].Rows.Find(alumno.legajo).Delete();
        }

        public List<Alumno> RetornaListaAlumnos()
        {
            List<Alumno> alumnos = new List<Alumno>();
            viewAlumno = new DataView(dataSet.Tables[0],"","",DataViewRowState.CurrentRows);
            foreach (DataRowView dataRow in viewAlumno)
            {
                DataRow row = dataRow.Row;
                alumnos.Add(new Alumno(int.Parse(row[0].ToString()), row[1].ToString(), row[2].ToString(), DateTime.Parse(row[3].ToString()), bool.Parse(row[4].ToString())));
            }
            return alumnos;
        }

        public List<Telefono> RetornarListaAlumnoTelefono(Alumno alumno)
        {
            List<Telefono> telefonos = new List<Telefono>();
            DataRow[] rowTelefonos = dataSet.Tables[0].Rows.Find(alumno.legajo).GetChildRows("AlumnoTelefono");
            foreach (DataRow row in rowTelefonos)
            {
                telefonos.Add(new Telefono(int.Parse(row[0].ToString()), row[1].ToString()));
            }
            telefonos.Add(new Telefono(1, "ANDA"));
            return telefonos;
        }

    }
}
