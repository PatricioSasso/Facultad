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

namespace ejercicio4
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] vector = new int[100];
            int i = 0;
            char s = 'x';
            int suma = 0;
            s = char.Parse(Interaction.InputBox("¿Desea ingresar números? Presione s para continuar"));
            if (s == 'S' || s == 's')
            {
                vector[99] = int.Parse(Interaction.InputBox("¿Cuántos desea ingresar?"));
                for (i = 0; i < vector[99]; i++)
                {
                    vector[i] = int.Parse(Interaction.InputBox("Ingrese un número"));
                }
                for (i = 0; i < vector[99]; i++)
                {
                    textBox1.Text += (vector[i]).ToString() + "-";
                }
                for (i = 0; i < vector[99]; i++)
                {
                    suma += vector[i];
                }
                label1.Text = suma.ToString();
            }
            else
            {
                this.Show();
                for (i = 0; i < vector[99]; i++)
                {
                    textBox1.Text += textBox1.Text.ToString() + "-";
                }
                label1.Text = suma.ToString();
            }
        }
    }
}
