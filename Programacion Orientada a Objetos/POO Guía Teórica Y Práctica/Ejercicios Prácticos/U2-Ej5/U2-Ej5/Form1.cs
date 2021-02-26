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

namespace U2_Ej5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Alumno.Promedio10 += MensajeEventoPromedio10;
            Alumno.PromedioMenorQue4 += MensajePromedioMenorQue4;
        }

        public void MensajeEventoPromedio10(object sender, EventArgs e)
        {
            MessageBox.Show("El alumno tiene promedio 10. ¡Felicidades!");
        }

        public void MensajePromedioMenorQue4(object sender, PromedioMenorQue4 e)
        {
            MessageBox.Show(e.Mensaje());
        }

        List<Alumno> Alumnos = new List<Alumno>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Alumno.AgregarAlumno(Alumnos);
            CargarDataGrid1();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Alumno.ModificarAlumno(int.Parse(Interaction.InputBox("Ingrese el legajo del alumno que desea modificar")), Alumnos);
            CargarDataGrid1();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Alumno.EliminarAlumno(int.Parse(Interaction.InputBox("Ingrese el legajo del alumno que desea eliminar")), Alumnos);
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

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int legajo = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            Alumno seleccionado = Alumnos.Find(a => a.Legajo == legajo);
            textBox1.Text = seleccionado.Promedio.ToString();
            seleccionado.CheckearPromedio();
            textBox2.Text = Alumno.Universidad;
            textBox3.Text = Alumno.Ubicacion;
        }
    }
}
