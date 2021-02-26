using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2BLL;
using _3DAL_ORM;

namespace Practica3_LUGEjercicio2doParcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        AccesoBD BD;
        MapperPersona MP;

        private void Form1_Load(object sender, EventArgs e)
        {
            BD = new AccesoBD();
            MP = new MapperPersona(BD);
            dataGridView1.MultiSelect = false; dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Cargar(MP.GetList());
        }

        private void Persona_NombrePato(object sender, EventArgs e)
        {
            MessageBox.Show("Alto nombre bro");
        }

        private void buttonAlta_Click(object sender, EventArgs e)
        {
            Alta();
        }

        private void btn_Modificacion_Click(object sender, EventArgs e)
        {
            Modificacion();
        }

        private void btn_Baja_Click(object sender, EventArgs e)
        {
            Baja();
        }

        private void btn_OrdenarNombreAsc_Click(object sender, EventArgs e)
        {
            OrdenarPorNombreAsc();
        }

        private void btn_OrdenarNombreDesc_Click(object sender, EventArgs e)
        {
            OrdenarPorNombreDesc();
        }

        private void btn_Barras_Click(object sender, EventArgs e)
        {
            DibujarBarras();
        }

        private void btn_Torta_Click(object sender, EventArgs e)
        {
            DibujarTorta();
        }

        private void buttonOrdenarId_Click(object sender, EventArgs e)
        {
            Cargar(MP.GetList());
        }

        private void textBoxFiltro_TextChanged(object sender, EventArgs e)
        {
            BusquedaIncremental();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LlenarTextBoxsConSeleccionado();
        }

        void Alta()
        {
            try
            {
                int id = int.Parse(textBoxId.Text);
                string nombre = textBoxNombre.Text;
                string apellido = textBoxApellido.Text;
                if(textBoxFecha.IsTextValid)
                {
                    DateTime fechaNacimiento = DateTime.Parse(textBoxFecha.Text);
                    MP.Alta(new Persona(id, nombre, apellido, fechaNacimiento));
                    Cargar(MP.GetList());
                }
                else { throw new Exception("Fecha de nacimiento incorrecta, el formato es dd/mm/yyyy"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        void Modificacion()
        {
            try
            {
                Persona modificar = (dataGridView1.SelectedRows[0].DataBoundItem as VistaPersona).GetPersona();
                modificar.Id = int.Parse(textBoxId.Text);
                modificar.Nombre = textBoxNombre.Text;
                modificar.Apellido = textBoxApellido.Text;
                if (textBoxFecha.IsTextValid)
                {
                    modificar.FechaNacimiento = DateTime.Parse(textBoxFecha.Text);
                    MP.Modificacion(modificar);
                    Cargar(MP.GetList());
                }
                else { throw new Exception("Fecha de nacimiento incorrecta, el formato es dd/mm/yyyy"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        void Baja()
        {
            try
            {
                Persona eliminar = (dataGridView1.SelectedRows[0].DataBoundItem as VistaPersona).GetPersona();
                MP.Baja(eliminar);
                Cargar(MP.GetList());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        void Cargar(List<Persona> lista)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = MP.GetListVista(lista);
        }

        void OrdenarPorNombreAsc()
        {
            Cargar(MP.GetList().OrderBy(x => x.Nombre).ToList());
        }

        void OrdenarPorNombreDesc()
        {
            Cargar(MP.GetList().OrderByDescending(x => x.Nombre).ToList());
        }

        void DibujarBarras()
        {
            Graphics g = groupBoxBarras.CreateGraphics();
            g.Clear(BackColor);
            int x = 0; int y = 0;
            int widht = groupBoxBarras.Width - 1; int height = groupBoxBarras.Height - 1;
            Rectangle zone = new Rectangle(x, y, widht, height);
            g.DrawRectangle(new Pen(new SolidBrush(Color.Black), 2), zone);
            int edadMin = 0; int edadMax = 10;
            List<int> datos = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                int cantidad = MP.GetListVista(MP.GetList()).Count(p => p.Edad > edadMin && p.Edad <= edadMax);
                datos.Add(cantidad);
                edadMin += 10; edadMax += 10;
            }
            x = 5; y = groupBoxBarras.Height - 1;
            widht = 20; height = 0;
            int mayor = datos.Max();
            int stringNumber = 10;
            if(mayor != 0)
            {
                foreach (var n in datos)
                {
                    height = n * y / mayor;
                    Rectangle draw = new Rectangle(x, y - height, widht, height);
                    g.DrawRectangle(new Pen(new SolidBrush(Color.Black), 2), draw);
                    g.FillRectangle(new SolidBrush(Color.DarkRed), draw);
                    Graphics form = CreateGraphics();
                    form.DrawString(stringNumber.ToString(), this.Font, new SolidBrush(Color.Black), groupBoxBarras.Location.X + x, groupBoxBarras.Bottom);
                    x += 40; stringNumber += 10;
                }
            }
            g.Dispose();
        }

        void DibujarTorta()
        {
            Graphics g = groupBoxTorta.CreateGraphics();
            g.Clear(BackColor); dataGridView2.Rows.Clear();
            int x = 0; int y = 0;
            int widht = groupBoxTorta.Width - 1; int height = groupBoxTorta.Height - 1;
            Rectangle zone = new Rectangle(x, y, widht, height);
            List<float> datos = new List<float>();
            int edadMin = 0; int edadMax = 10;
            for (int i = 0; i < 10; i++)
            {
                int cantidad = MP.GetListVista(MP.GetList()).Count(p => p.Edad > edadMin && p.Edad <= edadMax);
                datos.Add(cantidad);
                dataGridView2.Rows.Add($"Entre {edadMin} y {edadMax} años");
                edadMin += 10; edadMax += 10;
            }
            float desde = 0; float hasta = 0;
            float total = datos.Sum();
            int countColor = 0;
            foreach (var n in datos)
            {
                hasta = n / total * 360;
                g.DrawPie(new Pen(new SolidBrush(Color.Black), 2), zone, desde, hasta);
                Random r = new Random(DateTime.Now.Millisecond + (int)desde + countColor);
                SolidBrush fillColor = new SolidBrush(Color.FromArgb(r.Next(0,255), r.Next(0,255), r.Next(0,255)));
                if(hasta == 0) { fillColor.Color = Color.White; }
                dataGridView2.Rows[countColor].Cells[1].Style.BackColor = fillColor.Color;
                g.FillPie(fillColor, zone, desde, hasta);
                desde += hasta; countColor++;
            }
            g.Dispose();
        }

        void BusquedaIncremental()
        {
            Cargar(MP.GetList(textBoxFiltro.Text));
        }

        void LlenarTextBoxsConSeleccionado()
        {
            Persona p = (dataGridView1.SelectedRows[0].DataBoundItem as VistaPersona).GetPersona();
            textBoxId.Text = p.Id.ToString();
            textBoxNombre.Text = p.Nombre;
            textBoxApellido.Text = p.Apellido;
            textBoxFecha.Text = p.FechaNacimiento.ToShortDateString();
        }
    }
}
