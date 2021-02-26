using System;
using System.Windows.Forms;

namespace Practica_4_Medicamentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Hospital H = new Hospital();

        private void Form1_Load(object sender, EventArgs e)
        {
            H.Evento += Mensaje_Evento;
        }

        public void Mensaje_Evento(object sender, EventoMedicamentoEntregadoAnteriormente e )
        {
            MessageBox.Show("Se han realizado " + e.EntregasPrevias + " entregas.");
        }

        #region ABM Paciente

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int dni = int.Parse(textBox1.Text);
                string apellido = textBox2.Text;
                string nombre = textBox3.Text;
                H.AltaPaciente(dni,apellido,nombre);
                MostrarYCargarData1();
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
                int dni = int.Parse(textBox1.Text);
                if (textBox1.Text.Length - 1 == 8) { throw new Exception("El dni debe tener 8 dígitos numéricos"); }
                string nuevoApellido = textBox2.Text;
                string nuevoNombre = textBox3.Text;
                H.ModificarPaciente(dni, nuevoApellido, nuevoNombre);
                MostrarYCargarData1();
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
                int dni = int.Parse(textBox1.Text);
                if (textBox1.Text.Length - 1 == 8) { throw new Exception("El dni debe tener 8 dígitos numéricos"); }
                H.BajaPaciente(dni);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MostrarYCargarData1();
        }

        #endregion

        #region ABM Medicamento

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(textBox4.Text);
                int lote = int.Parse(textBox5.Text);
                string descripcion = textBox6.Text;
                DateTime vencimiento = DateTime.Parse(textBox7.Text);
                if(vencimiento.CompareTo(DateTime.Now) == -1) { throw new Exception("El medicamento está vencido"); }
                int cantidad = int.Parse(textBox8.Text);
                if(cantidad < 0) { throw new Exception("La cantidad no puede ser negativa"); }
                H.AltaMedicamento(codigo,lote,descripcion,vencimiento,cantidad);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MostrarYCargarData2();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(textBox4.Text);
                int nuevoLote = int.Parse(textBox5.Text);
                string nuevaDescripcion = textBox6.Text;
                DateTime nuevoVencimiento = DateTime.Parse(textBox7.Text);
                if (nuevoVencimiento.CompareTo(DateTime.Now) == -1) { throw new Exception("El medicamento está vencido"); }
                int nuevaCantidad = int.Parse(textBox8.Text);
                if (nuevaCantidad < 0) { throw new Exception("La cantidad no puede ser negativa"); }
                H.ModificarMedicamento(codigo, nuevoLote, nuevaDescripcion, nuevoVencimiento, nuevaCantidad);
                MostrarYCargarData2();
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
                int codigo = int.Parse(textBox4.Text);
                H.BajaMedicamento(codigo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MostrarYCargarData2();
        }

        #endregion

        public void MostrarYCargarData1()
        {
            dataGridView1.Rows.Clear();
            foreach (var p in H.Pacientes)
            {
                dataGridView1.Rows.Add(p.Dni, p.Apellido, p.Nombre);
            }
        }

        public void MostrarYCargarData2()
        {
            dataGridView2.Rows.Clear();
            foreach (var m in H.Medicamentos)
            {
                dataGridView2.Rows.Add(m.Codigo, m.Lote, m.Descripcion, m.Vencimiento, m.Cantidad);
            }
        }

        public void MostrarYCargarData3()
        {
            try
            {
                int codigoSeleccionado = int.Parse(dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
                int i = -1;
                dataGridView3.Rows.Clear();
                foreach (var p in H.Pacientes)
                {
                    i++;
                    foreach (var m in H.Pacientes[i].P_medicamentos)
                    {
                        if (m.Codigo == codigoSeleccionado)
                        {
                            dataGridView3.Rows.Add(p.Dni, p.Apellido, p.Nombre);
                        }
                    }
                }
            }
            catch (Exception)
            {

            }

        }

        public void MostrarYCargarData4(int codigo,int cantidad)
        {
            int i = -1;
            dataGridView4.Rows.Clear();
            foreach (var p in H.Pacientes)
            {
                i++;
                foreach (var m in H.Pacientes[i].P_medicamentos)
                {
                    if (m.Codigo == codigo)
                    {
                        dataGridView4.Rows.Add(p.Dni, p.Apellido, p.Nombre, codigo, m.Cantidad);
                    }
                }
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(textBox9.Text);
            int dni = int.Parse(textBox10.Text);
            int cantidad = int.Parse(textBox11.Text);
            if (cantidad < 0) { throw new Exception("La cantidad no puede ser negativa"); }
            H.EntregarMedicamento(codigo, dni, cantidad);
            MostrarYCargarData2();
            MostrarYCargarData3();
            MostrarYCargarData4(codigo, cantidad);
        }

        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MostrarYCargarData3();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
