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

namespace ejer9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Lista lt = new Lista();
        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            lt.agregaralprincipio(a);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            lt.agregaralfinal(a);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(Interaction.InputBox("Ingrese en qué posición lo desea"));
            lt.agregarenn(a, b);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int b = int.Parse(Interaction.InputBox("Ingrese en qué posición desea borrar"));
            lt.sacarenn(b);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lt.sacarprimero();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lt.sacarultimo();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int b = int.Parse(Interaction.InputBox("Ingrese en qué posición lo desea"));
            lt.cambiarder(b);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int b = int.Parse(Interaction.InputBox("Ingrese en qué posición lo desea"));
            lt.cambiarizq(b);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lt.size.ToString());
        }
    }
}
