using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_Ej2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}

	public class Libro
	{
		private string autor;
        private string nombre;
        private string descripcion;
		private int paginas = 200;
        private int edicion;

		public string Autor { get => autor; }
		public string Nombre { set => nombre = value; }
		public string Descripcion { get => descripcion; set => descripcion = value; }
		public int Paginas { set => paginas = value; }
        public int Edicion { get => edicion; set => edicion = value; }

        public int Editar(int edi)
		{
			this.edicion = edi;
			return edicion;
		}
	}
}
