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

namespace U1_Ej2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		Banco BancoX = new Banco();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
		{
			int idInicial = int.Parse(Interaction.InputBox("Ingrese el id inicial"));
			int idFinal = int.Parse(Interaction.InputBox("Ingrese el id final"));
			int valor = int.Parse(Interaction.InputBox("Ingrese el importe"));
			BancoX.Transferencia(idInicial,valor,idFinal);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int id = int.Parse(Interaction.InputBox("Ingrese el id "));
			BancoX.Extraer(id);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int id = int.Parse(Interaction.InputBox("Ingrese el id "));
			BancoX.Depositar(id);
		}
    }

    public class Cuenta
	{
		private decimal saldo;
		private int id;

		public int Id { get => id; set => id = value; }
		public decimal Saldo { get => saldo; set => saldo = value; }

		protected Cuenta()
		{

		}

		protected Cuenta(decimal saldocuenta, int numerocuenta)
		{
			this.saldo = saldocuenta;
			this.id = numerocuenta;
		}

		#region METODOS

		public void Depositar(decimal valor)
		{
			this.saldo += valor;
		}

		public bool Extraccion(decimal valor)
		{
			if (valor <= saldo)

			{
				saldo -= valor;
				return true;
			}
			else
			{
				return false;
			}
		}

		#endregion

	}

	public class Banco
	{
		List<Cuenta> cuentas = new List<Cuenta>();

		private Cuenta BuscarCuenta(int id)
		{
			Cuenta buscar = cuentas.Find(buscador => buscador.Id == id);
			return buscar;
		}

		private bool ExisteCuenta(int id)
		{
			Cuenta existe = BuscarCuenta(id);
			if (existe != null)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public bool Transferencia(int idinicial, int valor, int idfinal)
		{
			if (ExisteCuenta(idinicial) && ExisteCuenta(idfinal))
			{
				Cuenta inicial = BuscarCuenta(idinicial);
				Cuenta final = BuscarCuenta(idfinal);
				bool resultado = inicial.Extraccion(valor);
				if (resultado)
				{
					if (valor > 1000)
					{
						string mensaje = string.Format("el ID de la cuenta de origen es " + idinicial);
					}
					final.Depositar(valor);
					return true;
				}
				else { return false; }
			}
			else { return false; }
		}

		public void Depositar(int id)
		{
			if(ExisteCuenta(id))
			{
				Cuenta depositar = BuscarCuenta(id);
				depositar.Depositar(int.Parse(Interaction.InputBox("Ingrese el importe")));
			}
		}

		public void Extraer(int id)
		{
			if(ExisteCuenta(id))
			{
				Cuenta extraer = BuscarCuenta(id);
				extraer.Extraccion(int.Parse(Interaction.InputBox("Ingrese el importe")));
			}
		}
	}
}
