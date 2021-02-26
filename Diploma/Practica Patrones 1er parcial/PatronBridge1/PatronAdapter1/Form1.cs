using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Hosting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatronAdapter1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new object[] {new Comun(), new Economico(), new AdapterElectrico() });
            comboBox1.SelectedItem = comboBox1.Items[0];
            comboBox1.DisplayMember = "nombre";
        }

        private void btn_Encender_Click(object sender, EventArgs e)
        {
            txt_Main.Text += ((IMotor)comboBox1.SelectedItem).encender();
        }

        private void btn_Acelerar_Click(object sender, EventArgs e)
        {
            txt_Main.Text += ((IMotor)comboBox1.SelectedItem).acelerar();
        }

        private void btn_Apagar_Click(object sender, EventArgs e)
        {
            txt_Main.Text += ((IMotor)comboBox1.SelectedItem).apagar();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Main.Text = "";
        }
    }

    public interface IMotor
    {
        string nombre { get; set; }
        string encender();
        string acelerar();
        string apagar();
    }

    public class Comun : IMotor
    {
        public Comun()
        {
            this.nombre = "Común";
        }

        public string nombre { get; set; }

        public string acelerar()
        {
            return "Acelerando el motor común" + Environment.NewLine;
        }

        public string apagar()
        {
            return "Apagando el motor común" + Environment.NewLine;
        }

        public string encender()
        {
            return "Encendiendo el motor común" + Environment.NewLine;
        }
    }

    public class Economico : IMotor
    {
        public Economico()
        {
            this.nombre = "Económico";
        }

        public string nombre { get; set; }

        public string acelerar()
        {
            return "Acelerando el motor económico" + Environment.NewLine;
        }

        public string apagar()
        {
            return "Apagando el motor económico" + Environment.NewLine;
        }

        public string encender()
        {
            return "Encendiendo el motor económico" + Environment.NewLine;
        }
    }

    public class AdapterElectrico : IMotor
    {
        Electrico electrico;
        public AdapterElectrico()
        {
            electrico = new Electrico();
            this.nombre = "Electrico";
        }

        public string nombre { get; set; }

        public string acelerar()
        {
            return electrico.moverMasRapido();
        }

        public string apagar()
        {
            return electrico.detener() + electrico.desconectar();
        }

        public string encender()
        {
            return electrico.conectar() + electrico.activar();
        }
    }

    // No puede usar IMotor, ya que acelera, apaga o enciende,
    // sino que conecta, activa, mueve más rápido, detiene y desconecta.
    public class Electrico
    {
        public string conectar()
        {
            return "Conectando el motor eléctrico" + Environment.NewLine;
        }

        public string activar()
        {
            return "Activando el motor eléctrico" + Environment.NewLine;
        }

        public string moverMasRapido()
        {
            return "Moviendo más rápido el motor eléctrico" + Environment.NewLine;
        }

        public string detener()
        {
            return "Deteniendo el motor eléctrico" + Environment.NewLine;
        }

        public string desconectar()
        {
            return "Desconectando el motor eléctrico" + Environment.NewLine;
        }
    }
}
