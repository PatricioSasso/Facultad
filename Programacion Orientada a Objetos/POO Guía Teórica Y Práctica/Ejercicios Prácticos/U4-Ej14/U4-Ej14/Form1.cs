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

namespace U4_Ej14
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		Clonar original = new Clonar();
		Clonar clon = new Clonar();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
		{
			original.Edad = int.Parse(Interaction.InputBox("Ingrese la edad"));
			original.Nombre = Interaction.InputBox("Ingrese el nombre");
			clon = (Clonar)original.AgregarComp();
			MessageBox.Show("A: " + Environment.NewLine + original.Edad.ToString() + " " + original.Nombre + Environment.NewLine + "Clonado:" + Environment.NewLine + clon.Edad.ToString() + " " + clon.Nombre);
		}

    }
    class Clonar : ICloneable
	{
		public int Edad { get; set; }
		public string Nombre { get; set; }

		public object Clone()
		{
			return MemberwiseClone();
		}

		public Clonar compañero { get; set; }

		public Clonar AgregarComp()
		{
			if (compañero == null)
			{
				return compañero = (Clonar)Clone();
			}
			else
            {
                return null;
            }
		}
	}
}
