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

namespace U2_Ej7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Persona.Dueño> L = new List<Persona.Dueño>();

        private void Form1_Load(object sender, EventArgs e)
        {
            int dni = int.Parse(Interaction.InputBox("Escriba su dni"));
            string nombre = Interaction.InputBox("Escriba su nombre");
            string p_nombre = Interaction.InputBox("Escriba un nombre para su perro");
            Perro mascota = new Perro(p_nombre);
            Persona.Dueño A = new Persona.Dueño(dni,nombre,mascota);
            L.Add(A);
            groupBox1.Text = nombre;
            label1.Text = "Perro : " + p_nombre;
            textBox1.Text = "¡" + p_nombre + " tiene hambre!";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "\r\n" + L[0].Alimentar();
        }
    }

    public abstract class Animal
    {
        private string nombre;
        private bool hambre;

        protected Animal(string nombre)
        {
            Nombre = nombre;
            Hambre = true;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public bool Hambre { get => hambre; set => hambre = value; }

        public virtual string Comer()
        {
            if(Hambre == true)
            {
                Hambre = false;
                return Nombre + " comió su comida.";
            }
            else
            {
                return Nombre + " no tiene hambre.";
            }
        }
    }

    public sealed class Perro : Animal
    {
        public Perro(string nombre) : base(nombre)
        {
        }
    }

    public abstract class Persona
    {
        private int dni;
        private string nombre;

        public Persona(int dni, string nombre)
        {
            Dni = dni;
            Nombre = nombre;
        }

        public int Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public class Dueño : Persona
        {
            private Perro mascota;

            public Dueño(int dni, string nombre, Perro mascota) : base(dni, nombre)
            {
                Mascota = mascota;
            }

            public Perro Mascota { get => mascota; set => mascota = value; }

            public string Alimentar()
            {
                return Mascota.Comer();
            }
        }
    }
}
