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

namespace U1_EJ4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Empleado> L = new List<Empleado>();

        private void Button1_Click(object sender, EventArgs e)
        {
            if(L.Count == 1)
            {
                MessageBox.Show("Ya existe 1 empleado.");
            }
            else
            {
                string nombre = Interaction.InputBox("Ingrese el nombre");
                int edad = int.Parse(Interaction.InputBox("Ingrese la edad"));
                string trabajo =Interaction.InputBox("Ingrese el nombre del trabajo");
                L.Add(new Empleado(nombre, edad, trabajo));
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(L.Count == 1)
            {
                L.Clear();
            }
            else
            {
                MessageBox.Show("No existe ningún empleado");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (L.Count == 1)
            {
                textBox1.Text += L[0].trabajar();
            }
            else
            {
                MessageBox.Show("No existe ningún empleado");
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                return;
            }
            else
            {
                textBox1.Text = "";
            }
        }
    }

    public abstract class Persona
    {
        string nombre;
        int edad;

        protected Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
    }

    public abstract class Trabajador : Persona
    {
        string trabajo;

        protected Trabajador(string nombre, int edad, string trabajo) : base(nombre, edad)
        {
            Trabajo = trabajo;
        }

        public string Trabajo { get => trabajo; set => trabajo = value; }
        public abstract string trabajar();
    }

    public class Empleado : Trabajador
    {
        public Empleado(string nombre, int edad, string trabajo) : base(nombre, edad, trabajo)
        {
        }

        public override string trabajar()
        {
            return Nombre + " está trabajando como " + Trabajo + " .\r\n";
        }
    }
}
