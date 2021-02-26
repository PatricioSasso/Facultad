using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace U5_Ej3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        List<Alumno> Alumnos = new List<Alumno>();

        private void Button1_Click(object sender, EventArgs e)
        {
            AgregarAlumno();
            CargarDataGrid1();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ModificarAlumno(int.Parse(Interaction.InputBox("Ingrese el legajo del alumno que desea modificar")));
            CargarDataGrid1();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            EliminarAlumno(int.Parse(Interaction.InputBox("Ingrese el legajo del alumno que desea eliminar")));
            CargarDataGrid1();
        }

        private void CargarDataGrid1()
        {
            dataGridView1.Rows.Clear();
            foreach (var a in Alumnos)
            {
                dataGridView1.Rows.Add(a.Legajo, a.Nombre, a.Apellido);
            }
        }

        public void AgregarAlumno()
        {
            try
            {
                int Legajo = int.Parse(Interaction.InputBox("Ingrese el legajo del alumno"));
                string Nombre = Interaction.InputBox("Ingrese el nombre del alumno");
                string Apellido = Interaction.InputBox("Ingrese el apellido del alumno");
                int Promedio = int.Parse(Interaction.InputBox("Ingrese el promedio del alumno"));
                if (Alumnos.Exists(a => a.Legajo == Legajo))
                {
                    MessageBox.Show("El legajo ya está siendo utilizado");
                }
                else
                {
                    Alumnos.Add(new Alumno(Legajo, Nombre, Apellido, Promedio));
                    MessageBox.Show("Alumno agregado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void EliminarAlumno(int Legajo)
        {
            try
            {
                if (Alumnos.Exists(a => a.Legajo == Legajo))
                {
                    Alumnos.Remove(Alumnos.Find(a => a.Legajo == Legajo));
                    MessageBox.Show("Alumno eliminado");
                }
                else
                {
                    MessageBox.Show("No existe ningún alumno con ese legajo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ModificarAlumno(int Legajo)
        {
            try
            {
                string NuevoNombre = Interaction.InputBox("Ingrese el nombre del alumno");
                string NuevoApellido = Interaction.InputBox("Ingrese el apellido del alumno");
                int NuevoPromedio = int.Parse(Interaction.InputBox("Ingrese el promedio del alumno"));
                if (Alumnos.Exists(a => a.Legajo == Legajo))
                {
                    Alumnos.Find(a => a.Legajo == Legajo).Modificar(NuevoNombre, NuevoApellido, NuevoPromedio);
                    MessageBox.Show("Alumno modificado");
                }
                else
                {
                    MessageBox.Show("No existe ningún alumno con ese legajo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
