using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;



namespace _2019_09_20_Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Persona P ;
        MapperPersona MP ;
        private void Form1_Load(object sender, EventArgs e)
        {
            P = new Persona();
            MP = new MapperPersona();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            P.Nombre = textBox1.Text;
            MP.Guardar(P);
        }
    }
}
