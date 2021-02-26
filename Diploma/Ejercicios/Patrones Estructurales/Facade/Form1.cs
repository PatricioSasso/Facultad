using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facade
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		FacadeOrganizadorEventos facadeOrganizador = new FacadeOrganizadorEventos();
		private void btnCasamiento_Click(object sender, EventArgs e)
		{
			if(rdbCompleta.Checked)
			{
				txtPresupuesto.Text=facadeOrganizador.OrganizarCasamiento(int.Parse(txtInvitados.Text), dtpFecha.Value, Gasto());
			}
			else if(rdbModerada.Checked)
			{
				txtPresupuesto.Text = facadeOrganizador.OrganizarCasamiento(int.Parse(txtInvitados.Text), dtpFecha.Value, Gasto());
			}
		}

		public FacadeOrganizadorEventos.TipoGasto Gasto()
		{
			FacadeOrganizadorEventos.TipoGasto tipogasto = FacadeOrganizadorEventos.TipoGasto.FestejoCompleto;
			if(rdbModerada.Checked)
			{
				tipogasto=FacadeOrganizadorEventos.TipoGasto.FiestaModerada;
			}
			return tipogasto;
		}
	}
}
