using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		//Creo instancias de los prototypes para clonar
		ConcretePrototypeBigMac BigMac = new ConcretePrototypeBigMac();
		ConcretePrototypeCBO CBO = new ConcretePrototypeCBO();
		ConcretePrototypeMcNifica McNifica = new ConcretePrototypeMcNifica();
		ConcretePrototypeMcPollo McPollo = new ConcretePrototypeMcPollo();

		//Lista de las hamburguesas vendidas
		List<Prototype_Hamburguesa> Hamburguesas = new List<Prototype_Hamburguesa>();

		public void Mostrar()
		{
			lstHamburgesas.Items.Clear();
			foreach (Prototype_Hamburguesa item in Hamburguesas)
			{
				lstHamburgesas.Items.Add(item.Descripcion());
			}
		}

		private void btnBM_Click(object sender, EventArgs e)
		{
			Prototype_Hamburguesa hm= BigMac.Clone() as Prototype_Hamburguesa;
			if(chkExtraQueso.Checked)
			{
				hm.FetasQueso += 1;
			}
			if(chkExtraBacon.Checked)
			{
				hm.Panceta = true;
			}
			Hamburguesas.Add(hm);
			Mostrar();
		}

		private void btnMP_Click(object sender, EventArgs e)
		{
			Prototype_Hamburguesa hm = McPollo.Clone() as Prototype_Hamburguesa;
			if (chkExtraQueso.Checked)
			{
				hm.FetasQueso += 1;
			}
			if (chkExtraBacon.Checked)
			{
				hm.Panceta = true;
			}
			Hamburguesas.Add(hm);
			Mostrar();
		}

		private void btnCBO_Click(object sender, EventArgs e)
		{
			Prototype_Hamburguesa hm = CBO.Clone() as Prototype_Hamburguesa;
			if (chkExtraQueso.Checked)
			{
				hm.FetasQueso += 1;
			}
			if (chkExtraBacon.Checked)
			{
				hm.Panceta = true;
			}
			Hamburguesas.Add(hm);
			Mostrar();
		}

		private void btnMN_Click(object sender, EventArgs e)
		{
			Prototype_Hamburguesa hm = McNifica.Clone() as Prototype_Hamburguesa;
			if (chkExtraQueso.Checked)
			{
				hm.FetasQueso += 1;
			}
			if (chkExtraBacon.Checked)
			{
				hm.Panceta = true;
			}
			Hamburguesas.Add(hm);
			Mostrar();
		}
	}
}
