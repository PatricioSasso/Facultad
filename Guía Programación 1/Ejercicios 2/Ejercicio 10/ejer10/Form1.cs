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

namespace ejer10
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
            Mostrar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            lt.agregaralfinal(a);
            Mostrar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(Interaction.InputBox("Ingrese la posición"));
            lt.agregarenn(a, b);
            Mostrar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int b = int.Parse(Interaction.InputBox("Ingrese la posición"));
            lt.sacarenn(b);
            Mostrar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lt.sacarprimero();
            Mostrar();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lt.sacarultimo();
            Mostrar();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int b = int.Parse(Interaction.InputBox("Ingrese la posición"));
            lt.cambiarder(b);
            Mostrar();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int b = int.Parse(Interaction.InputBox("Ingrese la posición"));
            lt.cambiarizq(b);
            Mostrar();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lt.size.ToString());
        }

        private void Mostrar()
        {
            int[] vector = new int[lt.size];
            listBox1.Items.Clear();
            for (int i = 0; i < lt.size; i++)
            {
                vector[i] = int.Parse(lt.buscarnodo(i).valor.ToString());
            }
            for (int i = 0; i < lt.size ; i++)
            {
                listBox1.Items.Add(vector[i]);
            }
        }
    }
}
