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

namespace ejer6
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
            n = int.Parse(Interaction.InputBox("Ingrese hasta que número desea la serie"));
            fibonacci(n);
        }
        private void fibonacci(int fin)
        {
            int a = 1; int b = 0;
            int res;
            while (a < fin)
            {
                textBox1.Text += a.ToString() + " ";
                res = a + b;
                b = a;
                a = res;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
