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
using ORM___DAL;

namespace Practica2_LUGEjercicio2doParcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        AccesoBD BaseDatos;
        MapperPersona MP; 

        private void Form1_Load(object sender, EventArgs e)
        {
            BaseDatos = new AccesoBD();
            MP= new MapperPersona(BaseDatos);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; dataGridView1.MultiSelect = false;
            CargarDGV1(MP.GetListVista());
        }

        private void btn_Alta_Click(object sender, EventArgs e)
        {
            Alta();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            Modificacion();
        }

        private void btn_Baja_Click(object sender, EventArgs e)
        {
            Baja();
        }

        private void btn_OrdenNombreAscendente_Click(object sender, EventArgs e)
        {
            OrdenarNombreAscendentemente();
        }

        private void btn_OrdenNombreDescendente_Click(object sender, EventArgs e)
        {
            OrdenarNombreDescendentemente();
        }

        private void btn_Barras_Click(object sender, EventArgs e)
        {
            DibujarGraficoBarras();
        }

        private void btn_Torta_Click(object sender, EventArgs e)
        {
            DibujarGraficoTorta();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Persona p = (dataGridView1.SelectedRows[0].DataBoundItem as VistaPersona).GetPersona();
            textBoxId.Text = p.Id.ToString();
            textBoxNombre.Text = p.Nombre;
            textBoxApellido.Text = p.Apellido;
            userControl11.Text = p.FechaNacimiento.ToShortDateString();
        }

        private void textBoxFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Persona> listaFiltro = MP.GetList(textBoxFiltro.Text);
            CargarDGV1(MP.GetListVista(listaFiltro));
        }

        void Alta()
        {
            try
            {
                int id = int.Parse(textBoxId.Text);
                string nombre = textBoxNombre.Text;
                string apellido = textBoxApellido.Text;
                if(userControl11.IsTextValid)
                {
                    DateTime fechaNacimiento = DateTime.Parse(userControl11.Text);
                    MP.Alta(new Persona(id, nombre, apellido, fechaNacimiento));
                    CargarDGV1(MP.GetListVista());
                }
                else { throw new Exception("La fecha de nacimiento tiene formato incorrecto, debe ser dd/mm/yyyy"); }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        void Modificacion()
        {
            try
            {
                Persona p = (dataGridView1.SelectedRows[0].DataBoundItem as VistaPersona).GetPersona();
                p.Nombre = textBoxNombre.Text;
                p.Apellido = textBoxApellido.Text;
                if (userControl11.IsTextValid)
                {
                    p.FechaNacimiento = DateTime.Parse(userControl11.Text);
                    MP.Modificacion(p);
                    CargarDGV1(MP.GetListVista());
                }
                else { throw new Exception("La fecha de nacimiento tiene formato incorrecto, debe ser dd/mm/yyyy"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        void Baja()
        {
            try
            {
                Persona p = (dataGridView1.SelectedRows[0].DataBoundItem as VistaPersona).GetPersona();
                MP.Baja(p);
                CargarDGV1(MP.GetListVista());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        void CargarDGV1(List<VistaPersona> listaPersona)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaPersona;
        }

        void OrdenarNombreAscendentemente()
        {
            List<Persona> listaOrdenada = MP.GetList().OrderBy(x => x.Nombre).ToList();
            MP.GetListVista(listaOrdenada);
        }

        void OrdenarNombreDescendentemente()
        {
            List<Persona> listaOrdenada = MP.GetList().OrderByDescending(x => x.Nombre).ToList();
            MP.GetListVista(listaOrdenada);
        }

        void DibujarGraficoBarras()
        {
            Graphics g = groupBoxBarras.CreateGraphics();
            g.Clear(BackColor);
            int x = 0; int y = 0; 
            int widht = groupBoxBarras.Width - 1; int height = groupBoxBarras.Height - 1;
            Rectangle zone = new Rectangle(x, y, widht, height);
            g.DrawRectangle(new Pen(new SolidBrush(Color.Black), 2), zone);
            int edadMin = 0; int edadMax = 10;
            List<int> datos = new List<int>(); 
            x = 8; // Para ubicar el DrawString
            for (int i = 0; i < 10; i++)
            {
                int cantidad = MP.GetListVista().Count(p => p.Edad > edadMin && p.Edad <= edadMax);
                datos.Add(cantidad); 
                Graphics form = this.CreateGraphics();
                form.DrawString(edadMax.ToString(), this.Font, new SolidBrush(Color.Black),//Ubica 
                                groupBoxBarras.Location.X + x, groupBoxBarras.Bottom); //abajo del 
                edadMin += 10; edadMax += 10; x += 30;                                 // groupbox
            }
            x = 5; y = groupBoxBarras.Height - 1;
            widht = 20; height = 0;
            int mayor = datos.Max();
            foreach (int n in datos)
            {
                height = (n * y / mayor) - 1;
                Rectangle draw = new Rectangle(x, y - height, widht, height);
                g.DrawRectangle(new Pen(new SolidBrush(Color.Black),2), draw);
                g.FillRectangle(new SolidBrush(Color.LightBlue), draw);
                x += 30;
            }
            g.Dispose();
        }

        void DibujarGraficoTorta()
        {
            Graphics g = groupBoxTorta.CreateGraphics();
            g.Clear(BackColor); dataGridView2.Rows.Clear();
            List<int> datos = new List<int>();
            int edadMin = 0; int edadMax = 10;
            for (int i = 0; i < 10; i++)
            {
                int cantidad = MP.GetListVista().Count(p => p.Edad > edadMin && p.Edad <= edadMax);
                datos.Add(cantidad);
                dataGridView2.Rows.Add($"Entre {edadMin} y {edadMax} años");
                edadMin += 10; edadMax += 10;
            }
            int x = 0; int y = 0;
            int widht = groupBoxTorta.Width - 1; int height = groupBoxTorta.Height - 1;
            Rectangle zone = new Rectangle(x, y, widht, height);
            float total = datos.Sum();
            float desde = 0; float hasta = 0;
            int countColor = 0;
            foreach (float n in datos)
            {
                hasta = n / total * 360;
                g.DrawPie(new Pen(new SolidBrush(Color.Black), 2), zone, desde, hasta);
                Random r = new Random(DateTime.Now.Millisecond + (int)desde + countColor);
                SolidBrush colorRelleno = new SolidBrush(Color.FromArgb(r.Next(0,255), r.Next(0,255), r.Next(0,255)));
                if (hasta == 0) { colorRelleno.Color = Color.White; }
                g.FillPie(colorRelleno, zone, desde, hasta);
                dataGridView2.Rows[countColor].Cells[1].Style.BackColor = colorRelleno.Color;
                desde += hasta; countColor++;
            }
            g.Dispose();
        }
    }
}
