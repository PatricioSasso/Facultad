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

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int n;
            int i;
            int suma=0;
            n = int.Parse(Interaction.InputBox("Ingrese la cantidad de números que desea ingresar"));
            int[] vector = new int[n];
            for (i=0;i<n;i++)
            {
                vector[i] = int.Parse(Interaction.InputBox("Ingrese un número"));
            }
            for (i = 0; i < n; i++)
            {
                textBox1.Text=textBox1.Text+ vector[i].ToString();

            }
            for (i = 0; i < n; i++)
            {
                suma += vector[i];

            }
            label1.Text= suma.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
