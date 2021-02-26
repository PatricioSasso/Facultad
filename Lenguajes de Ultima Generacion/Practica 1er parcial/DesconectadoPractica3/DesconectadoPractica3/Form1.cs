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

namespace DesconectadoPractica3
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
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AutoGenerateColumns = true ;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            MostrarPersona();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(Interaction.InputBox("Ingrese el código de la persona"));
                string nombre = Interaction.InputBox("Ingrese el nombre de la persona");
                string apellido = Interaction.InputBox("Ingrese el apellido de la persona");
                G.AltaPersona(new Persona(codigo, nombre, apellido));
                MostrarPersona();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = (dataGridView1.SelectedRows[0].DataBoundItem as Persona).codigo;
                string nombre = Interaction.InputBox("Ingrese el nuevo nombre de la persona");
                string apellido = Interaction.InputBox("Ingrese el nuevo apellido de la persona");
                G.ModificarPersona(new Persona(codigo, nombre, apellido));
                MostrarPersona();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                G.BajaPersona(dataGridView1.SelectedRows[0].DataBoundItem as Persona);
                MostrarPersona();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void MostrarPersona()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = G.ListaPersona();
            label1.Text = dataGridView1.Rows.Count.ToString();
        }

        public void MostrarTelefono()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = G.ListaPersonaTelefono(dataGridView1.SelectedRows[0].DataBoundItem as Persona);
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MostrarTelefono();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(Interaction.InputBox("Ingrese el código de la persona"));
                string numero = Interaction.InputBox("Ingrese el numero de la persona");
                Persona persona = dataGridView1.SelectedRows[0].DataBoundItem as Persona;
                G.AltaTelefono(new Telefono(codigo, numero), persona);
                MostrarTelefono();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = (dataGridView2.SelectedRows[0].DataBoundItem as Telefono).codigo;
                string numero = Interaction.InputBox("Ingrese el nuevo numero de la persona");
                G.ModificarTelefono(new Telefono(codigo,numero));
                MostrarTelefono();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                G.BajaTelefono(dataGridView2.SelectedRows[0].DataBoundItem as Telefono);
                MostrarTelefono();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
