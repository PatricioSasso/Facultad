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

namespace ejercicio8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            n = int.Parse(Interaction.InputBox("Ingrese un número"));
            if (n % 2 == 0)
            {
                textBox2.Text += n + " ";
            }
            else { textBox1.Text += n + " "; }
            button1.Text = "Ingresar otro número";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
