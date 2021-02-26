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

namespace ADOConectado3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		string connectionstring= @"Data Source=.;Initial Catalog = BasePractica; Integrated Security = True";

		private void Form1_Load(object sender, EventArgs e)
		{
			dataGridView1.MultiSelect = false;
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			int c = int.Parse(textBox1.Text);
			string nom = textBox2.Text;
			string ap = textBox3.Text;
			using (SqlConnection conexion= new SqlConnection(connectionstring))
			{
				conexion.Open();
				using (SqlCommand command= new SqlCommand())
				{
					command.Connection = conexion;
					command.CommandText= "insert into Cliente values (@codigo_cliente, @nombrecli, @apellidocli)";
					command.Parameters.AddWithValue("@codigo_cliente", c);
					command.Parameters.AddWithValue("@nombrecli", nom);
					command.Parameters.AddWithValue("@apellidocli", ap);
					command.ExecuteNonQuery();
				}
			}
			textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int c = int.Parse(Interaction.InputBox("Ingrese el codigo de la persona a eliminar"));
			using (SqlConnection conexion = new SqlConnection(connectionstring))
			{
				conexion.Open();
				using (SqlCommand comando = new SqlCommand())
				{
					comando.Connection = conexion;
					comando.CommandText = "delete from Cliente where codigo_cliente = @codigo_cliente";
					comando.Parameters.AddWithValue("@codigo_cliente", c);
					comando.ExecuteNonQuery();
				}
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int c = int.Parse(Interaction.InputBox("Ingrese el codigo del cliente a modificar"));
			string nom = Interaction.InputBox("Ingrese el nombre del cliente a modificar");
			string ap = Interaction.InputBox("Ingrese el apellido del cliente a modificar");
			using (SqlConnection conexion= new SqlConnection(connectionstring))
			{
				conexion.Open();
				using (SqlCommand command= new SqlCommand())
				{
					command.Connection = conexion;
					command.CommandText = "update Cliente set codigo_cliente= @codigo_cliente, nombrecli= @nombrecli, apellidocli= @apellidocli where codigo_cliente= @codigo_cliente";
					command.Parameters.AddWithValue("@codigo_cliente", c);
					command.Parameters.AddWithValue("@nombrecli", nom);
					command.Parameters.AddWithValue("@apellidocli", ap);
					command.ExecuteNonQuery();
				}
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			List<Cliente> losclientes= new List<Cliente>();
			using (SqlConnection conexion= new SqlConnection(connectionstring))
			{
				conexion.Open();
				using (SqlCommand command= new SqlCommand())
				{
					command.Connection = conexion;
					command.CommandText = "select * from Cliente";
					using (SqlDataReader reader= command.ExecuteReader())
					{
						while(reader.Read())
						{
							int c = reader.GetInt32(0);
							string nom = reader.GetString(1);
							string ap = reader.GetString(2);
							Cliente a = new Cliente();
							a.Codigo = c; a.Nombre = nom; a.Apellido = ap;
							losclientes.Add(a);
						}
					}
				}
			}
			MostrarData(losclientes);
		}

		public void MostrarData(List<Cliente> lp)
		{
			dataGridView1.DataSource = null;
			dataGridView1.DataSource = lp;
		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{
			List<Cliente> vercliente = new List<Cliente>();
			string filtro = textBox4.Text + "%";
			using (SqlConnection conexion = new SqlConnection(connectionstring))
			{
				conexion.Open();
				using (SqlCommand command = new SqlCommand())
				{
					command.Connection = conexion;
					command.CommandText = "select * from Cliente where nombrecli like @nombrecli";
					command.Parameters.AddWithValue("@nombrecli", filtro);
					using (SqlDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							int c = reader.GetInt32(0);
							string n = reader.GetString(1);
							string a = reader.GetString(2);
							Cliente cli = new Cliente();
							cli.Codigo = c; cli.Nombre = n; cli.Apellido = a;
							vercliente.Add(cli);
						}
					}
				}
			}
			MostrarData(vercliente);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			
		}
	}
	public class Cliente
	{
		public int Codigo { get; set; }
		public string Nombre { get; set; }
		public string Apellido { get; set; }
	}
}
