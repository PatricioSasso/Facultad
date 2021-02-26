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

namespace U1_Ej1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		Universidad UAI = new Universidad();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
		{
			UAI.AgregarAlumno();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			UAI.ModificarAlumno();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			UAI.EliminarAlumno();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			int a = int.Parse(Interaction.InputBox("Ingrese el id de la materia"));
			string nombre = Interaction.InputBox("Ingrese el nombre de la materia");
			UAI.AgregarBasica(a, nombre);
		}

		private void button7_Click(object sender, EventArgs e)
		{
			int a = int.Parse(Interaction.InputBox("Ingrese el id de la materia"));
			string nombre = Interaction.InputBox("Ingrese el nombre de la materia");
			UAI.AgregarEspecial(a, nombre);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			UAI.EliminarMateria();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			UAI.ModificarMateria();
		}
	}
	
}
