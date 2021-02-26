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

namespace ejer14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Lista L = new Lista();
        int size = 1;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cant = int.Parse(Interaction.InputBox("Ingese la cantidad de tareas"));
            int nro = size;
            L.agregaralprincipio(nro,cant);
            Mostrar(L);
            size++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int pos = int.Parse(Interaction.InputBox("Escriba el Id que desea quitar")) - 1;
            L.sacarenn(pos);
            Mostrar(L);
            size--;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            L.buscarnodo(L.MenosTareas(L, size)).cant++;
            Mostrar(L);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            L.buscarnodo(L.MasTareas(L, size)).cant--;
            Mostrar(L);
        }

        private void Mostrar(Lista L)
        {
            listBox1.Items.Clear();
            L.ordenar(L);
            int[] vl = new int[size];
            int[] vl2 = new int[size];
            for (int i = 0; i < L.size ; i++)
            {
                vl[i] = L.buscarnodo(i).nro;
                vl2[i] = L.buscarnodo(i).cant;
                listBox1.Items.Add("Id: " + vl[i] + "   " + " Tareas: " + vl2[i]);
            }
        }
    }
}
