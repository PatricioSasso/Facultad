using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejer11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Lista L = new Lista();
        int size;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void Prom()
        {
            int i;
            int mayore = L.buscarnodo(0).Edad;
            int mayorp = L.buscarnodo(0).Peso;
            int menore = L.buscarnodo(0).Edad;
            int menorp = L.buscarnodo(0).Peso;
            int e50 = 0;
            int p60 = 0;
            int pe = 0;
            int pp = 0;
            for (i = 0; i < L.size; i++)
            {
                pe += L.buscarnodo(i).Edad;
                pp += L.buscarnodo(i).Peso;
                if (L.buscarnodo(i).Edad < menore)
                {
                    menore = L.buscarnodo(i).Edad;
                }
                if(L.buscarnodo(i).Edad > mayore)
                {
                    mayore = L.buscarnodo(i).Edad;
                }
                if(L.buscarnodo(i).Edad > 50)
                {
                    e50++;
                }

                if (L.buscarnodo(i).Peso < menorp)
                {
                    menorp = L.buscarnodo(i).Peso;
                }
                if (L.buscarnodo(i).Peso > mayorp)
                {
                    mayorp = L.buscarnodo(i).Peso;
                }
                if(L.buscarnodo(i).Peso > 60)
                {
                    p60++;
                }
            }
            pe = pe / (L.size + 1);
            pp = pp / (L.size + 1);
            textBox7.Text = pe.ToString();
            textBox8.Text = pp.ToString();
            textBox9.Text = menore.ToString();
            textBox10.Text = mayore.ToString();
            textBox11.Text = menorp.ToString();
            textBox12.Text = mayorp.ToString();
            textBox13.Text = (L.size + 1).ToString();
            textBox14.Text = e50.ToString();
            textBox15.Text = p60.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string n = textBox2.Text;
                string a = textBox3.Text;
                int ed = int.Parse(textBox4.Text);
                int p = int.Parse(textBox5.Text);
                string s = textBox6.Text;
                L.agregaralprincipio(n, a, ed, p, s);
                int rowEscribir = dataGridView1.Rows.Count - 1;
                dataGridView1.Rows.Add(1);
                dataGridView1.Rows[rowEscribir].Cells[0].Value = size.ToString();
                dataGridView1.Rows[rowEscribir].Cells[1].Value = n;
                dataGridView1.Rows[rowEscribir].Cells[2].Value = a;
                dataGridView1.Rows[rowEscribir].Cells[3].Value = ed.ToString();
                dataGridView1.Rows[rowEscribir].Cells[4].Value = p.ToString();
                dataGridView1.Rows[rowEscribir].Cells[5].Value = s;
                size++;
                Prom();
            }
            catch
            {

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int d = int.Parse(textBox1.Text);
            string n = textBox2.Text;
            string a = textBox3.Text;
            int ed = int.Parse(textBox4.Text);
            int p = int.Parse(textBox5.Text);
            string s = textBox6.Text;
            L.agregarenn(n, a, ed, p, s, d);
            int rowEscribir = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows.Add(1);
            dataGridView1.Rows[rowEscribir].Cells[0].Value = size.ToString();
            dataGridView1.Rows[rowEscribir].Cells[1].Value = n;
            dataGridView1.Rows[rowEscribir].Cells[2].Value = a;
            dataGridView1.Rows[rowEscribir].Cells[3].Value = ed.ToString();
            dataGridView1.Rows[rowEscribir].Cells[4].Value = p.ToString();
            dataGridView1.Rows[rowEscribir].Cells[5].Value = s;
            size++;
            Prom();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int d = int.Parse(textBox1.Text);
            string n = textBox2.Text;
            string a = textBox3.Text;
            int ed = int.Parse(textBox4.Text);
            int p = int.Parse(textBox5.Text);
            string s = textBox6.Text;
            L.agregarenn(n, a, ed, p, s, d);
            int rowEscribir = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows.Add(1);
            dataGridView1.Rows[rowEscribir].Cells[0].Value = size.ToString();
            dataGridView1.Rows[rowEscribir].Cells[1].Value = n;
            dataGridView1.Rows[rowEscribir].Cells[2].Value = a;
            dataGridView1.Rows[rowEscribir].Cells[3].Value = ed.ToString();
            dataGridView1.Rows[rowEscribir].Cells[4].Value = p.ToString();
            dataGridView1.Rows[rowEscribir].Cells[5].Value = s;
            size++;
            Prom();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            L.sacarprimero();
            int rowEscribir = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
            size--;
            Prom();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int d = int.Parse(textBox1.Text);
            L.sacarenn(d);
            int rowEscribir = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
            size--;
            Prom();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            L.sacarprimero();
            int rowEscribir = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
            size--;
            Prom();
        }
    }
}
