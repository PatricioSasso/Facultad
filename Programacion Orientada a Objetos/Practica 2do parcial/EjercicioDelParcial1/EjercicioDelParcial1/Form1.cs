using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioDelParcial1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Comun.EventoDespachar += MensajeEvento;
        }

        public void MensajeEvento(object sender, EventoDespachar e)
        {
            MessageBox.Show("Un cliente Común no puede despachar más de 3 contenedores.\r\nInformación sobre el contenedor:\r\n" + e.Mensaje());
        }

        Empresa E = new Empresa();

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView3.Columns[4].Width = 300;
        }

        #region ABM Contenedores
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textBox1.Text.ToUpper();
                ComprobarFormato(id);
                string descripcion = textBox2.Text;
                DateTime fecha = DateTime.Parse(textBox3.Text);
                decimal peso = decimal.Parse(textBox4.Text);
                E.AltaContenedor(id, descripcion, fecha, peso);
                CargarD1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textBox1.Text;
                string descripcion = textBox2.Text;
                DateTime fecha = DateTime.Parse(textBox3.Text);
                decimal peso = decimal.Parse(textBox4.Text);
                E.ModificarContenedor(id, descripcion, fecha, peso);
                CargarD1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textBox1.Text;
                E.EliminarContenedor(id);
                CargarD1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region ABM Clientes
        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                string legajo = textBox5.Text;
                string nombre = textBox6.Text;
                string apellido = textBox7.Text;
                int tipo;
                if(radioButton1.Checked == false)
                {
                    tipo = 1;
                }
                else
                {
                    tipo = 0;
                }
                E.AltaCliente(legajo, nombre, apellido, tipo);
                CargarD2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                string legajo = textBox5.Text;
                string nombre = textBox6.Text;
                string apellido = textBox7.Text;
                E.ModificarCliente(legajo, nombre, apellido);
                CargarD2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                string legajo = textBox5.Text;
                E.EliminarCliente(legajo);
                CargarD2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        public void CargarD1()
        {
            dataGridView1.Rows.Clear();
            foreach (var c in E.Contenedores)
            {
                dataGridView1.Rows.Add(c.Id, c.Descripcion, c.Fecha, c.Peso);
            }
        }

        public void CargarD2()
        {
            dataGridView2.Rows.Clear();
            foreach (var c in E.Clientes)
            {
                if(c is Comun p)
                {
                    dataGridView2.Rows.Add(c.Legajo, c.Nombre, c.Apellido, "Común");
                }
                else
                {
                    dataGridView2.Rows.Add(c.Legajo, c.Nombre, c.Apellido, "Especial");
                }
                
            }
        }

        public void CargarD3()
        {
            string legajo = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            Cliente seleccionado = E.Clientes.Find(c => c.Legajo == legajo);
            if (seleccionado != null)
            {
                dataGridView3.Rows.Clear();
                foreach (var c in seleccionado.Cliente_contenedores)
                {
                    dataGridView3.Rows.Add(c.Id, c.Descripcion, c.Fecha, c.Peso, "Legajo: " + seleccionado.Legajo + " Nombre: " + seleccionado.Nombre + " Apellido: " + seleccionado.Apellido);
                }
            }
        }

        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarD3();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            string legajo = textBox8.Text;
            string Id = textBox9.Text;
            Cliente cliente = E.Clientes.Find(c => c.Legajo == legajo);
            Contenedor contenedor = E.Contenedores.Find(c => c.Id == Id);
            if( cliente != null && contenedor != null)
            {
                cliente.Despachar(contenedor);
                CargarD3();
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            E.OrdenarApellidosAsc();
            CargarD2();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            E.OrdenarApellidosDesc();
            CargarD2();
        }

        public void ComprobarFormato(string id)
        {
            if(id.Length != 8){ throw new Exception("El formato es incorrecto, debe ser por ejemplo : 111-AAAA."); }
            char[] letras = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'Ñ', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] numeros = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            foreach (var l in letras)
            {
                if (id[0] == l) { throw new Exception("El formato es incorrecto, debe ser por ejemplo : 111-AAAA."); }
                if (id[1] == l) { throw new Exception("El formato es incorrecto, debe ser por ejemplo : 111-AAAA."); }
                if (id[2] == l) { throw new Exception("El formato es incorrecto, debe ser por ejemplo : 111-AAAA."); }
            }
            if (id[3] != '-') { throw new Exception("El formato es incorrecto, debe ser por ejemplo : 111-AAAA."); }
            foreach (var n in numeros)
            {
                if (id[4] == n) { throw new Exception("El formato es incorrecto, debe ser por ejemplo : 111-AAAA."); }
                if (id[5] == n) { throw new Exception("El formato es incorrecto, debe ser por ejemplo : 111-AAAA."); }
                if (id[6] == n) { throw new Exception("El formato es incorrecto, debe ser por ejemplo : 111-AAAA."); }
                if (id[7] == n) { throw new Exception("El formato es incorrecto, debe ser por ejemplo : 111-AAAA."); }
            }
        }
    }
}
