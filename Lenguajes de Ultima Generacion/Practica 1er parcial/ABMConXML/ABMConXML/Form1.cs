using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABMConXML
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
            Mostrar();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                G.AgregarAlumno(new Alumno(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text));
                Mostrar();
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
                Alumno modificar = (Alumno)dataGridView1.SelectedRows[0].DataBoundItem;
                modificar.Nombre = textBox2.Text;
                modificar.Apellido = textBox3.Text;
                G.ModificarAlumno(modificar);
                Mostrar();
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
                G.EliminarAlumno((Alumno)dataGridView1.SelectedRows[0].DataBoundItem);
                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Mostrar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = G.ListaAlumnos();
        }
    }
}
