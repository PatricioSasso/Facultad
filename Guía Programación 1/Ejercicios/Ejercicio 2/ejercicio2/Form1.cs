using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ejercicio2
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
            int b=0;
            a = Convert.ToInt16(textBox1.Text);
            b = Convert.ToInt16(textBox2.Text);
            int suma;
            suma = a + b;
            label1.Visible = true;
            label1.Text = suma.ToString();
            Thread.Sleep(1000);
            button2.Visible = true;
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            button2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            textBox1.Text = "";
            textBox2.Text = "";
            label1.Text = "";
            label1.Visible = false;
            button2.Visible = false;

        }
    }
}
