using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatronComposite1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.DisplayMember = "Nombre";
        }

        private void btn_CrearCaja_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(new Composite(txt_Caja.Text));
        }

        private void btn_AgregarProducto_Click(object sender, EventArgs e)
        {
            if (listBox1.Items != null && listBox1.SelectedItem == null)
            {
                listBox1.SelectedItem = listBox1.Items[0];
            }
            ((Composite)listBox1.SelectedItem).agregar(new Producto(txt_Producto.Text, int.Parse(txt_Precio.Text)));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.Items != null && listBox1.SelectedItem == null)
            {
                listBox1.SelectedItem = listBox1.Items[0];
            }
            txt_main.Text = ((Composite)listBox1.SelectedItem).mostrar();
            txt_main.Text += "Total : " + ((Composite)listBox1.SelectedItem).getCosto().ToString();
        }
    }

    public abstract class Componente
    {
        string nombre;

        public Componente(string nombre)
        {
            Nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }

        public abstract int getCosto();
        public abstract string mostrar();
        public virtual void agregar(Componente add) { }
        public virtual void sacar(Componente remove) { }
    }

    public class Composite : Componente
    {
        List<Componente> componentes;

        public Composite(string nombre) : base(nombre)
        {
            componentes = new List<Componente>();
        }

        public override void agregar(Componente add)
        {
            componentes.Add(add);
        }

        public override void sacar(Componente remove)
        {
            componentes.Remove(remove);
        }

        public override int getCosto()
        {
            int total = 0;
            foreach (var c in componentes)
            {
                total += c.getCosto();
            }
            return total;
        }

        public override string mostrar()
        {
            string text = "";
            foreach (var c in componentes)
            {
                text += c.mostrar();
            }
            return text;
        }
    }

    public class Producto : Componente
    {
        int costo;

        public Producto(string nombre, int costo) : base(nombre)
        {
            this.Costo = costo;
        }
        
        public int Costo { get => costo; set => costo = value; }

        public override int getCosto()
        {
            return Costo;
        }

        public override string mostrar()
        {
            return Nombre + " $" + costo.ToString() + Environment.NewLine;
        }
    }
}
