using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace TP1___EJ_2
{
    public partial class Form1 : Form
    {
        private Banco banco;
        private enum TiposDeDNI { libretaEnrolamiento, pasaporte, libretaVerde }

        public Form1()
        {
            InitializeComponent();
            banco = new Banco();
            AddEvents();
        }

        private void AddEvents()
        {
            banco.DepositoEvent += CapturarEventoDeposito;
            banco.ImporteEvent += CapturarEventoImporte;
        }
        private void CapturarEventoDeposito(object obj, EventArgs eventArgs)
        {
            MessageBox.Show("evento Deposito:  " + obj.ToString());
        }
        private void CapturarEventoImporte(object obj, EventArgs eventArgs)
        {
            MessageBox.Show("evento Importe:  " + obj.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            banco.AñadirCuentaCorriente(double.Parse(Interaction.InputBox("Ingrese el monto al descubierto de la cuenta")),
                                        double.Parse(Interaction.InputBox("Ingrese el saldo de la cuenta")),
                                        int.Parse(Interaction.InputBox("Ingrese el id de la cuenta")));
            ActualizarCuentaGrid();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            banco.ModificarCuentaCorriente(int.Parse(Interaction.InputBox("Ingrese el id de la cuenta que desea modificar")),
                                           double.Parse(Interaction.InputBox("Ingrese el monto al descubierto de la cuenta")),
                                           double.Parse(Interaction.InputBox("Ingrese el saldo de la cuenta")),
                                           int.Parse(Interaction.InputBox("Ingrese el id de la cuenta")));
            ActualizarCuentaGrid();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            banco.EliminarCuentaCorriente(int.Parse(Interaction.InputBox("Ingrese el id de la cuenta que desea eliminar")));
            ActualizarCuentaGrid();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            banco.AñadirCajaAhorro(double.Parse(Interaction.InputBox("Ingrese el saldo de la cuenta")),
                                   int.Parse(Interaction.InputBox("Ingrese el id de la cuenta")));
            ActualizarCuentaGrid();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            banco.ModificarCajaAhorro(int.Parse(Interaction.InputBox("Ingrese el id de la cuenta que desea modificar")),
                                   double.Parse(Interaction.InputBox("Ingrese el saldo de la cuenta")),
                                   int.Parse(Interaction.InputBox("Ingrese el id de la cuenta")));
            ActualizarCuentaGrid();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            banco.EliminarCajaAhorro(int.Parse(Interaction.InputBox("Ingrese el id de la cuenta que desea eliminar")));
            ActualizarCuentaGrid();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            banco.TransferirCuentaCorriente(int.Parse(Interaction.InputBox("Ingrese el id de la cuenta")),
                                               double.Parse(Interaction.InputBox("Ingrese el valor a transferir")),
                                               int.Parse(Interaction.InputBox("Ingrese el id de la cuenta a la que desea transferir")));
            ActualizarCuentaGrid();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            banco.TransfererirCajaAhorro(int.Parse(Interaction.InputBox("Ingrese el id de la cuenta")),
                                          double.Parse(Interaction.InputBox("Ingrese el valor a transferir")),
                                          int.Parse(Interaction.InputBox("Ingrese el id de la cuenta a la que desea transferir")));
            ActualizarCuentaGrid();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            banco.Depositar(int.Parse(Interaction.InputBox("Ingrese el id de la cuenta")),
                            double.Parse(Interaction.InputBox("Ingrese el valor a depositar")));
            ActualizarCuentaGrid();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            bool resultado = banco.ExtraerCuentaCorriente(int.Parse(Interaction.InputBox("Ingrese el id de la cuenta")),
                                         double.Parse(Interaction.InputBox("Ingrese el valor a extraer")));
            try
            {
                if (resultado)
                {
                    ActualizarCuentaGrid();
                }
                else
                {
                    throw new ExcepcionExtraccion();
                }
            }
            catch (ExcepcionExtraccion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            bool resultado = banco.ExtraerCajaAhorro(int.Parse(Interaction.InputBox("Ingrese el id de la cuenta")),
                                                     double.Parse(Interaction.InputBox("Ingrese el valor a extraer")));
            try
            {
                if (resultado)
                {
                    ActualizarCuentaGrid();
                }
                else
                {
                    throw new ExcepcionExtraccion();
                }
            }
            catch (ExcepcionExtraccion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            banco.Añadir_Titular_Cuenta(int.Parse(Interaction.InputBox("Ingrese el dni del titular")),
                                        int.Parse(Interaction.InputBox("Ingrese el id de la cuenta")));
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            banco.Eliminar_Titular_Cuenta(int.Parse(Interaction.InputBox("Ingrese el dni del titular")),
                                          int.Parse(Interaction.InputBox("Ingrese el id de la cuenta")));
        }

        private void ActualizarCuentaGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = banco.ObtenerCuenta();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            dataGridView2.DataSource = banco.ObtenerTitularesDeCuentas(rowindex);
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            banco.AñadirTitularr(Interaction.InputBox("Ingrese el nombre del titular"),
                                 Interaction.InputBox("Ingrese el apellido del titular"),
                                 double.Parse(Interaction.InputBox("Ingrese el dni del titular")),
                                 Interaction.InputBox("Ingrese el tipo de dni del titular"));
            ActualizarTitularGrid();
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            banco.ModificarTitular(double.Parse(Interaction.InputBox("Ingrese el dni del titular que desee modificar")),
                                   Interaction.InputBox("Ingrese el nombre del titular"),
                                   Interaction.InputBox("Ingrese el apellido del titular"),
                                   double.Parse(Interaction.InputBox("Ingrese el dni del titular")),
                                   Interaction.InputBox("Ingrese el tipo de dni del titular"));
            ActualizarTitularGrid();
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            banco.EliminarTitular(double.Parse(Interaction.InputBox("Ingrese el dni del titular que desea eliminar")));
            ActualizarTitularGrid();
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            banco.Añadir_Titular_Cuenta(int.Parse(Interaction.InputBox("Ingrese el dni del titular")),
                                        int.Parse(Interaction.InputBox("Ingrese el id de la cuenta")));
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            banco.Eliminar_Titular_Cuenta(int.Parse(Interaction.InputBox("Ingrese el dni del titular")),
                                          int.Parse(Interaction.InputBox("Ingrese el id de la cuenta")));
        }

        private void ActualizarTitularGrid()
        {
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = banco.ObtenerTitular();
        }

        private void DataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dataGridView3.CurrentCell.RowIndex;
            dataGridView4.DataSource = banco.ObtenerCuentasDeTitulares(rowindex);
        }

        class ExcepcionExtraccion : Exception
        {
            public override string Message => "ha ocurrido un error al hacer la Extraccion";
        }

        private void DataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
