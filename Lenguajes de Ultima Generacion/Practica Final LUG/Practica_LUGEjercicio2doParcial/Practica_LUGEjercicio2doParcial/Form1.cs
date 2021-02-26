using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL_ORM;

namespace Practica_LUGEjercicio2doParcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DatabaseAccess Base;
        MapperPersona MP;

        private void Form1_Load(object sender, EventArgs e)
        {
            Base = new DatabaseAccess();
            MP = new MapperPersona(Base);
            Cargar(MP.GetListVista());
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Alta();
            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Modificacion(dataGridView1.SelectedRows[0].DataBoundItem as Persona);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Baja(dataGridView1.SelectedRows[0].DataBoundItem as Persona);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SortNombre();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SortNombreDescendente();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DibujarGraficoBarras();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DibujarGraficoCircular();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Persona p = dataGridView1.SelectedRows[0].DataBoundItem as Persona;
            textBox1.Text = p.Id.ToString();
            textBox2.Text = p.Nombre;
            textBox3.Text = p.Apellido;
            textBoxSoloFecha1.Text = p.FechaNacimiento.ToShortDateString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            BuscarIncremental();
        }

        void Alta()
        {
            int id = int.Parse(textBox1.Text);
            string nombre = textBox2.Text;
            string apellido = textBox3.Text;
            if(textBoxSoloFecha1.IsValid)
            {
                DateTime fechaNacimiento = DateTime.Parse(textBoxSoloFecha1.Text);
                MP.Alta(new Persona(id, nombre, apellido, fechaNacimiento));
                Cargar(MP.GetListVista());
            }
            else { throw new Exception("Fecha de nacimiento inválida"); }
        }

        void Modificacion(Persona p)
        {
            p.Nombre = textBox2.Text;
            p.Apellido = textBox3.Text;
            if (textBoxSoloFecha1.IsValid)
            {
                p.FechaNacimiento = DateTime.Parse(textBoxSoloFecha1.Text);
                MP.Modificacion(p);
                Cargar(MP.GetListVista());
            }
            else { throw new Exception("Fecha de nacimiento inválida"); }
        }

        void Baja(Persona p)
        {
            MP.Baja(p);
            Cargar(MP.GetListVista());
        }

        void Cargar(List<VistaPersona> lista)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lista;
        }

        void SortNombre()
        {
            Cargar(MP.GetListVista().OrderBy(x => x.Nombre).ToList());
        }

        void SortNombreDescendente()
        {
            Cargar(MP.GetListVista().OrderByDescending(x => x.Nombre).ToList());
        }

        void BuscarIncremental()
        {
            Cargar(MP.GetListVista(MP.BuscarIncremental(textBox4.Text)));
        }

        void DibujarGraficoBarras()
        {
            Graphics g = groupBox1.CreateGraphics();
            g.Clear(this.BackColor);
            Rectangle groupboxZone = new Rectangle(0, 0, groupBox1.Width - 1, groupBox1.Height - 1);
            g.DrawRectangle(new Pen(new SolidBrush(Color.Black)), groupboxZone);
            List<Persona> personas = MP.GetList();
            List<int> datos = new List<int>();
            int edadMin = 0; int edadMax = 10;
            for (int i = 0; i < 10; i++)
            {
                int cantidad = personas.Count(e => e.Edad > edadMin && e.Edad <= edadMax);
                datos.Add(cantidad);
                edadMin += 10; edadMax += 10;
            }
            int x = 5;      int y = groupBox1.Height - 1;
            int width = 15; int height = 0;
            int max = datos.Max();
            foreach (int n in datos)
            {
                height = (n * y / max) - 1;
                Rectangle r = new Rectangle(x, y - height, width, height);
                g.DrawRectangle(new Pen(new SolidBrush(Color.Black), 2), r);
                g.FillRectangle(new SolidBrush(Color.Aqua), r);
                x += 30;
            }
            g.Dispose();
        }

        void DibujarGraficoCircular()
        {
            Graphics g = groupBox2.CreateGraphics();
            g.Clear(this.BackColor); dataGridView2.Rows.Clear();
            int x = 0; int y = 0; 
            int widht = groupBox2.Width - 1; int height = groupBox2.Height - 1;
            Rectangle groupbox2Zone = new Rectangle(x, y, widht, height);
            List<Persona> personas = MP.GetList();
            List<int> datos = new List<int>();
            int edadMin = 0; int edadMax = 10;
            for (int i = 0; i < 10; i++)
            {
                int cantidad = personas.Count(e => e.Edad > edadMin && e.Edad <= edadMax);
                datos.Add(cantidad);
                dataGridView2.Rows.Add($"Entre { edadMin } y { edadMax }");
                edadMin += 10; edadMax += 10;
            }
            float desde = 0; float hasta = 0;
            float total = datos.Sum(); int countColor = 0;
            foreach (float n in datos)
            {
                hasta = n / total * 360;
                g.DrawPie(new Pen(new SolidBrush(Color.Black), 2), groupbox2Zone, desde, hasta);
                Random r = new Random(DateTime.Now.Millisecond + (int)desde + countColor);
                SolidBrush color = new SolidBrush(Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255)));
                if(hasta == 0) { color.Color = Color.White; }
                g.FillPie(color, groupbox2Zone, desde, hasta);
                dataGridView2.Rows[countColor].Cells[1].Style.BackColor = color.Color;
                desde += hasta; countColor++;
            }
            g.Dispose();
        }
    }
}
