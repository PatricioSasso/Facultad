using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio5
{
    public partial class Form1 : Form
    {
       
        
        public Form1()
        {
            InitializeComponent();
        }
        int a;
        int b;
        
        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt16(textBox1.Text);
            b = Convert.ToInt16(textBox2.Text);
            int suma;
            suma = a + b;
            textBox3.Text = suma.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt16(textBox1.Text);
            b = Convert.ToInt16(textBox2.Text);
            int resta;
            resta = a - b;
            textBox3.Text = resta.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt16(textBox1.Text);
            b = Convert.ToInt16(textBox2.Text);
            int mult;
            mult = a * b;
            textBox3.Text = mult.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt16(textBox1.Text);
            b = Convert.ToInt16(textBox2.Text);
            int div;
            div = a / b;
            textBox3.Text = div.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt16(textBox1.Text);
            b = Convert.ToInt16(textBox2.Text);
            int pot = potenciacion(a, b);
            textBox3.Text = pot.ToString();
        }

        private int potenciacion(int x, int y)
        {
            int R;
            if (y == 1) { R = x; }
            else { R = x * potenciacion(x, y - 1); }
            return R;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt16(textBox1.Text);
            b = Convert.ToInt16(textBox2.Text);
            double resa;
            double resb;
            resa = Math.Sqrt(a);
            resb = Math.Sqrt(b);
            textBox3.Text = "raíz num1: "+ resa.ToString() + " "+"raiz num2: " + resb.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
