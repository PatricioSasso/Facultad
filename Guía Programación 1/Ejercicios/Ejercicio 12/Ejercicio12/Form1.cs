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

namespace Ejercicio12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m=0, t=0, d=0;
            m = int.Parse(Interaction.InputBox("Ingrese el monto"));
            t = int.Parse(Interaction.InputBox("Ingrese la tasa"));
            d = int.Parse(Interaction.InputBox("Ingrese los dias"));
            int calculo = 0;
            calculo = m * t * d / 36500;
            dataGridView1.Rows.Add(4);
            dataGridView1.Rows[0].Cells[0].Value = m;
            dataGridView1.Rows[0].Cells[1].Value = t;
            dataGridView1.Rows[0].Cells[2].Value = d;
            dataGridView1.Rows[0].Cells[3].Value = calculo;





        }
    }
}
