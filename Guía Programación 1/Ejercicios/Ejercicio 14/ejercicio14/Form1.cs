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

namespace ejercicio14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random tiradas = new Random();
            int t = tiradas.Next(1, 9);
            int n=0;
            int i = 1, a=1, b=1, c=1, d=1, l=1, f=1, g=1, h=1, j=1, k=1, m=1;
            Random dado1 = new Random();
            Random dado2 = new Random();
            int n1;
            int n2;
            int suma;
            double porcentaje;
            dataGridView1.Rows.Add(2);
            for (n = 0; n < t; n++)
            {
                n1 = dado1.Next(1, 7);
                n2 = dado2.Next(1, 7);
                suma = n1 + n2;
                textBox1.Text = suma + "-" + textBox1.Text.ToString();
                if (suma == 1)
                {
                    dataGridView1.Rows[0].Cells[0].Value = a.ToString();
                    porcentaje = (a *100)/t;
                    dataGridView1.Rows[1].Cells[0].Value = porcentaje.ToString() + "%";
                    a++;
                }
                else if (suma == 2)
                {
                    dataGridView1.Rows[0].Cells[1].Value = b.ToString();
                    porcentaje = (b * 100) / t;
                    dataGridView1.Rows[1].Cells[1].Value = porcentaje.ToString() + "%";
                    b++;
                }
                else if (suma == 3)
                {
                    dataGridView1.Rows[0].Cells[2].Value = c.ToString();
                    porcentaje = (c * 100) / t;
                    dataGridView1.Rows[1].Cells[2].Value = porcentaje.ToString() + "%";
                    c++;
                }
                else if (suma == 4)
                {
                    dataGridView1.Rows[0].Cells[3].Value = d.ToString();
                    porcentaje = (d * 100) / t;
                    dataGridView1.Rows[1].Cells[3].Value = porcentaje.ToString() + "%";
                    d++;
                }
                else if (suma == 5)
                {
                    dataGridView1.Rows[0].Cells[4].Value = f.ToString();
                    porcentaje = (f * 100) / t;
                    dataGridView1.Rows[1].Cells[4].Value = porcentaje.ToString() + "%";
                    f++;
                }
                else if (suma == 6)
                {
                    dataGridView1.Rows[0].Cells[5].Value = g.ToString();
                    porcentaje = (g * 100) / t;
                    dataGridView1.Rows[1].Cells[5].Value = porcentaje.ToString() + "%";
                    g++;
                }
                else if (suma == 7)
                {
                    dataGridView1.Rows[0].Cells[6].Value = h.ToString();
                    porcentaje = (h * 100) / t;
                    dataGridView1.Rows[1].Cells[6].Value = porcentaje.ToString()+"%";
                    h++;
                }
                else if (suma == 8)
                {
                    dataGridView1.Rows[0].Cells[7].Value = i.ToString();
                    porcentaje = (i * 100) / t;
                    dataGridView1.Rows[1].Cells[7].Value = porcentaje.ToString() + "%";
                    i++;
                }
                else if (suma == 9)
                {
                    dataGridView1.Rows[0].Cells[8].Value = j.ToString();
                    porcentaje = (j * 100) / t;
                    dataGridView1.Rows[1].Cells[8].Value = porcentaje.ToString() + "%";
                    j++;
                }
                else if (suma == 10)
                {
                    dataGridView1.Rows[0].Cells[9].Value = k.ToString();
                    porcentaje = (k * 100) / t;
                    dataGridView1.Rows[1].Cells[9].Value = porcentaje.ToString() + "%";
                    k++;
                }
                else if (suma == 11)
                {
                    dataGridView1.Rows[0].Cells[10].Value = l.ToString();
                    porcentaje = (l * 100) / t;
                    dataGridView1.Rows[1].Cells[10].Value = porcentaje.ToString() + "%";
                    l++;
                }
                else if (suma == 12)
                {
                    dataGridView1.Rows[0].Cells[11].Value = m.ToString();
                    porcentaje = (m * 100) / t;
                    dataGridView1.Rows[1].Cells[11].Value = porcentaje.ToString() + "%";
                    m++;
                }
                
            }
        }
    }
}
