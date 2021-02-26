using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using Entities;
using BLL;

namespace VL
{
    public partial class Form1 : Form
    {
        GestorPersonas gestorPersonas;
        public Form1()
        {
            InitializeComponent();
            gestorPersonas = new GestorPersonas();
        }

        public Persona PersonaSeleccionada()
        {
            return dataGridView1.SelectedRows[0].DataBoundItem as Persona;
        }
        public void Mostrar()
        {
            List<Persona> Personas = gestorPersonas.ConsultaTodos();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Personas;
            GenerarGraficos(Personas);
        }

        private void GenerarGraficos(List<Persona> personas)
        {
            if(personas.Count != 0)
            {
                Graphics gr = this.CreateGraphics();
                Random r = new Random(DateTime.Now.Millisecond);
                float offsetX = 0;
                gr.Clear(BackColor);
                for (int i = 0; i < 120; i += 10)
                {
                    SolidBrush Sb = new SolidBrush(Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255)));
                    float AltoMaximo = personas.FindAll(x => x.Edad >= i && x.Edad <= i + 10).Count * 100 / personas.Count;
                    gr.FillRectangle(Sb, 550 + offsetX, 280 - AltoMaximo, 20, AltoMaximo);
                    gr.DrawString($"{i}-{i + 10}", new Font("Arial", 12), Sb, 545 + offsetX, 285);
                    offsetX += 50;
                }
                gr.Dispose();
            }            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Mostrar();
        }
        private void buttonAlta_Click(object sender, EventArgs e)
        {
            try
            {
                string Nombre = textBoxNombre.Text;
                string Apellido = textBoxNombre.Text;
                if (controlFechaDeNacimiento1.ComprobarFechaDeNacimiento() == false) throw new Exception("Para que la fecha sea válida debe:\nTener formato de fecha: DD/MM/AAAA \nSer menor o igual a la fecha actual.");
                DateTime FechaDeNacimiento = DateTime.Parse(controlFechaDeNacimiento1.Controls["textBoxFechaDeNacimiento"].Text);
                gestorPersonas.Alta(new Persona(Nombre, Apellido, FechaDeNacimiento));
                Mostrar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBaja_Click(object sender, EventArgs e)
        {
            try
            {
                gestorPersonas.Baja(PersonaSeleccionada());
                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonModificacion_Click(object sender, EventArgs e)
        {
            try
            {
                PersonaSeleccionada().Nombre = textBoxNombre.Text;
                PersonaSeleccionada().Apellido = textBoxApellido.Text;
                if (controlFechaDeNacimiento1.ComprobarFechaDeNacimiento() == false) throw new Exception("Para que la fecha sea válida debe:\nTener formato de fecha: DD/MM/AAAA \nSer menor o igual a la fecha actual.");
                PersonaSeleccionada().SetFechaDeNacimiento(DateTime.Parse(controlFechaDeNacimiento1.Controls["textBoxFechaDeNacimiento"].Text));
                gestorPersonas.Modificacion(PersonaSeleccionada());
                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                gestorPersonas.Guardar();
                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonOrdenar_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                if (radioButton1.Checked == true)
                {
                    dataGridView1.DataSource = gestorPersonas.Ordenar(true);

                }
                else
                {
                    dataGridView1.DataSource = gestorPersonas.Ordenar(false);
                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBoxNombre.Text = PersonaSeleccionada().Nombre;
                textBoxApellido.Text = PersonaSeleccionada().Apellido;
                controlFechaDeNacimiento1.Controls["textBoxFechaDeNacimiento"].Text = PersonaSeleccionada().GetFechaDeNacimiento().ToShortDateString();
                GenerarGraficos(gestorPersonas.ConsultaTodos());
                MessageBox.Show(gestorPersonas.Consulta(PersonaSeleccionada().GetId()).ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
