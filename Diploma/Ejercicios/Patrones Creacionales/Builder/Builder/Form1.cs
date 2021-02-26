using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Builder
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		//Instancio un fabricante global
		Fabricante_DirectorBuilder fabricante = new Fabricante_DirectorBuilder();

		private void btnPC_Click(object sender, EventArgs e)
		{
			//LE PASO EL CONCRETE BUILDER PARA CREAR EL PRODUCTO DESEADO
			Producto_Computadora computadora = fabricante.ConstruirComputadora(new ConcreteBuilderPC());
			textBox1.Text = computadora.MostrarDescripcion();
		}

		private void btnNotebook_Click(object sender, EventArgs e)
		{
			//LE PASO EL CONCRETE BUILDER PARA CREAR EL PRODUCTO DESEADO
			Producto_Computadora computadora = fabricante.ConstruirComputadora(new ConcreteBuilderNotebook());
			textBox1.Text = computadora.MostrarDescripcion();
		}

		private void btnTablet_Click(object sender, EventArgs e)
		{
			//LE PASO EL CONCRETE BUILDER PARA CREAR EL PRODUCTO DESEADO
			Producto_Computadora computadora = fabricante.ConstruirComputadora(new ConcreteBuilderTablet());
			textBox1.Text = computadora.MostrarDescripcion();
		}

		private void btnSmart_Click(object sender, EventArgs e)
		{
			//LE PASO EL CONCRETE BUILDER PARA CREAR EL PRODUCTO DESEADO
			Producto_Computadora computadora = fabricante.ConstruirComputadora(new ConcreteBuilderSmartPhone());
			textBox1.Text = computadora.MostrarDescripcion();
		}
	}
}
