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

namespace ejercicio9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int min, max, i, j;
            int aux=0;
            min = int.Parse(Interaction.InputBox("Ingrese un número mínimo: "));
            max = int.Parse(Interaction.InputBox("Ingrese un número máximo: "));
            for(i=min;i<max;i++)
            {
                for (j = 1; j < max; j++)
                {
                    if (i % j == 0)
                    {
                        aux++;
                    }
                }
                if (aux == 2)
                {
                    listBox1.Items.Add(i);
                }
                
                aux = 0;

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
