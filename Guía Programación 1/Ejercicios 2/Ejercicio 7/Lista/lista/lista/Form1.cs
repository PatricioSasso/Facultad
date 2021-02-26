using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Listaa hola = new Listaa();
        private void button1_Click(object sender, EventArgs e)
        {
            Object a = textBox1.Text;
            hola.agregaralprincipio(a);
            MessageBox.Show("Dato agregado");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Object a = textBox1.Text;
            hola.agregaralfinal(a);
            MessageBox.Show("Dato agregado");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Object a = textBox1.Text;
            int b = Convert.ToInt16(textBox2.Text);
            hola.agregarenn(a,b);
            MessageBox.Show("Dato agregado");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(textBox2.Text);
            hola.buscarnodo(a);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hola.sacarultimo();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt16(textBox2.Text);
            hola.sacarenn(n);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hola.sacarprimero();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cantidad de elemento en la lista "+hola.size.ToString());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hola.vaciar();
            MessageBox.Show("Lista vacía");
        }
    }
}
