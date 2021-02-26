using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ejercicio15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random dado1;
        Random dado2;
        int dado;
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Tirar dados") { button1.Text = "Stop"; }
            else { button1.Text = "Tirar dados"; }
            timer1.Enabled = !(timer1.Enabled);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = trackBar1.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dado = dado1.Next(1, 7) + dado2.Next(1, 7);
            textBox1.Text = dado.ToString() + " - " + textBox1.Text;
            textBox2.Text = (int.Parse(textBox2.Text) + 1).ToString();
            dataGridView1.Rows[0].Cells[dado - 1].Value = (int.Parse(dataGridView1.Rows[0].Cells[dado - 1].Value.ToString()) + 1).ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewCell C in dataGridView1.Rows[0].Cells)
            {
                C.Value = 0;
            }
            textBox1.Text = "";
            textBox2.Text = "0";
            dado1 = new Random(DateTime.Now.Millisecond);
            dado2 = new Random(DateTime.Now.Millisecond);
            dado = 0;
        }
    }
}
