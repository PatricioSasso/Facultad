using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strategy
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private Context_Organizacion Organizacion;
		private void btnCenaSolo_Click(object sender, EventArgs e)
		{
			txtPreparacionMesa.Text = Organizacion.PonerMesa(new ConcreteStrategy_CenaSolitaria());
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Organizacion = new Context_Organizacion();
		}

		private void btnCenaRomantica_Click(object sender, EventArgs e)
		{
			txtPreparacionMesa.Text = Organizacion.PonerMesa(new ConcreteStrategy_CenaRomantica());
		}

		private void btnCenaSuegros_Click(object sender, EventArgs e)
		{
			txtPreparacionMesa.Text = Organizacion.PonerMesa(new ConcreteStrategy_CenaSuegros());
		}
	}
}
