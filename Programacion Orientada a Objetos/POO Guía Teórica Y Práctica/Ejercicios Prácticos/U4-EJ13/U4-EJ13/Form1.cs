using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U4_EJ13
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

        private void button1_Click(object sender, EventArgs e)
		{
			List<Persona> personas = new List<Persona>();
			personas.Add(new Persona(18, "Yo"));
			personas.Add(new Persona(17, "Katia"));
			personas.Add(new Persona(16, "Simon"));
			personas.Add(new Persona(81, "Thunder"));
			personas.Add(new Persona(19, "Reina"));
			personas.Sort(new Comparador());
			foreach (Persona p in personas)
			{
				textBox1.Text += " " + p.Nombre + " " + p.Edad+ Environment.NewLine;
			}
		}

    }

    public class Persona 
	{
		private int edad;
		private string nombre;

		public Persona()
		{

		}

		public Persona(int edad, string nombre)
		{
			this.edad = edad;
			this.nombre = nombre;
		}

		public int Edad { get => edad; set => edad = value; }
		public string Nombre { get => nombre; set => nombre = value; }
	}

	public class Comparador : IComparer<Persona>
	{
		int IComparer<Persona>.Compare(Persona x, Persona y)
		{
			if(x.Nombre==y.Nombre)
			{
				if(x.Edad<y.Edad)
				{
					return -1;
				}
				else if(x.Edad>y.Edad)
				{
					return 1;
				}
				else if(x.Edad==y.Edad)
				{
					return 0;
				}
			}
			else
			{
				return x.Nombre.CompareTo(y.Nombre);
			}
			return x.Nombre.CompareTo(y.Nombre);
		}
	}
}
