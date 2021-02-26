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

namespace U5_Ej2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            P.Add(new Persona(1, "A", "B"));
            P.Add(new Persona(2, "Z", "Y"));
            P.Add(new Persona(3, "D", "G"));
            P.Add(new Persona(4, "F", "H"));
            Cargar(P,dataGridView1);
        }

        List<Persona> P = new List<Persona>();

        public void Cargar(List<Persona> L, DataGridView D)
        {
            D.Rows.Clear();
            foreach (var p in L)
            {
                D.Rows.Add(p.Dni, p.Nombre, p.Apellido);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            List<Persona> Consulta = (from p in P orderby p.Dni select p).ToList();
            Cargar(Consulta, dataGridView1);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            List<Persona> Consulta = (from p in P orderby p.Dni descending select p).ToList();
            Cargar(Consulta, dataGridView1);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int n = int.Parse(Interaction.InputBox("Desea buscar los dni mayores a ..."));
            List<Persona> Consulta = (from p in P where p.Dni > n select p).ToList();
            Cargar(Consulta, dataGridView2);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            int n = int.Parse(Interaction.InputBox("Desea buscar los dni menores a ..."));
            List<Persona> Consulta = (from p in P where p.Dni < n select p).ToList();
            Cargar(Consulta, dataGridView2);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            int n = int.Parse(Interaction.InputBox("¿Que dni desea buscar?"));
            List<Persona> Consulta = (from p in P where p.Dni == n select p).ToList();
            Cargar(Consulta, dataGridView2);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("¿Que nombre desea buscar?");
            List<Persona> Consulta = (from p in P where p.Nombre == nombre select p).ToList();
            Cargar(Consulta, dataGridView2);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            string apellido = Interaction.InputBox("¿Que apellido desea buscar?");
            List<Persona> Consulta = (from p in P where p.Apellido == apellido select p).ToList();
            Cargar(Consulta, dataGridView2);
        }
    }

    public class Persona
    {
        private int dni;
        private string nombre;
        private string apellido;

        public Persona(int dni, string nombre, string apellido)
        {
            this.dni = dni;
            this.nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            this.apellido = apellido ?? throw new ArgumentNullException(nameof(apellido));
        }

        public int Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
    }
}
