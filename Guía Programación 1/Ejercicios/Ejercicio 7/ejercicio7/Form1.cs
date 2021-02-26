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

namespace ejercicio7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a=0;
            int i;
            int[] v = new int[100];
            a = int.Parse(Interaction.InputBox("¿Cuántos números desea ingresar?"));
            for (i = 0; i < a; i++)
            {
                v[i] = int.Parse(Interaction.InputBox("Ingrese un número"));
            }
            for (i = 0; i < a; i++)
            {
                if (v[i] % 2 == 0)
                {
                    textBox1.Text += v[i] + " -";
                }
                if (v[i] % 2 == 1)
                {
                    textBox2.Text += v[i] + " -";
                }
            }
        }
    }
}
