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

namespace PracticaAdoDesconecta2ConBD2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Gestor G = new Gestor();

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;
                dataGridView1.AutoGenerateColumns = true;
                dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView2.MultiSelect = false;
                dataGridView1.AutoGenerateColumns = true;
                MostrarAlumnos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                G.AltaAlumno(new Alumno(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, DateTime.Parse(textBox4.Text), true));
                MostrarAlumnos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                Alumno modificar = dataGridView1.SelectedRows[0].DataBoundItem as Alumno;
                string nombre = Interaction.InputBox("Ingrese el nuevo nombre");
                string apellido = Interaction.InputBox("Ingrese el nuevo apelido");
                DateTime fechaIngreso = DateTime.Parse(Interaction.InputBox("Ingrese la nueva fecha de ingreso"));
                G.ModificarAlumno(new Alumno(modificar.legajo, nombre, apellido, fechaIngreso, modificar.activo));
                MostrarAlumnos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                G.EliminarAlumno(dataGridView1.SelectedRows[0].DataBoundItem as Alumno);
                MostrarAlumnos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void MostrarAlumnos()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = G.dataSet.Tables[0];
        }

        private void DataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int legajo = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            string nombre = "A"; string apellido = "A"; DateTime fecha = DateTime.Now; bool activo = true;
            Alumno seleccionado = new Alumno(legajo, nombre, apellido, fecha, activo);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = G.RetornarListaAlumnoTelefono(seleccionado);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarAlumnos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
