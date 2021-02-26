using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace ABMConXML
{
    class Gestor
    {
        DataSet DataSet;
        DataTable DataTableAlumno;

        public Gestor()
        {
            DataSet = new DataSet();
            if (File.Exists("Datos.xml"))
            {
                DataSet.ReadXml("Datos.xml", XmlReadMode.ReadSchema);
            }
            else
            {
                DataTableAlumno = new DataTable("Alumno");
                DataTableAlumno.Columns.Add("Legajo", typeof(int));
                DataTableAlumno.Columns.Add("Nombre", typeof(string));
                DataTableAlumno.Columns.Add("Apellido", typeof(string));
                DataTableAlumno.PrimaryKey = new DataColumn[] { DataTableAlumno.Columns[0] };
                DataSet.Tables.Add(DataTableAlumno);
                DataSet.WriteXml("Datos.xml", XmlWriteMode.WriteSchema);
            }
        }

        public void AgregarAlumno(Alumno agregar)
        {
            DataRow DataRowAlumno = DataSet.Tables[0].NewRow();
            DataRowAlumno.ItemArray = new object[] { agregar.Legajo, agregar.Nombre, agregar.Apellido };
            DataSet.Tables[0].Rows.Add(DataRowAlumno);
            Guardar();
        }

        public void ModificarAlumno(Alumno modificar)
        {
            DataSet.Tables[0].Rows.Find(modificar.Legajo).ItemArray = new object[] { modificar.Legajo, modificar.Nombre, modificar.Apellido };
            Guardar();
        }

        public void EliminarAlumno(Alumno eliminar)
        {
            DataSet.Tables[0].Rows.Find(eliminar.Legajo).Delete();
            // DataSet.Tables[0].Rows.Remove(DataSet.Tables[0].Rows.Find(eliminar.Legajo));
            Guardar();
        }

        public void Guardar()
        {
            DataSet.WriteXml("Datos.xml", XmlWriteMode.WriteSchema);
        }

        public List<Alumno> ListaAlumnos()
        {
            List<Alumno> Alumnos = new List<Alumno>();
            foreach(DataRow r in DataSet.Tables[0].Rows)
            {
                Alumnos.Add(new Alumno(int.Parse(r.ItemArray[0].ToString()),r.ItemArray[1].ToString(),r.ItemArray[2].ToString()));
            }
            return Alumnos;
        }
    }
}
