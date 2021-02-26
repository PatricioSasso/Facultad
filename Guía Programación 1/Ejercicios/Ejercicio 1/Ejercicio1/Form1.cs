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

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            a = int.Parse(Interaction.InputBox("Ingrese el primer número"));
            b = int.Parse(Interaction.InputBox("Ingrese el segundo número"));
            MessageBox.Show("" + (a + b));

        }
    }
}
