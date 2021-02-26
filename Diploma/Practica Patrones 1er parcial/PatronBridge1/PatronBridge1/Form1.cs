using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatronBridge1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(new LaNonna(new Artesanal()));
            comboBox1.Items.Add(new Romario(new Industrial()));
            comboBox1.DisplayMember = "nombre";
            comboBox1.SelectedItem = comboBox1.Items[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = ((IPizzeria)comboBox1.SelectedItem).ServirPizza();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = ((IPizzeria)comboBox1.SelectedItem).EntregarPizza();
        }
    }

    public interface IPizzeria
    {
        IPizzero pizzero { get; set; }
        string nombre { get; set; }

        string EntregarPizza();
        string ServirPizza();
    }

    public class LaNonna : IPizzeria
    {
        public LaNonna(IPizzero pizzero)
        {
            this.pizzero = pizzero;
            this.nombre = "La Nonna";
        }

        public IPizzero pizzero { get; set; }
        public string nombre { get; set; }

        public string EntregarPizza()
        {
            return "No se hace delivery";
        }

        public string ServirPizza()
        {
            return pizzero.PrepararPizza() + pizzero.CocinarPizza() + " Servido en mesa";
        }
    }

    public class Romario : IPizzeria
    {
        public Romario(IPizzero pizzero)
        {
            this.pizzero = pizzero;
            this.nombre = "Romario";
        }

        public IPizzero pizzero { get; set; }
        public string nombre { get; set; }

        public string EntregarPizza()
        {
            return pizzero.PrepararPizza() + pizzero.CocinarPizza() + " Entregado por delivery";
        }

        public string ServirPizza()
        {
            return pizzero.PrepararPizza() + pizzero.CocinarPizza() + " Servido en mesa";
        }
    }

    public interface IPizzero
    {
        string PrepararPizza();
        string CocinarPizza();
    }

    public class Artesanal : IPizzero
    {
        public string CocinarPizza()
        {
            return "Colocar pizza en el horno a 180 grados por 20 minutos" + Environment.NewLine +
                   "Desmoldar pizza cocinar" + Environment.NewLine;
        }

        public string PrepararPizza()
        {
            return "Amasar harina + agua + levadura + sal" + Environment.NewLine +
                   "Dejar levar masa" + Environment.NewLine +
                   "Estirar masa en pizzera" + Environment.NewLine +
                   "Pintar con salsa" + Environment.NewLine +
                   "Cortar 400 gr de muzzarella en dados" + Environment.NewLine +
                   "Esparcir muzzarella" + Environment.NewLine +
                   "Condimentar y colocar aceitunas" + Environment.NewLine;
        }
    }

    public class Industrial : IPizzero
    {
        public string CocinarPizza()
        {
            return "Colocar pizza en el horno indistrial a 230 grados por 10 minutos" + Environment.NewLine +
                   "Desmoldar pizza cocinada" + Environment.NewLine;
        }

        public string PrepararPizza()
        {
            return "Tomar prepizza de la cámara de frío" + Environment.NewLine +
                   "Tomar porción de muzzarella trozada de envases de cámara" + Environment.NewLine +
                   "Esparcir trozos de muzzarella en prepizza" + Environment.NewLine +
                   "Condimentar y colocar aceitunas" + Environment.NewLine;
        }
    }
}
