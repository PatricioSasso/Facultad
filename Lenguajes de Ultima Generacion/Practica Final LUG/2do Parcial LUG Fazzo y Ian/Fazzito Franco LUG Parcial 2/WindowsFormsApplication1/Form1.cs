using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private ControllerPersona controlador;
        public Form1()
        {
            InitializeComponent();
            controlador = new ControllerPersona(this);
            controlador.Consultar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (controlNacimiento.IsValido)
                {
                    controlador.Alta();
                    controlador.Consultar();
                }
                else
                {
                    MessageBox.Show("Error Formato");
                }
            }
            catch 
            {
                MessageBox.Show("ERROR INPUT");
            }            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_baja_Click(object sender, EventArgs e)
        {
            try
            {
                controlador.Baja();
                controlador.Consultar();
            }
            catch
            {
                MessageBox.Show("ERROR INPUT");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (controlNacimiento.IsValido)
                {
                    controlador.Modificacion();
                    controlador.Consultar();
                }
                else
                {
                    MessageBox.Show("Error Formato");
                }
            }
            catch
            {
                MessageBox.Show("ERROR INPUT");
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txt_incremental.Text)) // REVISAR    
            {
                controlador.ConsultarFiltro();
            }
            else
            {
                controlador.LimpiarDGVIncremental();
            }
        }

        private void dgv_persona_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            controlador.CargaGrid();
        }

        private void dgv_persona_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            controlador.CargaGrid();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            controlador.sort();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            controlador.sortDes();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            controlador.dibujarBarras();
        }
    }
}
