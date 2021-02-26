using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejer21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Cola lacola = new Cola();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(textBox1.Text);
            int b = Convert.ToInt16(textBox2.Text);
            lacola.max = a;
            if (lacola.colallena() == true)
            {
                MessageBox.Show("Cola llena");
                textBox2.Text = "";
            }
            else
            {   lacola.agregar(b);
                MessageBox.Show("Dato ingresado");
                textBox2.Text = "";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lacola.colavacia() == true)
            {
                MessageBox.Show("Cola vacía");
            }
            else { lacola.eliminar(); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lacola.ver();
        }
    }
}
