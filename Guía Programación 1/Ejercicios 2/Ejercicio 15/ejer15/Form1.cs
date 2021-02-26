using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejer15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Pila lapila = new Pila();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(textBox1.Text);
            int b = Convert.ToInt16(textBox2.Text);
            lapila.maximo = a;
            if (lapila.pilallena() == true)
            {
                MessageBox.Show("Pila llena");
                textBox2.Text = "";
            }
            else
            {   lapila.agregar(b);
                MessageBox.Show("Valor agregado");
                textBox2.Text = "";
            } 
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (lapila.pilavacia() == true)
            {
                MessageBox.Show("Pila vacía");
            }
            else { lapila.eliminar(); }  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lapila.ver().ToString());

        }
    }
}
