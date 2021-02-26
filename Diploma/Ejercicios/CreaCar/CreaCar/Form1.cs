using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace CreaCar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fabricante = new Fabricante();
        }
        Fabricante fabricante;
        private void buttonFiesta_Click(object sender, EventArgs e)
        {
            BuilderFordFiesta builder = new BuilderFordFiesta();
            string cantidadPuertas = Interaction.InputBox("Quiere 5 o 3 puertas");
            if (cantidadPuertas == "3" || cantidadPuertas == "5")
            {
                var auto=fabricante.ConstruirAuto(builder, int.Parse(cantidadPuertas));
                Mostrar(auto);
            }
            else
            {
                MessageBox.Show("Cantidad de puertas incorrectas");
            }
        }

        private void buttonFocus_Click(object sender, EventArgs e)
        {
            BuilderFordFocus builder = new BuilderFordFocus();
            string cantidadPuertas = Interaction.InputBox("Quiere 5 o 3 puertas");
            if (cantidadPuertas == "3" || cantidadPuertas == "5")
            {
                var auto = fabricante.ConstruirAuto(builder, int.Parse(cantidadPuertas));
                Mostrar(auto);

            }
            else
            {
                MessageBox.Show("Cantidad de puertas incorrectas");
            }
        }

        private void buttonSiena_Click(object sender, EventArgs e)
        {
            BuilderFiatSiena builder = new BuilderFiatSiena();
            string cantidadPuertas = Interaction.InputBox("Quiere 5 o 3 puertas");
            if (cantidadPuertas == "3" || cantidadPuertas == "5")
            {
                var auto = fabricante.ConstruirAuto(builder, int.Parse(cantidadPuertas));
                Mostrar(auto);

            }
            else
            {
                MessageBox.Show("Cantidad de puertas incorrectas");
            }
        }

        private void buttonPalio_Click(object sender, EventArgs e)
        {
            BuilderFiatPalio builder = new BuilderFiatPalio();
            string cantidadPuertas = Interaction.InputBox("Quiere 5 o 3 puertas");
            if (cantidadPuertas == "3" || cantidadPuertas == "5")
            {
                var auto = fabricante.ConstruirAuto(builder, int.Parse(cantidadPuertas));
                Mostrar(auto);

            }
            else
            {
                MessageBox.Show("Cantidad de puertas incorrectas");
            }
        }
        public void Mostrar(Auto auto)
        {
            textBox1.Text += $"Se construyo un ==> {auto.Marca} {auto.Modelo} _Cantidad de puertas: {auto.CamtidadPuertas} Motor: _Potencia{auto.Motor.Potencia} _Num.Serie: {auto.Motor.Numero} \r\n";
        }
    }
}
