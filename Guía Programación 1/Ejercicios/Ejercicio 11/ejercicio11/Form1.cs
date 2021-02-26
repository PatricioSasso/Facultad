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

namespace ejercicio11
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
        
    
        private int fibonacci(int n)
        {
            if (n == 0 || n == 1) { return 1; }
            else
            {
                n = fibonacci(n - 1) + fibonacci(n - 2);
                return n;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int n;
            n = int.Parse(Interaction.InputBox("Ingrese un número"));
            textBox1.Text = "Usted ingresó "+ n.ToString() + ":  " + fibonacci(n).ToString();
        }
    }
}
