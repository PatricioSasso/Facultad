using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace ADODesconectado3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
        }

		Gestor elgestor;

		private void Form1_Load(object sender, EventArgs e)
		{
			elgestor = new Gestor();
			DataPersonas();
			DataTelefono();
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		}

		private void DataTelefono()
		{
			dataGridView2.DataSource = null;
			dataGridView2.DataSource = elgestor.VerTelefonos();
		}

		private void DataPersonas()
		{
			dataGridView1.DataSource = null;
			dataGridView1.DataSource = elgestor.VerPersonas();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int c = int.Parse(textBox1.Text);
			string n = textBox2.Text;
			string a = textBox3.Text;

			Persona nueva = new Persona();
			nueva.Codigo = c; nueva.Nombre = n; nueva.Apellido = a;
			elgestor.AgregarPersona(nueva);
			textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";
			DataPersonas();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int c = int.Parse(textBox1.Text);
			string n = textBox2.Text;
			string a = textBox3.Text;
			Persona p = new Persona();
			p.Codigo = c; p.Nombre = n; p.Apellido = a;
			elgestor.EliminarPersona(p);
			textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";
			DataPersonas();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int c = int.Parse(textBox1.Text);
			string n = textBox2.Text;
			string a = textBox3.Text;
			Persona p = new Persona();
			p.Codigo = c; p.Nombre = n; p.Apellido = a;
			elgestor.ModificarPersona(p);
			textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";
			DataPersonas();
		}

		public Persona PersonDatagrid()
		{
			return dataGridView1.SelectedRows[0].DataBoundItem as Persona;
		}

		private void button6_Click(object sender, EventArgs e)
		{
			int c = int.Parse(Interaction.InputBox("Ingrese el codigo del telefono"));
			int n = int.Parse(Interaction.InputBox("Ingrese el numero de telefono"));
			Telefono t = new Telefono();
			t.Codigo = c; t.Numero = n;
			elgestor.AgregarTelefono(t, PersonDatagrid());
			DataTelefono();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			int c = int.Parse(Interaction.InputBox("Ingrese el codigo del telefono"));
			Telefono t = new Telefono();
			t.Codigo = c;
			elgestor.EliminarTelefono(t);
			DataTelefono();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			int c = int.Parse(Interaction.InputBox("Ingrese el codigo del telefono"));
			int n = int.Parse(Interaction.InputBox("Ingrese el numero de telefono"));
			Telefono t = new Telefono();
			t.Codigo = c; t.Numero = n;
			elgestor.ModificarTelefono(t);
			DataTelefono();

		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			dataGridView2.DataSource = null;
			Persona p = PersonDatagrid();
			dataGridView2.DataSource = elgestor.VerPersonaTelefonos(p);
		}

		private void button7_Click(object sender, EventArgs e)
		{
			Persona p = PersonDatagrid();
			foreach (Telefono t in elgestor.VerPersonaTelefonos(p))
			{
				elgestor.EliminarTelefono(t);
			}
		}
	}
}
