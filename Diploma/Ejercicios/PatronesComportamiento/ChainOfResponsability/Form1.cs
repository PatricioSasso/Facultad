using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChainOfResponsability
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		IHandler_Soporte soporte = new ConcreteHandler_MesaAyudaTelefonica();
		private void btnTicket_Click(object sender, EventArgs e)
		{
			Ticket ticket = new Ticket();
			ticket.Titulo = txtIncidente.Text;
			int index = cmbNivel.SelectedIndex + 1;
			ticket.Nivel = (Ticket.ComplejidadTecnica)index;
			lblRespuesta.Text = soporte.Resolver(ticket);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			cmbNivel.Items.Add("Problema de nivel básico");

			cmbNivel.Items.Add("Incidente técnico sencillo");

			cmbNivel.Items.Add("Incidente técnico complejo");

			cmbNivel.Items.Add("Incidente técnico atípico");

			cmbNivel.Items.Add("Incidente metafísico");

			cmbNivel.Items.Add("Incidente imposible de resolver");

			cmbNivel.SelectedIndex = 0;
		}
	}
}
