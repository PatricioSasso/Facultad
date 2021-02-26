using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flyweight
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		FlyweightFactory_Concesionario flyweightFactory = new FlyweightFactory_Concesionario();
		private void Form1_Load(object sender, EventArgs e)
		{
			lstAutos.Items.Add(flyweightFactory.Vender("Audi", "A4", "Negro", "AA123AA", "Juan Perez").Describir());
			lstAutos.Items.Add(flyweightFactory.Vender("Ford", "Fiesta", "Rojo", "JAD922", "Pedro Ramirez").Describir());
			lstAutos.Items.Add(flyweightFactory.Vender("Audi", "A4", "Negro", "AB113BB", "Miguel Gonzales").Describir());
			lstAutos.Items.Add(flyweightFactory.Vender("Chevrolet", "Tracker", "Blanco", "KDS123", "Susana Juarez").Describir());
			lstAutos.Items.Add(flyweightFactory.Vender("Ford", "Fiesta", "Rojo", "AA120AB", "Jorge Benitez").Describir());
		}
	}
}
