using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U1_Ej_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Hispanohablante H = new Hispanohablante();
        Angloparlante A = new Angloparlante();

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += H.Despedir() + "\r\n";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += H.Saludar() + "\r\n";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox2.Text += A.Despedir() + "\r\n";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox2.Text += A.Saludar() + "\r\n";
        }
    }

    public abstract class Persona
    {
        public abstract string Despedir();
        public abstract string Saludar();
    }

    public class Hispanohablante : Persona
    {
        public override string Saludar()
        {
            return "¡Hola!";
        }

        public override string Despedir()
        {
            return "¡Adios!";
        }
    }

    public class Angloparlante : Persona
    {
        public override string Saludar()
        {
            return "¡Hello!";
        }

        public override string Despedir()
        {
            return "¡Goodbye!";
        }
    }
}
