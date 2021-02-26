using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejer4
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
            int a = Convert.ToInt16(textBox1.Text);
            textBox2.Text += recursiva(a);
            button2.Visible = true;
            button1.Visible = false;

        }
        public int recursiva(int a)
        {
            int num = a;
            if (a == 0) { return 0; }
            else
            {
                num = a+ recursiva(num - 1);
                return num;
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox1.Text = "";
            button1.Visible = true;
            button2.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
