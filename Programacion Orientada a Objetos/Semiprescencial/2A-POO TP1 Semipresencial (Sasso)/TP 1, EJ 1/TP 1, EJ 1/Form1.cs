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

namespace TP_1__EJ_1_Sasso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Alumnos> LA = new List<Alumnos>();
        int l = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                l++;
                int Legajo = l;
                string Nombre = Interaction.InputBox("Ingrese el nombre del alumno");
                string Apellido = Interaction.InputBox("Ingrese el apellido del alumno");
                DateTime Nacimiento = DateTime.Parse(Interaction.InputBox("Ingrese la fecha de nacimiento del alumno"));
                DateTime Ingreso = DateTime.Parse(Interaction.InputBox("Ingrese la fecha de ingreso del alumno"));
                if (Ingreso < Nacimiento) { throw new Exception("La edad de nacimiento no puede ser "); }
                int Edad = int.Parse(Interaction.InputBox("Ingrese la Edad del alumno"));
                if (Edad < 0) { throw new Exception("La edad no puede ser menor a 0"); }
                bool Activo = bool.Parse(Interaction.InputBox("Ingrese true si el alumno está activo y false si está inactivo"));
                int Aprobadas = int.Parse(Interaction.InputBox("Ingrese la cantidad de materias aprobadas del alumno"));
                if (Aprobadas > 36) { throw new Exception("Las materias aprobadas no pueden ser más que 36"); }
                if (Aprobadas < 0) { throw new Exception("Las materias aprobadas no pueden ser menores a 0"); }
                LA.Add(new Alumnos(Legajo, Nombre, Apellido, Nacimiento, Ingreso, Edad, Activo, Aprobadas));
                Cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                List<Alumnos> Temp = new List<Alumnos>();
                int Eliminar = int.Parse(Interaction.InputBox("Ingrese el número de legajo del alumno que desea modificar"));
                foreach (Alumnos A in LA)
                {
                    if (A.A_Legajo != Eliminar)
                    {
                        Temp.Add(A);
                    }
                    else
                    {
                        int Legajo = A.A_Legajo;
                        string Nombre = Interaction.InputBox("Ingrese el nuevo nombre del alumno");
                        string Apellido = Interaction.InputBox("Ingrese el nuevo apellido del alumno");
                        DateTime Nacimiento = DateTime.Parse(Interaction.InputBox("Ingrese la nueva fecha de nacimiento del alumno"));
                        DateTime Ingreso = DateTime.Parse(Interaction.InputBox("Ingrese la nueva fecha de ingreso del alumno"));
                        if (Ingreso < Nacimiento) { throw new Exception("La edad de nacimiento no puede ser "); }
                        int Edad = int.Parse(Interaction.InputBox("Ingrese la nueva Edad del alumno"));
                        if (Edad < 0) { throw new Exception("La edad no puede ser menor a 0"); }
                        bool Activo = bool.Parse(Interaction.InputBox("Ingrese true si el alumno está activo y false si está inactivo"));
                        int Aprobadas = int.Parse(Interaction.InputBox("Ingrese la nueva cantidad de materias aprobadas del alumno"));
                        if (Aprobadas > 36) { throw new Exception("Las materias aprobadas no pueden ser más que 36"); }
                        if (Aprobadas < 0) { throw new Exception("Las materias aprobadas no pueden ser menores a 0"); }
                        Temp.Add(new Alumnos(Legajo, Nombre, Apellido, Nacimiento, Ingreso, Edad, Activo, Aprobadas));
                    }
                }
                LA.Clear();
                foreach (Alumnos A in Temp)
                {
                    LA.Add(A);
                }
                Cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Cargar()
        {
            dataGridView1.Rows.Clear();
            Mostrar();
        }

        public void Mostrar()
        {
            foreach (Alumnos A in LA)
            {
                dataGridView1.Rows.Add(A.A_Legajo , A.A_Nombre , A.A_Apellido , A.A_Fecha_Nacimiento , A.A_Fecha_Ingreso , A.A_Edad, A.A_Activo , A.A_Cant_Materias_Aprobadas);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                List<Alumnos> Temp = new List<Alumnos>();
                int Eliminar = int.Parse(Interaction.InputBox("Ingrese el número de legajo del alumno que desea eliminar"));
                foreach (Alumnos A in LA)
                {
                   if (A.A_Legajo != Eliminar)
                   {
                        Temp.Add(A);
                   }
                }
                LA.Clear();
                foreach (Alumnos A in Temp)
                {
                    LA.Add(A);
                }
                Cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            Alumnos mostrar = LA[index];
            textBox1.Text = mostrar.Antiguedad(int.Parse(Interaction.InputBox("1 = Antigüedad en días \n2 = Antigüedad en meses \n3 antigüedad en años"))).ToString();
            textBox2.Text = mostrar.Materias_No_Aprobadas().ToString();
            textBox3.Text = mostrar.Edad_De_Ingreso().ToString();
        }
    }

    public class Alumnos
    {
        public Alumnos()
        {
            A_Legajo = 0;
            A_Nombre = "Default";
            A_Apellido = "Default";
            A_Fecha_Nacimiento = new DateTime(1,1,1);
            A_Fecha_Ingreso = new DateTime(1, 1, 1);
            A_Edad = 0;
            A_Activo = false;
            A_Cant_Materias_Aprobadas = 0;
        }

        public Alumnos(int Legajo, string Nombre, string Apellido, DateTime Fecha_Nacimiento, DateTime Fecha_Ingreso, int Edad , bool Activo, int Cant_Materias_Aprobadas)
        {
            A_Legajo = Legajo;
            A_Nombre = Nombre;
            A_Apellido = Apellido;
            A_Fecha_Nacimiento = Fecha_Nacimiento;
            A_Fecha_Ingreso = Fecha_Ingreso;
            A_Edad = Edad;
            A_Activo = Activo;
            A_Cant_Materias_Aprobadas = Cant_Materias_Aprobadas; 
        }

        public int A_Legajo { get; set; }
        public string A_Nombre { get; set; }
        public string A_Apellido { get; set; }
        public DateTime A_Fecha_Nacimiento { get; }
        public DateTime A_Fecha_Ingreso { get; }
        public int A_Edad { get; }
        public bool A_Activo { get; set; }
        public int A_Cant_Materias_Aprobadas { get; }

        public int Antiguedad(int n1)
        {
            int dias = (DateTime.Now - A_Fecha_Ingreso).Days;
            if (n1 == 1)
            {
                return dias;
            }
            else if (n1 == 2)
            {
                return dias / 30;
            }
            else if (n1 == 3)
            {
                return dias / 365;
            }
            else
            {
                return 0;
            }
        }

        public int Materias_No_Aprobadas()
        {
            return  36 - A_Cant_Materias_Aprobadas;
        }

        public int Edad_De_Ingreso()
        {
            int Edad_Ingreso = (A_Fecha_Ingreso - A_Fecha_Nacimiento).Days / 365;
            return Edad_Ingreso;
        }
    }
}
