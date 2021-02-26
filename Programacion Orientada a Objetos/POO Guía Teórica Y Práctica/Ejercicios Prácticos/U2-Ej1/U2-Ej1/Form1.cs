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

namespace U2_Ej1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		Persona persona = new Persona();

		private void button1_Click(object sender, EventArgs e)
		{
			int velocidad = int.Parse(Interaction.InputBox("Ingrese la velocidad"));
			 MessageBox.Show(persona.Velocidad(velocidad));
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int velocidad = int.Parse(Interaction.InputBox("Ingrese la velocidad"));
			MessageBox.Show(persona.Lentitud(velocidad));
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int edad = int.Parse(Interaction.InputBox("Ingrese la edad de la persona"));
			string nombre = Interaction.InputBox("Ingrese el nombre de la persona");
			Persona c = new Persona(nombre, edad);
			MessageBox.Show(nombre.ToString() + Environment.NewLine + edad.ToString());
		}

		private void button4_Click(object sender, EventArgs e)
		{
			string colorPelo = Interaction.InputBox("Ingrese el color de pelo de la persona");
			string colorOjos = Interaction.InputBox("Ingrese el color de ojos de la persona");
			Persona persona = new Persona(colorOjos, colorPelo);
			MessageBox.Show(colorOjos.ToString() + Environment.NewLine + colorPelo.ToString());
		}
	}

	public class Persona
	{
		private string nombre;
        private int edad;
		private string pelo;
        private string ojos;

		public string Nombre { get => nombre; set => nombre = value; }
		public string Pelo { get => pelo; set => pelo = value; }
		public string Ojos { get => ojos; set => ojos = value; }
		public int Edad { get => edad; set => edad = value; }

		public Persona(string pelo, string ojos)
		{
			this.pelo = pelo;
			this.ojos = ojos;
		}

		public Persona(string nombre, int edad)
		{
			this.nombre = nombre;
			this.edad = edad;
		}

		public Persona()
        {

        }

		public string Velocidad(int velocidad)
		{
			int velocidadFinal = velocidad * 2;
			return "La persona esta corriendo, su velocidad es de: " + velocidadFinal.ToString() + " km/h";
		}

		public string Lentitud(int velocidad)
		{
			decimal velocidadFinal = velocidad / 2;
			return "Si la persona redujera su velocidad, sería de: " + velocidadFinal.ToString() + " km/h";
		}
	}
}
