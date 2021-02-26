using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoDesconectadoConBdPractica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string connectionString = @"Data Source=MM;Initial Catalog=Gestion;Integrated Security=True";
        DataSet DataSet = new DataSet();
        static SqlDataAdapter AdapterAlumno = new SqlDataAdapter("Select * from Alumno", connectionString);
        static SqlDataAdapter AdapterTelefono = new SqlDataAdapter("Select * from Telefono", connectionString);
        SqlCommandBuilder CommandAlumno = new SqlCommandBuilder(AdapterAlumno);
        SqlCommandBuilder CommandTelefono = new SqlCommandBuilder(AdapterTelefono);
        MapperAlumno MapperAlumno = new MapperAlumno();
        MapperTelefono MapperTelefono = new MapperTelefono();

        private void Form1_Load(object sender, EventArgs e)
        {
            CommandAlumno.GetInsertCommand();
            CommandAlumno.GetUpdateCommand();
            CommandAlumno.GetDeleteCommand();
            AdapterAlumno.Fill(DataSet,"Alumno");
            CommandTelefono.GetInsertCommand();
            CommandTelefono.GetUpdateCommand();
            CommandTelefono.GetDeleteCommand();
            AdapterTelefono.Fill(DataSet,"Telefono");
            DataSet.Relations.Add(new DataRelation("AlumnoTelefono", DataSet.Tables[0].Columns[0], DataSet.Tables[1].Columns[2]));
            Mostrar();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                MapperAlumno.Agregar(DataSet, new Alumno(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, DateTime.Parse(textBox4.Text),true));
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
                MapperAlumno.Modificar(DataSet, new Alumno(modificar.Legajo, textBox2.Text, textBox3.Text, DateTime.Parse(textBox4.Text), true));
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
                Alumno eliminar = (Alumno)dataGridView1.SelectedRows[0].DataBoundItem;
                MapperAlumno.Eliminar(DataSet, eliminar);
                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Mostrar()
        {
            /*dataGridView1.Rows.Clear();
            foreach (Alumno a in MapperAlumno.ReturnLista(DataSet))
            {
                dataGridView1.Rows.Add(a.Legajo, a.Nombre, a.Apellido, a.FechaIngreso.ToShortDateString(), a.Activo);
            }*/
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = MapperAlumno.ReturnLista(DataSet);
        }

        public void Mostrar2()
        {
            dataGridView2.Rows.Clear();
            Alumno seleccionado = (Alumno)dataGridView1.SelectedRows[0].DataBoundItem;
            foreach (Telefono t in MapperAlumno.ReturnAlumnoTelefono(DataSet, seleccionado))
            {
                dataGridView2.Rows.Add(t.id, t.numero);
            }
        }

        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Mostrar2();
            }
            catch { }
        }
    }
}
