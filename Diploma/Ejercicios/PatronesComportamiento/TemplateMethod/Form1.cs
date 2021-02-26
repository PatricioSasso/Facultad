using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateMethod
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
        List<Producto> mProductos = new List<Producto>();
		private void Form1_Load(object sender, EventArgs e)
		{
            grdProductos.Columns.Add("Codigo", "Código");
            grdProductos.Columns["Codigo"].DataPropertyName = "Codigo";
            grdProductos.Columns.Add("Nombre", "Nombre");
            grdProductos.Columns["Nombre"].DataPropertyName = "Nombre";
            grdProductos.Columns.Add("Precio", "Precio");
            grdProductos.Columns["Precio"].DataPropertyName = "Precio";
            grdProductos.Columns.Add("Peso", "Peso");
            grdProductos.Columns["Peso"].DataPropertyName = "Peso";
            grdProductos.AllowUserToAddRows = false;
            grdProductos.RowHeadersVisible = false;
            grdProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdProductos.EditMode = DataGridViewEditMode.EditProgrammatically;


            mProductos.Add(new Producto("A12", "Zapatillas", 1500, 2));
            mProductos.Add(new Producto("B26", "Bolso", 800, 1));
            mProductos.Add(new Producto("C14", "Bicicleta", 6800, 25));

            grdProductos.DataSource = mProductos;

            cmbFormaPago.Items.Add("Efectivo");
            cmbFormaPago.Items.Add("Crédito");
            cmbFormaPago.Items.Add("Débito");
            cmbFormaPago.SelectedIndex = 1;

        }

        private void ProcesarVenta(Template_Venta pventa)
		{
            pventa.Agregar(mProductos);
            if(cmbFormaPago.Text=="Efectivo")
			{
                txtTotal.Text = pventa.CerrarVenta(Template_Venta.FormasDePago.Efectivo).ToString();
			}
            else if (cmbFormaPago.Text == "Crédito")
            {
                txtTotal.Text = pventa.CerrarVenta(Template_Venta.FormasDePago.Credito).ToString();
            }
            else if (cmbFormaPago.Text == "Débito")
            {
                txtTotal.Text = pventa.CerrarVenta(Template_Venta.FormasDePago.Debito).ToString();
            }
        }

		private void btnMostrador_Click(object sender, EventArgs e)
		{
            ProcesarVenta(new Implementation_Mostrador());
		}

		private void btnEnvio_Click(object sender, EventArgs e)
		{
            ProcesarVenta(new Implementation_VentaEnvio());
		}
	}
}
