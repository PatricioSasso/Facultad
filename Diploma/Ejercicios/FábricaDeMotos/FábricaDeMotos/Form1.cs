using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FábricaDeMotos
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

        IMoto moto;

        private void CrearScooter_Click(object sender, EventArgs e)
        {
            Scooter scooter = new Scooter();
            moto = scooter.Clone() as IMoto;
            Mostrar(moto);
        }

        private void CrearEnduro_Click(object sender, EventArgs e)
        {
            Enduro enduro = new Enduro();
            moto = enduro.Clone() as IMoto;
            Mostrar(moto);
        }

        private void CrearPistero_Click(object sender, EventArgs e)
        {
            Pistero pistero = new Pistero();
            moto = pistero.Clone() as IMoto;
            Mostrar(moto);
        }

        private void Mostrar(IMoto moto)
        {
            textBox1.Text += "Se creó una moto " + moto.GetType().Name  + " con motor: " + moto.motor + " , rodado: " + moto.rodado + " , carrocería: " + moto.carroceria + Environment.NewLine;
        }
    }

    public interface IMoto : ICloneable
    {
        string motor { get; set; }
        string rodado { get; set; }
        string carroceria { get; set; }
    }

    public class Scooter : IMoto
    {
        public Scooter()
        {
            this.motor = "50cc";
            this.rodado = "14";
            this.carroceria = "Hierro";
        }

        public string motor { get; set; }
        public string rodado { get; set; }
        public string carroceria { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public class Enduro : IMoto
    {
        public Enduro()
        {
            this.motor = "250cc";
            this.rodado = "22";
            this.carroceria = "Aluminio";
        }

        public string motor { get; set; }
        public string rodado { get; set; }
        public string carroceria { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public class Pistero : IMoto
    {
        public Pistero()
        {
            this.motor = "500cc";
            this.rodado = "19";
            this.carroceria = "Carbono";
        }

        public string motor { get; set; }
        public string rodado { get; set; }
        public string carroceria { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
