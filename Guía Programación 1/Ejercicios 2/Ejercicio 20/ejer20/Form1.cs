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

namespace ejer20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Pila lapila = new Pila();
        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(Interaction.InputBox("Ingrese numero"));
            lapila.agregar(a);
            if (a % 2 == 0)
            {
                listBox1.Items.Add(a.ToString()); 
            }
            else
            {
                listBox2.Items.Add(a.ToString());
            }
        }
    }
}
