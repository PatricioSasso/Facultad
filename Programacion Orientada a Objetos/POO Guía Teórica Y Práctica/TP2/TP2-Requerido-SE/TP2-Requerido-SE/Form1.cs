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

namespace TP2_Requerido_SE
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			universidad = new Universidad();
		}

		Universidad universidad;
		public void CapturarEvento(object o, EventArgs a)
		{
			MessageBox.Show("Evento Promedio: " + a.ToString());
		}
		public void AñadirEvento()
		{
			universidad.PromedioEvent += CapturarEvento;
		}
		private void button1_Click(object sender, EventArgs e)
		{
			universidad.AgregarAlumno();
			MostrarAlumnos();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			universidad.ModificarAlumno();
			MostrarAlumnos();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			universidad.EliminarAlumno();
			MostrarAlumnos();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			int a = int.Parse(Interaction.InputBox("Ingrese el código de la materia"));
			string nombre = Interaction.InputBox("Ingrese el nombre de la materia");
			universidad.AgregarMateriaBasicaaX(a, nombre);
		}

		private void button7_Click(object sender, EventArgs e)
		{
			int a = int.Parse(Interaction.InputBox("Ingrese el código de la materia"));
			string nombre = Interaction.InputBox("Ingrese el nombre de la materia");
			universidad.AgregarMateriaEspaX(a, nombre);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			universidad.ModificarMateriadeX();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			universidad.BorrarMateriadeX();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
		public void MostrarAlumnos()
		{
			dataGridView1.Rows.Clear();
			foreach( Alumno a in universidad.listalumos())
			{
				dataGridView1.Rows.Add(a.LEGAJOALUMNO, a.APELLIDOALUMNO, a.NOMBREALUMNO);
			}
		}

		private void button8_Click(object sender, EventArgs e)
		{
			universidad.OrdenarAsc();
			MostrarAlumnos();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			universidad.OrdenarDesc();
			MostrarAlumnos();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			MostrarMaterias();
		}

		public void MostrarMaterias()
		{
			int fila = dataGridView1.CurrentCell.RowIndex;
			Alumno buscado = universidad.listalumos()[fila];
			int legajobuscado = buscado.LEGAJOALUMNO;
			//Aprobadas
			dataGridView2.Rows.Clear();
			List<Materia> aprobadas = universidad.MateriasAprobadas(legajobuscado);
			if(aprobadas.Count>0)
			{
				foreach(Materia a in aprobadas)
				{
					dataGridView2.Rows.Add(a.CODIGOMATERIA, a.NOMBREMATERIA);
				}
			}
			//Desaprobadas
			dataGridView3.Rows.Clear();
			List<Materia> desaprobadas = universidad.MateriasDesaprobadas(legajobuscado);
			if(desaprobadas.Count>0)
			{
				foreach(Materia a in desaprobadas)
				{
					dataGridView3.Rows.Add(a.CODIGOMATERIA, a.NOMBREMATERIA);
				}
			}
			//Cursando
			dataGridView4.Rows.Clear();
			List<Materia> cursando = universidad.MateriasCursando(legajobuscado);
			if(cursando.Count>0)
			{
				foreach(Materia a in cursando)
				{
					dataGridView4.Rows.Add(a.CODIGOMATERIA, a.NOMBREMATERIA);
				}
			}
			textBox1.Text = "";
			textBox2.Text = "";
			try
			{
				textBox1.Text = universidad.Notas(legajobuscado).ToString();
				textBox2.Text = universidad.calcularPromedioAprobadas(legajobuscado).ToString();
			}
			catch (Exception)
			{
				MessageBox.Show("El alumno no tiene notas ingresadas");
			}
		}
	}
}
