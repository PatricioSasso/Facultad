using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U3_Ej8
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

        private const int basuraMaxima = 1000;

		private void button1_Click(object sender, EventArgs e)
		{
			Form1.CrearBasura();
			MessageBox.Show("Memoria utilizada antes de la recolección: " + GC.GetTotalMemory(false));
			GC.Collect();
			MessageBox.Show("Memoria después de la recolección: " + GC.GetTotalMemory(true));
		}

		static void CrearBasura()
		{
			Version version;
			for (int i = 0; i < basuraMaxima; i++)
			{
				version = new Version();
			}
		}

    }
}
