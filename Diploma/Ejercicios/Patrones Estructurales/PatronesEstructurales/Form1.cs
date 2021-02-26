using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatronesEstructurales
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnTakeAway_Click(object sender, EventArgs e)
		{
			IAbstraction_Pizzeria pizzeria = PizzeriaElegida();
			txtTareas.Text= pizzeria.EntregarPizza();
		}
		public IAbstraction_Pizzeria PizzeriaElegida()
		{
			if(rdbArtesanal.Checked)
			{
				return new RefinedAbstractionLaNonna();
			}
			else
			{
				return new RefinedAbstractionRomario();
			}
		}

		private void btnRestaurante_Click(object sender, EventArgs e)
		{
			IAbstraction_Pizzeria pizzeria = PizzeriaElegida();
			txtTareas.Text = pizzeria.ServirPizza();
		}
	}
}
