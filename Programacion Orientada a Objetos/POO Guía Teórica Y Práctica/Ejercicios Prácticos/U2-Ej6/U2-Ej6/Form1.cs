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

namespace U2_Ej6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Estudiante> E = new List<Estudiante>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int Dni = int.Parse(Interaction.InputBox("Ingresar id"));
            if (E.Exists(E => E.Dni == Dni))
            {
                MessageBox.Show("El dni ya existe");
            }
            else
            {
                string Nombre = Interaction.InputBox("Ingresar nombre");
                string Apellido = Interaction.InputBox("Ingresar apellido");
                int Legajo = int.Parse(Interaction.InputBox("Ingrsar legajo"));
                decimal Promedio = decimal.Parse(Interaction.InputBox("Ingresar promedio"));
                E.Add(new Estudiante(Dni, Nombre, Apellido, Legajo, Promedio));
                Cargar();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int Dni = int.Parse(Interaction.InputBox("Ingresar id"));
            E.Remove(E.Find(E => E.Dni == Dni));
            Cargar();
        }

        public void Cargar()
        {
            textBox1.Clear();
            foreach (var e in E)
            {
                textBox1.Text += e.Mensaje() + "\r\n";
            }
        }
    }

    public class Persona
    {
        private int dni;
        private string nombre;
        private string apellido;

        public Persona(int dni, string nombre, string apellido)
        {
            this.dni = dni; // Utilizamos this para referirnos la variable de la clase en la que nos encontramos.
                            // En este caso diferenciamos la variable dni de la clase Persona con this, ya que
                            // existe una variable dni en la firma y se requiere diferenciarlas.
            this.nombre = nombre; // En este caso sucede lo mismo que el caso anterior, solo que con la variable nombre.
            this.apellido = apellido;
        }

        public string Info()
        {
            return Nombre + " " + Apellido;
        }

        public int Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
    }

    public class Estudiante : Persona
    {
        private int legajo;
        private decimal promedio;

        public Estudiante(int dni, string nombre, string apellido, int legajo, decimal promedio) : base(dni,nombre,apellido) 
        {                                                             // base sirve para referirse a los elementos de 
            this.Legajo = legajo;                                     // la clase padre (o clase base).
            this.Promedio = promedio;                                                    
        }

        public decimal Promedio { get => promedio; set => promedio = value; }
        public int Legajo { get => legajo; set => legajo = value; }

        public string Mensaje()
        {
            return "El alumno " + base.Info() + " con legajo " + Legajo + " tiene promedio " + Promedio+ " .";
            // Aquí llamamos al método Info() que proviene de la clase base, lo mismo sucede con eventos o campos.
        }
    }
}
