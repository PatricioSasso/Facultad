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

namespace U3_Ej11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(Interaction.InputBox("Ingrese un número entre 1 y 50"));
                if(n < 1) { throw new NumeroMenorQue1Exception(n); }
                if(n < 50) { throw new Exception("El número " + n + " no es válido"); }
            }
            catch (NumeroMenorQue1Exception ex)
            {
                MessageBox.Show("El número " + ex.Numero + " no es válido.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    public class NumeroMenorQue1Exception : Exception
    {
        private int numero;

        public NumeroMenorQue1Exception(int numero)
        {
            Numero = numero;
        }

        public int Numero { get => numero; set => numero = value; }
    }
}
