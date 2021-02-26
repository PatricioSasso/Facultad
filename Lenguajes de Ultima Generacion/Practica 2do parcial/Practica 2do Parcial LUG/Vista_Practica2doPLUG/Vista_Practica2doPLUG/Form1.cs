using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_Practica2doPLUG;
using ORM_Practica2doPLUG;
using DAL_Practica2doPLUG;

namespace Vista_Practica2doPLUG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BaseDatos Base;
        MapperInmobiliaria MInmobiliaria;
        MapperInmueble MInmueble;

        private void Form1_Load(object sender, EventArgs e)
        {
            Base = new BaseDatos();
            MInmobiliaria = new MapperInmobiliaria(Base);
            MInmueble = new MapperInmueble(Base);

            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.MultiSelect = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            MostrarInmobiliaria();
            MostrarInmobiliariaInmuebles();

            Inmobiliaria.Evento += MensajeEvento;
            GraficoDeTorta();
        }

        public void MensajeEvento(object sender, EventoTotalRecaudadoMayorQue1Millon e)
        {
            MessageBox.Show($"La Inmobiliaria \n{e.Mensaje()}\n tuvo más de 1 millón de ventas");
        }

        private void btn_AgregarInmobiliaria_Click(object sender, EventArgs e)
        {
            AltaInmobiliaria();
            MostrarInmobiliaria();
        }

        private void btn_ModificarInmobiliaria_Click(object sender, EventArgs e)
        {
            ModificarInmobiliaria();
            MostrarInmobiliaria();
        }

        private void btn_EliminarInmobiliaria_Click(object sender, EventArgs e)
        {
            EliminarInmobiliaria();
            MostrarInmobiliaria();
        }

        private void btn_AgregarInmueble_Click(object sender, EventArgs e)
        {
            AltaInmueble();
            MostrarInmobiliaria();
        }

        private void btn_ModificarInmueble_Click(object sender, EventArgs e)
        {
            ModificarInmueble();
            MostrarInmobiliaria();
        }

        private void btn_EliminarInmueble_Click(object sender, EventArgs e)
        {
            BajaInmueble();
            MostrarInmobiliaria();
        }

        #region ABM Inmueble e Inmobiliaria

        private void AltaInmueble()
        {
            try
            {
                if (!textBox_Id_Y_Direccion1.TextBoxId_Valido)
                { throw new Exception("Id inválido debe seguir el formato AAA-000"); }
                if(!textBox_Id_Y_Direccion1.TextBoxDireccion_Valido)
                { throw new Exception("Id inválido debe seguir el formato Calle 0000");}
                Inmueble i = new Inmueble(id: textBox_Id_Y_Direccion1.TextId, 
                                          direccion: textBox_Id_Y_Direccion1.TextDireccion,
                                          valor: double.Parse(textBoxValor.Text), 
                                          fechaPublicacion: DateTime.Parse(textBoxPublicacion.Text),
                                          fechaVenta: DateTime.Parse(textBoxVenta.Text));
                Inmobiliaria inmobiliaria = dataGridView1.SelectedRows[0].DataBoundItem as Inmobiliaria;
                MInmueble.Alta(i, inmobiliaria);
                inmobiliaria.AgregarInmueble(i);
                MInmobiliaria.Modificacion(inmobiliaria);
                
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ModificarInmueble()
        {
            try
            {
                if (!textBox_Id_Y_Direccion1.TextBoxId_Valido)
                { throw new Exception("Id inválido debe seguir el formato AAA-000"); }
                if (!textBox_Id_Y_Direccion1.TextBoxDireccion_Valido)
                { throw new Exception("Dirreccion inválida debe seguir el formato Calle 0000"); }
                Inmueble modificar = dataGridView2.SelectedRows[0].DataBoundItem as Inmueble;
                modificar.Direccion = textBox_Id_Y_Direccion1.TextDireccion;
                modificar.Valor = double.Parse(textBoxValor.Text);
                modificar.FechaPublicacion = DateTime.Parse(textBoxPublicacion.Text);
                modificar.FechaVenta = DateTime.Parse(textBoxVenta.Text);
                MInmueble.Modificacion(modificar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BajaInmueble()
        {
            try
            {
                Inmueble eliminar = dataGridView2.SelectedRows[0].DataBoundItem as Inmueble;
                Inmobiliaria inmobiliaria = dataGridView1.SelectedRows[0].DataBoundItem as Inmobiliaria;
                inmobiliaria.SacarInmueble(eliminar);
                MInmobiliaria.Modificacion(inmobiliaria);
                MInmueble.Baja(eliminar);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void AltaInmobiliaria()
        {
            try
            {
                MInmobiliaria.Alta(new Inmobiliaria(int.Parse(textBoxId2.Text), textBoxNombre.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ModificarInmobiliaria()
        {
            try
            {
                Inmobiliaria modificar = dataGridView1.SelectedRows[0].DataBoundItem as Inmobiliaria;
                modificar.Nombre = textBoxNombre.Text;
                MInmobiliaria.Modificacion(modificar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EliminarInmobiliaria()
        {
            try
            {
                Inmobiliaria eliminar = dataGridView1.SelectedRows[0].DataBoundItem as Inmobiliaria;
                MInmobiliaria.Baja(eliminar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        private void MostrarInmobiliaria()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = MInmobiliaria.GetListInmobiliaria();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MostrarInmobiliariaInmuebles();
        }

        private void MostrarInmobiliariaInmuebles()
        {
            dataGridView2.DataSource = null;
            Inmobiliaria seleccionado = dataGridView1.SelectedRows[0].DataBoundItem as Inmobiliaria;
            dataGridView2.DataSource = MInmobiliaria.GetListInmobiliariaInmueble(seleccionado);
        }

        private void groupBox4_Paint(object sender, PaintEventArgs e)
        {
            GraficoDeTorta();
        }

        private void GraficoDeTorta()
        {
            Graphics Graph = groupBox4.CreateGraphics();
            //Graph.DrawLine();
            double desde = 0;
            double totalVendido = 0;
            foreach (Inmobiliaria i in MInmobiliaria.GetListInmobiliaria())
            {
                totalVendido += i.TotalRecaudado;
            }
            foreach (Inmobiliaria i in MInmobiliaria.GetListInmobiliaria())
            {
                if (i.TotalRecaudado != 0)
                {
                    double porcion = (i.TotalRecaudado / totalVendido) * 360;
                    Graph.FillPie(brush: new SolidBrush(Color.Red),
                                  x: 5, y: 5,
                                  width: 100, height: 100,
                                  startAngle: (float)desde, sweepAngle: (float)porcion);
                    desde += (float)porcion;
                }
            }
        }

        private void textBox_Id_Y_Direccion1_Load(object sender, EventArgs e)
        {

        }


    }
}
