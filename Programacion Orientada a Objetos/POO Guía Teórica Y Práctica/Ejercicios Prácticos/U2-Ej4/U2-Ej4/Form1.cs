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

namespace U2_Ej4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Alumno> Alumnos = new List<Alumno>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

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
                int cant_notas = int.Parse(Interaction.InputBox("Ingrese la cantidad de notas del alumno"));
                decimal[] Notas = new decimal[cant_notas];
                if (cant_notas < 0) { throw new Exception("La nota no puede ser negativa"); }
                if (cant_notas != 0)
                {
                    for (int i = 0; i < cant_notas; i++)
                    {
                        Notas[i] = int.Parse(Interaction.InputBox("Ingrese la nota " + (i + 1) + " ."));
                    }
                }
                if (Alumnos.Exists(a => a.Legajo == Legajo))
                {
                    MessageBox.Show("El legajo ya está siendo utilizado");
                }
                else
                {
                    Alumnos.Add(new Alumno(Legajo, Nombre, Apellido, Notas));
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
                int cant_notas = int.Parse(Interaction.InputBox("Ingrese la cantidad de notas del alumno"));
                decimal[] NuevasNotas = new decimal[cant_notas];
                if (cant_notas < 0) { throw new Exception("La nota no puede ser negativa"); }
                if (cant_notas != 0)
                {
                    for (int i = 0; i < cant_notas; i++)
                    {
                        NuevasNotas[i] = int.Parse(Interaction.InputBox("Ingrese la nota " + (i + 1) + " ."));
                    }
                }
                if (Alumnos.Exists(a => a.Legajo == Legajo))
                {
                    Alumnos.Find(a => a.Legajo == Legajo).Modificar(NuevoNombre, NuevoApellido, NuevasNotas);
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

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int legajo = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            Alumno seleccionado = Alumnos.Find(a => a.Legajo == legajo);
            textBox1.Text = seleccionado.Promedio.ToString();
            seleccionado.Promedio10 += MensajeEventoPromedio10;
            seleccionado.PromedioMenorQue4 += MensajePromedioMenorQue4;
            seleccionado.CheckearPromedio();
        }

        public void MensajeEventoPromedio10(object sender, EventArgs e)
        {
            MessageBox.Show("El alumno tiene promedio 10. ¡Felicidades!");
        }

        public void MensajePromedioMenorQue4(object sender, PromedioMenorQue4 e)
        {
            MessageBox.Show(e.Mensaje());
        }
    }
}
