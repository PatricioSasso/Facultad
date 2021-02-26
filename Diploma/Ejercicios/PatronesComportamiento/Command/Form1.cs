using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Command
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Label2_Click(object sender, EventArgs e)
		{

		}

		Receiver_TV TV; 
		Invoker_ControlRemoto control;
		//SUBE Y BAJA VOLUMEN Y CANALES, DESHACE, PERO FALTAN LOS BOTONES NUMÉRICOS
		private void Form1_Load(object sender, EventArgs e)
		{
			TV = new Receiver_TV();
			control = new Invoker_ControlRemoto(TV);
		}
		public void Actualizar()
		{
			txtTV.Text = TV.Estado();
		}

		private void btnOnOff_Click(object sender, EventArgs e)
		{
			control.EncenderApagar();
			Actualizar();
		}

		private void btnDeshacer_Click(object sender, EventArgs e)
		{
			control.Deshacer();
			Actualizar();
		}

		private void b1_Click(object sender, EventArgs e) 
		{

		}

		private void vSubir_Click(object sender, EventArgs e)
		{
			control.SubirVolumen();
			Actualizar();
		}

		private void vBajar_Click(object sender, EventArgs e)
		{
			control.BajarVolumen();
			Actualizar();
		}

		private void Subir_Click(object sender, EventArgs e)
		{
			control.SubirCanal();
			Actualizar();
		}

		private void cBajar_Click(object sender, EventArgs e)
		{
			control.BajarCanal();
			Actualizar();
		}
	}
}
