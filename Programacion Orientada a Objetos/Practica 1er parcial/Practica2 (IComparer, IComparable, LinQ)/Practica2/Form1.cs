using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Practica2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Persona> grupo = new List<Persona>();

        private void Form1_Load(object sender, EventArgs e)
        {
            grupo.Add(new Persona("Pato", "Sasso", 19));
            grupo.Add(new Persona("Kati", "Perchet", 19));
            grupo.Add(new Persona("Juan", "Lopez", 23));
            grupo.Add(new Persona("Rodrigo", "Ramirez", 27));
            grupo.Add(new Persona("Elvio", "Lado", 14));
            grupo.Add(new Persona("Armando Esteban", "Quito", 43));
            grupo.Add(new Persona("Benito", "Camela", 30));
            grupo.Add(new Persona("Jhonny", "Mebaño", 20));
            //grupo.Sort(new ComparerPersonas()); // Comparer por edad y nombre
            grupo.Sort(); // Comparable oor edad y nombre
            List<Persona> grupoOrdenado = (from personas in grupo orderby personas.Edad, personas.Nombre select personas).ToList(); // Ordenar por edad y nombre LinQ
            List<Persona> grupoEdad19 = (from personas in grupo where personas.Edad == 19 select personas).ToList(); // Consulta LinQ
            CargarYMostrar(grupo);
            MostrarListBox(grupo);
        }

        public void CargarYMostrar(List<Persona> L)
        {
            dataGridView1.Rows.Clear();
            foreach (var p in L)
            {
                dataGridView1.Rows.Add(p.Nombre, p.Apellido, p.Edad);
            }
        }

        public void MostrarListBox(List<Persona> L)
        {
            listBox1.Items.Clear();
            foreach (var p in grupo)
            {
                listBox1.Items.Add(p.ToString());
            }
        }
    }

    // IComparable se aplica en la clase mientras que IComparer puede aplicarse en una clase o no.
    // Con IComparable heredado.
    public class Persona : IComparable<Persona>
    {
        private string nombre;
        private string apellido;
        private int edad;

        public Persona(string nombre, string apellido, int edad) // Constructor
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public int Edad { get => edad; }

        public override string ToString()
        {
            return nombre + " " + apellido + " "+ edad;
        }

        public int CompareTo(Persona y) // CompareTo de IComparable
        {
            int comparar = this.Edad.CompareTo(y.Edad);
            if(comparar == 0)
            {
                return this.Nombre.CompareTo(y.Nombre);
            }
            else
            {
                return comparar;
            }
        }
    }

    public class ComparerPersonas : IComparer<Persona>
    {
        public int Compare(Persona x, Persona y)
        {
            int comparar = x.Edad.CompareTo(y.Edad);
            if(comparar == 0)
            {
                return x.Nombre.CompareTo(y.Nombre);
            }
            else
            {
                return comparar;
            }
        }
    }

}
