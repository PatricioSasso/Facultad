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

namespace ejer13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        lista n = new lista();
        int size = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            string fecha = Interaction.InputBox("Ingrese el día") + "-" + Interaction.InputBox("Ingrese el mes") + "-" + Interaction.InputBox("Ingrese el año");
            int nro = int.Parse(Interaction.InputBox("Ingrese el Nro de Cta"));
            decimal monto = int.Parse(Interaction.InputBox("Ingrese el Monto"));
            string tipo = Interaction.InputBox("Ingrese si es Deposito o Extracción");
            n.agregaralprincipio(fecha, nro, monto, tipo);
            size++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int pos = int.Parse(Interaction.InputBox("Ingrese un número entre" + 1 + " y " + n.size)) - 1;
            string fecha = Interaction.InputBox("Ingrese el día") + "-" + Interaction.InputBox("Ingrese el mes") + "-" + Interaction.InputBox("Ingrese el año");
            int nro = int.Parse(Interaction.InputBox("Ingrese el Nro de Cta"));
            decimal monto = int.Parse(Interaction.InputBox("Ingrese el Monto"));
            string tipo = Interaction.InputBox("Ingrese si es Deposito o Extracción");
            n.agregarenn(fecha, nro, monto, tipo, pos);
            size++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string fecha = Interaction.InputBox("Ingrese el día") + "-" + Interaction.InputBox("Ingrese el mes") + "-" + Interaction.InputBox("Ingrese el año");
            int nro = int.Parse(Interaction.InputBox("Ingrese el Nro de Cta"));
            decimal monto = int.Parse(Interaction.InputBox("Ingrese el Monto"));
            string tipo = Interaction.InputBox("Ingrese si es Deposito o Extracción");
            n.agregaralfinal(fecha, nro, monto, tipo);
            size++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            n.sacarprimero();
            size--;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int pos = int.Parse(Interaction.InputBox("Ingrese un número entre" + 1 + " y " + n.size)) - 1;
            n.sacarenn(pos);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            n.sacarultimo();
            size--;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int pos = int.Parse(Interaction.InputBox("Ingrese un número entre" + 0 + " y " + size)) - 1;
            MessageBox.Show("Fecha : " + n.buscarnodo(pos).fecha + "       Número de Cuenta : " + n.buscarnodo(pos).nro.ToString() + "        Monto : " + n.buscarnodo(pos).monto.ToString() + "         Tipo : " + n.buscarnodo(pos).tipo);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            n.ordenar(n);
        }
    }
}
