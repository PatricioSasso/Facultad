using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BLL;
using DAL___ORM;

namespace Vista_LUG2dPPractica2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BaseDatos Base;
        MapperInmobiliaria MInmobiliaria;
        bool ValidId;

        private void Form1_Load(object sender, EventArgs e)
        {
            Base = new BaseDatos();
            MInmobiliaria = new MapperInmobiliaria(Base);
            ValidId = false;

            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.MultiSelect = false;
            Mostrar();
       }

        private void btn_AgregarInmobiliarias_Click(object sender, EventArgs e)
        {
            Alta();
            Mostrar();
        }

        private void btn_ModificarInmobiliarias_Click(object sender, EventArgs e)
        {
            Modificar();
            Mostrar();
        }

        private void btn_EliminarInmobiliarias_Click(object sender, EventArgs e)
        {
            Baja();
            Mostrar();
        }

        private void Alta()
        {
            try
            {
                if (ValidId) { 
                    int Id = int.Parse(textBox1.Text);
                    string Nombre = textBox2.Text;
                    double TotalRecaudado = double.Parse(textBox3.Text);
                    MInmobiliaria.Alta(new Inmobiliaria(Id, Nombre, TotalRecaudado));
                } else { throw new Exception("Debe seguir el formato AAA-000."); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Modificar()
        {
            try
            {
                VistaInmobiliaria seleccionado = dataGridView1.SelectedRows[0].DataBoundItem as VistaInmobiliaria;
                Inmobiliaria modificar = new Inmobiliaria(seleccionado.Id, seleccionado.Nombre, seleccionado.TotalRecaudado);
                modificar.Nombre = textBox2.Text;
                modificar.TotalRecaudado = double.Parse(textBox3.Text);
                MInmobiliaria.Modificar(modificar);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Baja()
        {
            try
            {
                VistaInmobiliaria seleccionado = dataGridView1.SelectedRows[0].DataBoundItem as VistaInmobiliaria;
                Inmobiliaria eliminar = new Inmobiliaria(seleccionado.Id, seleccionado.Nombre, seleccionado.TotalRecaudado);
                MInmobiliaria.Eliminar(eliminar);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Mostrar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = MInmobiliaria.GetInmobiliarias();
        }

        private void Mostrar2(List<SolidBrush> brush)
        {
            dataGridView2.Rows.Clear();
            int count = 0;
            foreach (var i in MInmobiliaria.GetInmobiliarias())
            {
                dataGridView2.Rows.Add(i.Id, i.Nombre, i.TotalRecaudado, "");
                dataGridView2.Rows[count].Cells[3].Style.BackColor = brush[count].Color;
                count++;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Regex controlId = new Regex(@"\d{3}");
            Match matchControlId = controlId.Match(textBox1.Text);
            if (matchControlId.Success) { ValidId = true; } else { ValidId = false; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GraficoTorta();
        }

        private void GraficoTorta()
        {
            Graphics G = groupBox1.CreateGraphics();
            float total = 0;
            float desde = 0;
            foreach (var i in MInmobiliaria.GetInmobiliarias())
            {
                total += (float)i.TotalRecaudado;
            }
            G.Clear(this.BackColor);
            List<SolidBrush> xbrush = new List<SolidBrush>();
            int count = 0;
            foreach (var i in MInmobiliaria.GetInmobiliarias())
            {
                Random r = new Random(DateTime.Now.Millisecond);
                float porcion = ((float)i.TotalRecaudado / total) * 360;
                SolidBrush brush = new SolidBrush(Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255)));
                G.DrawPie(new Pen(Color.Black, 2), 10, 15, 150, 150, desde, porcion);
                G.FillPie(brush, 10, 15, 150, 150, desde, porcion);
                desde += porcion;
                count++;
                xbrush.Add(brush);
            }
            G.Dispose();
            Mostrar2(xbrush);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Pintar2();
        }
    }
}
