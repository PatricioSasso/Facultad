using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            int n, n1;
            n = Convert.ToInt32(textBox1.Text);
            n1 = Convert.ToInt32(textBox2.Text);
            label4.Text = (n+n1).ToString();
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            textBox1.Text = "";
            textBox2.Text = "";
            label2.Text = "número 2:";
            label4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            int n, n1;
            n = Convert.ToInt32(textBox1.Text);
            n1 = Convert.ToInt32(textBox2.Text);
            label4.Text = (n - n1).ToString();
            button1.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            int n, n1;
            n = Convert.ToInt32(textBox1.Text);
            n1 = Convert.ToInt32(textBox2.Text);
            label4.Text = (n * n1).ToString();
            button2.Enabled = false;
            button1.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            int n, n1;
            n = Convert.ToInt32(textBox1.Text);
            n1 = Convert.ToInt32(textBox2.Text);
            label4.Text = (n / n1).ToString();
            button2.Enabled = false;
            button3.Enabled = false;
            button1.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            label2.Text = "Elevado a la: ";
            int n, n1, i;
            n = Convert.ToInt32(textBox1.Text);
            n1 = Convert.ToInt32(textBox2.Text);
            for (i = 0; i < n1; i++)
            {
                n *= n;
            }
            label4.Text = (n).ToString();
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button1.Enabled = false;
            button6.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox2.Visible = false;
            label2.Visible = false;
            int n = Convert.ToInt16(textBox1.Text);
            double calculo;
            calculo= Math.Sqrt(n);
            label4.Text = calculo.ToString();
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button1.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
