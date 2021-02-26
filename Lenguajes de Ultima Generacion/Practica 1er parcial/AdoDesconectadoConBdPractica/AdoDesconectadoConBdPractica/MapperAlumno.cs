using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AdoDesconectadoConBdPractica
{
    class MapperAlumno
    {
        public MapperAlumno()
        {

        }

        public void Agregar(DataSet DataSet, Alumno alumno)
        {
            DataRow agregar = DataSet.Tables["Alumno"].NewRow();
            agregar.ItemArray = new object[] { alumno.Legajo, alumno.Nombre, alumno.Apellido, alumno.FechaIngreso, alumno.Activo };
            DataSet.Tables["Alumno"].Rows.Add(agregar);
        }

        public void Modificar(DataSet DataSet, Alumno alumno)
        {
            DataSet.Tables["Alumno"].Rows.Find(alumno.Legajo).ItemArray = new object[] { alumno.Legajo, alumno.Nombre, alumno.Apellido, alumno.FechaIngreso, alumno.Activo };
        }

        public void Eliminar(DataSet DataSet, Alumno alumno)
        {
            DataSet.Tables["Alumno"].Rows.Find(alumno.Legajo).Delete();
        }

        public List<Alumno> ReturnLista(DataSet DataSet)
        {
            List<Alumno> Alumnos = new List<Alumno>();
            foreach (DataRow r in DataSet.Tables["Alumno"].Rows)
            {
                Alumnos.Add(new Alumno(int.Parse(r.ItemArray[0].ToString()), r.ItemArray[1].ToString(), 
                                       r.ItemArray[2].ToString(), DateTime.Parse(r.ItemArray[3].ToString()),
                                       bool.Parse(r.ItemArray[4].ToString())));
            }
            return Alumnos;
        }

        public List<Telefono> ReturnAlumnoTelefono(DataSet DataSet, Alumno seleccionado)
        {
            List<Telefono> AlumnoTelefono = new List<Telefono>();
            foreach (DataRow t in DataSet.Tables[0].Rows.Find(seleccionado.Legajo).GetChildRows("AlumnoTelefono"))
            {
                AlumnoTelefono.Add(new Telefono(int.Parse(t.ItemArray[0].ToString()), t.ItemArray[1].ToString()));
            }
            return AlumnoTelefono;
        }
    }
}
