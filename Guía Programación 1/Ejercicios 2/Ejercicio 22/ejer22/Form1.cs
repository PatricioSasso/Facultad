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

namespace ejer22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        cola c = new cola();
        int acobrar = 0;
        int cobradas = 0;
        decimal impcobrado = 0;
        decimal impacobrar = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(Interaction.InputBox("Escriba su Id"));
            decimal Imp = decimal.Parse(Interaction.InputBox("Escriba el Importe"));
            c.agregar(Id, Imp);
            if(c.colallena() == false)
            {
                impacobrar += c.Importe[c.primero];
                textBox1.Text = impacobrar.ToString();
                acobrar++;
                textBox2.Text = acobrar.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (c.colavacia() == false)
            {
                impacobrar -= c.Importe[c.primero];
                impcobrado += c.Importe[c.primero];
                textBox1.Text = impacobrar.ToString();
                textBox3.Text = impcobrado.ToString();
                cobradas++;
                acobrar--;
                textBox4.Text = cobradas.ToString();
                textBox2.Text = acobrar.ToString();
            }
            c.eliminar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            c.ver();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            c.max = 500;
        }
    }
}
