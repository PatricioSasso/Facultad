using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5_Ej1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Generica<int> generica = new Generica<int>(10, 10 * 2);
            generica.Metodo1(10); generica.Metodo2(10 * 2);

        }

    }

    public class Generica<T>
	{
		private T Campo;
        private T Campo2;

		public Generica(T value, T valuee)
		{
			Campo= value;
            Campo2 = valuee;
		}

		public void Metodo1(T pGen)
		{
			MessageBox.Show("El constructor tiene el valor: " + Campo);
		}

		public void Metodo2 (T pGen)
		{
			MessageBox.Show("El valor multiplicado es: " + Campo2.ToString());	
		}
	}
}
