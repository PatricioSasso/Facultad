using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ejer8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Lista LT = new Lista();
        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            LT.agregaralprincipio(a);
            textBox2.Text += textBox2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            LT.agregaralfinal(a);
            textBox2.Text += textBox2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(Interaction.InputBox("Ingrese en qué posición desea ingregarlo"));
            LT.agregarenn(a, b);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int b = int.Parse(Interaction.InputBox("Ingrese en qué posición desea ingregarlo"));
            LT.sacarenn(b);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LT.sacarultimo();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LT.sacarprimero();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int b = int.Parse(Interaction.InputBox("Ingrese en qué posición intercambiar"));
            LT.cambiarder(b);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int b = int.Parse(Interaction.InputBox("Ingrese en qué posición intercambiar"));
            LT.cambiarizq(b);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show(LT.size.ToString());
        }
    }
}
