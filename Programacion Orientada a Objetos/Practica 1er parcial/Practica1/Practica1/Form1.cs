using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UAI.Promedio10 += Promedio10_Mensaje;
        }

        private void Promedio10_Mensaje(object sender, EventArgs e)
        {
            MessageBox.Show("Evento: ¡El alumno tiene un promedio de 10!");
        }

        Universidad UAI = new Universidad();

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        #region ABM Alumnos

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int legajo = int.Parse(textBox1.Text);
                string nombre = textBox2.Text;
                string apellido = textBox3.Text;
                decimal promedio = decimal.Parse(textBox4.Text);
                if (legajo < 1)
                { throw new LegajoMenorQue1Exception(); }
                if (promedio < 1 || promedio > 10)
                { throw new PromedioMenorQue1oMayorQue10Exception(); }
                UAI.InscribirAlumno(legajo, nombre, apellido, promedio);
                CargarYMostrar();
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
                int legajo = int.Parse(textBox1.Text);
                string nuevoNombre = textBox2.Text;
                string nuevoApellido = textBox3.Text;
                decimal nuevoPromedio = decimal.Parse(textBox4.Text);
                if (legajo < 1)
                { throw new Exception("El legajo no puede ser 0 o menor"); }
                if (nuevoPromedio < 1 || nuevoPromedio > 10)
                { throw new Exception("El promedio debe valer entre 1 y 10"); }
                UAI.ModificarAlumno(legajo, nuevoNombre, nuevoApellido, nuevoPromedio);
                CargarYMostrar();
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
                int legajo = int.Parse(textBox1.Text);
                if (legajo < 1)
                { throw new Exception("El legajo no puede ser 0 o menor"); }
                UAI.DesinscribirAlumno(legajo);
                CargarYMostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
        
        public void CargarYMostrar()
        {
            dataGridView1.Rows.Clear();
            foreach(Alumno A in UAI.Alumnos)
            {
                dataGridView1.Rows.Add(A.Legajo, A.Nombre, A.Apellido, A.Promedio);
            }
        }

        #region Ordenar con IComparer

        private void Button4_Click(object sender, EventArgs e)
        {
            UAI.OrdenarAscPorApellido();
            CargarYMostrar();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            UAI.OrdenarPorDescApellido();
            CargarYMostrar();
        }

        #endregion

        private void Button6_Click(object sender, EventArgs e)
        {
            
        }
    }

    public class LegajoMenorQue1Exception : Exception
    {
        public override string Message => "El legajo no puede ser menor que 1";
    }

    public class PromedioMenorQue1oMayorQue10Exception : Exception
    {
        public override string Message => "El promedio no puede ser menor que 1 o mayor que 10";
    }
}
