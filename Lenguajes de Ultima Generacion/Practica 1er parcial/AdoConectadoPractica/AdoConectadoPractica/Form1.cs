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

namespace AdoConectadoPractica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source=MM;Initial Catalog=LUGAdoConecta2Practica;Integrated Security=True";

        private void Form1_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBox1.Text);
                string nombre = textBox2.Text;
                DateTime fecha_ingreso = DateTime.Parse(textBox3.Text);
                using(var connection = new SqlConnection())
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    using(var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"insert into Alumno(id,nombre,fecha_ingreso,activo)
                                                values (@id, @nombre, @fecha_ingreso,1)";
                        command.Parameters.AddWithValue("id", id);
                        command.Parameters.AddWithValue("nombre", nombre);
                        command.Parameters.AddWithValue("fecha_ingreso", fecha_ingreso);
                        command.ExecuteNonQuery();
                    }
                }
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
                int id = int.Parse(textBox1.Text);
                string nombre = textBox2.Text;
                DateTime fecha_ingreso = DateTime.Parse(textBox3.Text);
                using (var connection = new SqlConnection())
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    using(var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"Update Alumno set nombre = @nombre, fecha_ingreso = @fecha_ingreso,
                                                where id = @id and activo = 1";
                        command.Parameters.AddWithValue("id", id);
                        command.Parameters.AddWithValue("nombre", nombre);
                        command.Parameters.AddWithValue("fecha_ingreso", fecha_ingreso);
                        command.BeginExecuteNonQuery();
                        Mostrar();
                    }
                }
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
                int id = int.Parse(textBox1.Text);
                using(var connection = new SqlConnection())
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    using(var command = new SqlCommand())
                    {
                        command.CommandText = @"Update Alumno set activo = 0 where id = @id";
                        command.Parameters.AddWithValue("id", id);
                        command.ExecuteNonQuery();
                    }
                }
                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Mostrar()
        {
            dataGridView1.Rows.Clear();
            foreach(Alumno a in ObtenerLista())
            {
                dataGridView1.Rows.Add(a.id, a.nombre, a.fecha_ingreso);
            }
        }

        public List<Alumno> ObtenerLista()
        {
            List<Alumno> Alumnos = new List<Alumno>();
            using(var connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                using(var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"select * from Alumno ";
                    using(var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Alumnos.Add(new Alumno(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2)));
                        }
                    }
                }
            }
            return Alumnos;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Mostrar();
        }
    }

    public class Alumno
    {
        public int id;
        public string nombre;
        public DateTime fecha_ingreso;

        public Alumno(int id, string nombre, DateTime fecha_ingreso)
        {
            this.id = id;
            this.nombre = nombre;
            this.fecha_ingreso = fecha_ingreso;
        }
    }
}
