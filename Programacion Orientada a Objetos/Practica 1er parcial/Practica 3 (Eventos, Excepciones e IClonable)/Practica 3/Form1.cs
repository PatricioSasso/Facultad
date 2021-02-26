using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            e.Evento += Evento_Mensaje;
        }

        public void Evento_Mensaje(object sender, EventArgs e)
        {
            MessageBox.Show("Eventoooo");
        }

        Robot e = new Robot(6,"A",23);

        List<Robot> R = new List<Robot>();


        private void Form1_Load(object sender, EventArgs e)
        {
            R.Add(new Robot(1, "A", 20));
            R.Add((Robot)R[0].Clone());
            MostrarData(dataGridView1, R[0]);
            MostrarData(dataGridView2, R[1]);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            R[0].Modificar(R[0], int.Parse(textBox1.Text), textBox2.Text, int.Parse(textBox3.Text));
            MostrarData(dataGridView1, R[0]);
            MostrarData(dataGridView2, R[1]);
        }

        public void MostrarData(DataGridView d, Robot N)
        {
            d.Rows.Clear();
            d.Rows.Add(N.Codigo, N.Nombre, N.Años);
        }

    }

    public class Robot : ICloneable
    {
        private int codigo;
        private string nombre;
        private int años;

        public event EventHandler<EventoCodigo> Evento;

        public Robot(int codigo, string nombre, int años)
        {
            this.Codigo = codigo;
            this.nombre = nombre;
            this.años = años;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Años { get => años; set => años = value; }
        public int Codigo { get => codigo; set => codigo = value; }

        public void Modificar(Robot N, int nuevoCodigo, string nuevoNombre, int nuevoAños)
        {
            N.Codigo = nuevoCodigo;
            if (nuevoCodigo == 1000)
            {
                Evento.Invoke(this, new EventoCodigo());
            }
            N.Nombre = nuevoNombre;
            N.Años = nuevoAños;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public class EventoCodigo : EventArgs
    {
        public void Mensaje()
        {
            MessageBox.Show("Evento");
        }
    }
}
