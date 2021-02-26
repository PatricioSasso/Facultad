using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Web.Script.Serialization;

namespace SassoDiploma2doParcialEj1
{
    class Curso : IEnumerator
    {
        List<Alumno> alumnos;
        string nombre;
        int pos;

        public Curso(List<Alumno> alumnos, string nombre)
        {
            this.alumnos = alumnos;
            this.nombre = nombre;
        }

        public object Current => Alumnos[pos];

        public List<Alumno> Alumnos { get => alumnos; }

        public bool MoveNext()
        {
            if (pos + 2 < Alumnos.Count)
            {
                pos++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            pos = 0;
        }

        public void Agregar(Alumno alumno)
        {
            if (Alumnos.Exists(a => a.Legajo == alumno.Legajo))
            {
                MessageBox.Show("Ya existe un alumno con ese legajo");
            }
            else
            {
                this.alumnos.Add(alumno);
            }
        }

        public void GuardarEnDiscoXML()
        {
            string raiz = AppDomain.CurrentDomain.BaseDirectory;
            if(!Directory.Exists(raiz + "\\" + this.nombre))
            {
                Directory.CreateDirectory( raiz + "\\" + this.nombre);
            }
            Parallel.ForEach(Alumnos, alumno => 
            {
                if(!File.Exists(raiz + "\\" + this.nombre + "\\" + alumno.Legajo + ".xml"))
                {
                    Stream crear = File.Create(raiz + "\\" + this.nombre + "\\" + alumno.Legajo + ".xml");
                    crear.Close();
                }
                Stream add = File.Create(raiz + "\\" + this.nombre + "\\" + alumno.Legajo + ".xml");
                XmlSerializer serializer = new XmlSerializer(alumno.GetType());
                serializer.Serialize(add, alumno);
                add.Close();
            });
        }

        public void GuardarEnDiscoJSON()
        {
            string raiz = AppDomain.CurrentDomain.BaseDirectory;
            if (!Directory.Exists(raiz + "\\" + this.nombre))
            {
                Directory.CreateDirectory(raiz + "\\" + this.nombre);
            }
            Parallel.ForEach(Alumnos, alumno =>
            {
                if (!File.Exists(raiz + "\\" + this.nombre + "\\" + alumno.Legajo + ".json"))
                {
                    Stream crear = File.Create(raiz + "\\" + this.nombre + "\\" + alumno.Legajo + ".json");
                    crear.Close();
                }
                Stream add = File.Create(raiz + "\\" + this.nombre + "\\" + alumno.Legajo + ".json");
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                string serializado = serializer.Serialize(alumno);
                add.Close();
                File.WriteAllText(raiz + "\\" + this.nombre + "\\" + alumno.Legajo + ".json", serializado);
            });
        }
    }
}
