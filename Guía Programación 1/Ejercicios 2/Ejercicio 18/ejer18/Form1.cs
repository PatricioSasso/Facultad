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

namespace ejer18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        pila p1 = new pila();
        pila p2 = new pila();
        int z = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            char n = char.Parse(Interaction.InputBox("Ingrese un caracter"));
            p1.agregar(n);
            Mostrar(p1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p1.eliminar();
            Mostrar(p1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            z++;
            int x = p1.cima;
            p1.cima = x;
            for (int i = 0; i <= p1.cima; i++)
            {
                p2.vector[i] = p1.vector[x];
                x--;
            }
            for (int i = 0; i <= p1.cima; i++)
            {
                p1.vector[i] = p2.vector[i];
            }
            Mostrar(p1);

        }

        private void Mostrar(pila x)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < p1.cima + 1; i++)
            {
                listBox1.Items.Add(x.vector[i]);
            }
        }
    }
}
