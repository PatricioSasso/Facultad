using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U4_Ej12
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
			object[] numeros = { 30, 12, 42, 6};
			Array.Sort(numeros);
			foreach (var n in numeros)
			{
				if(n!=null)
				{
					MessageBox.Show("El item es: " + n.ToString());
				}
			}
		}

	}

	public class Persona : IComparable
	{
		private int edad;

		public Persona()
        {

        }

		public Persona(int edad)
		{
			this.edad = edad;
		}

        public int Edad { get => edad; set => edad = value; }

        public override string ToString()
		{
			return edad.ToString();
		}

		public int CompareTo(object obj)
		{
			Persona persona = obj as Persona;
			int b = this.Edad.CompareTo(persona.edad);
			return b;
		}
	}
}
