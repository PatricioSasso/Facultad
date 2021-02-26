using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace State
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		Context_Auto Auto = new Context_Auto();
		private void Form1_Load(object sender, EventArgs e)
		{

		}
		public void Actualizar()
		{
			txtEstadoAuto.Text = Auto.DescribirEstado();
		}

		private void btnCombustible_Click(object sender, EventArgs e)
		{
			Auto.CargarCombustible(int.Parse(txtCantidad.Text));
			Actualizar();
		}

		private void btnEncender_Click(object sender, EventArgs e)
		{
			Auto.Encender();
			Actualizar();
		}

		private void btnApagar_Click(object sender, EventArgs e)
		{
			Auto.Apagar();
			Actualizar();
		}

		private void btnAcelerar_Click(object sender, EventArgs e)
		{
			Auto.Acelerar();
			Actualizar();
		}

		private void btnFrenar_Click(object sender, EventArgs e)
		{
			Auto.Frenar();
			Actualizar();
		}
	}
}
