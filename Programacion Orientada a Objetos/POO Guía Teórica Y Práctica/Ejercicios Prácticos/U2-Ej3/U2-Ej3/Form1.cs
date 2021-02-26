using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_Ej3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		Ave ave;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
		{
			if (ave != null && ave is IDisposable)
            {
                ave.Dispose();
            }
		}

		private void button2_Click(object sender, EventArgs e)
		{
			GC.Collect();
		}

    }

    public class Ave : IDisposable
	{
		Ala Vala;
		bool UsoDispose = false;

		public Ave(Ala pAla)
		{
			Vala = pAla;
		}

		~Ave()
		{
            if (!UsoDispose)
            {
                Vala = null; MessageBox.Show("Se ejecutó el Finalizador");
            }
        }

		public void Dispose()
		{
			if (Vala != null)
			{
				Vala = null;
				UsoDispose = !UsoDispose;
				MessageBox.Show("Se ejecutó el Dispose");
			}
		}
	}

	public class Ala
    {

    }

}
