using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejer2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt16(textBox1.Text);

            if (radioButton1.Checked == true)
            {
                recursiva(n);
            }
        }
        
        public int recursiva(int a)
        {
            int num = a;
            int rest;
            int res;
            if (num == 1)
            {
                rest = 1;
                textBox2.Text = rest.ToString() + textBox2.Text;
                return 1;
            }
            else
            {
                rest = num % 2;
                res = num / 2;
                recursiva(res);
                textBox2.Text += rest.ToString();
                return rest;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            button1.Visible = true;
            button2.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            button1.Visible = true;
            button2.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
