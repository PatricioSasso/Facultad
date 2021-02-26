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

namespace _2A_POO_TP2_Sasso_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            U.EventoPromedio += CapturarEvento; // Suscribir evento.
        }

        Universidad U = new Universidad();

        public void CapturarEvento(object o, EventArgs a)
        {
            MessageBox.Show("Evento Promedio: " + a.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            U.AgregarAlumno();
            CargarDataGrid1();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            U.ModificarAlumno(int.Parse(Interaction.InputBox("Ingrese el legajo del alumno que desea modificar")));
            CargarDataGrid1();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            U.EliminarAlumno(int.Parse(Interaction.InputBox("Ingrese el legajo del alumno que desea eliminar")));
            CargarDataGrid1();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            int Legajo = int.Parse(Interaction.InputBox("Ingrese el legajo del alumno al que desea agregar una materia"));
            string Tipo = "Especializada";
            U.Alumnos.Find(a => a.Legajo == Legajo).AgregarMateria(Tipo);
            CargarDataGrid1();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            int Legajo = int.Parse(Interaction.InputBox("Ingrese el legajo del alumno al que desea eliminar una materia"));
            int Codigo = int.Parse(Interaction.InputBox("Ingrese el código de la materia que desea eliminar"));
            string Tipo = "Especializada";
            U.Alumnos.Find(a => a.Legajo == Legajo).EliminarMateria(Codigo,Tipo);
            CargarDataGrid1();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            int Legajo = int.Parse(Interaction.InputBox("Ingrese el legajo del alumno al que desea modificar una materia"));
            int Codigo = int.Parse(Interaction.InputBox("Ingrese el código de la materia que desea modificar"));
            string Tipo = "Especializada";
            U.Alumnos.Find(a => a.Legajo == Legajo).ModificarMateria(Codigo,Tipo);
            CargarDataGrid1();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            int Legajo = int.Parse(Interaction.InputBox("Ingrese el legajo del alumno al que desea agregar una materia"));
            string Tipo = "Basica";
            U.Alumnos.Find(a => a.Legajo == Legajo).AgregarMateria(Tipo);
            CargarDataGrid1();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            int Legajo = int.Parse(Interaction.InputBox("Ingrese el legajo del alumno al que desea eliminar una materia"));
            int Codigo = int.Parse(Interaction.InputBox("Ingrese el código de la materia que desea eliminar"));
            string Tipo = "Basica";
            U.Alumnos.Find(a => a.Legajo == Legajo).EliminarMateria(Codigo, Tipo);
            CargarDataGrid1();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            int Legajo = int.Parse(Interaction.InputBox("Ingrese el legajo del alumno al que desea modificar una materia"));
            int Codigo = int.Parse(Interaction.InputBox("Ingrese el código de la materia que desea modificar"));
            string Tipo = "Basica";
            U.Alumnos.Find(a => a.Legajo == Legajo).ModificarMateria(Codigo, Tipo);
            CargarDataGrid1();
        }

        private void CargarDataGrid1()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = U.Alumnos;
            CargarDataGrid2Y3Y4();
        }

        int EA = 0;

        private void CargarDataGrid2Y3Y4()
        {
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
            dataGridView4.Rows.Clear();
            textBox1.Clear();
            textBox2.Clear();
            string LegajoAlumnoSeleccionado = dataGridView1.SelectedCells[0].Value.ToString();
            Alumno AlumnoSeleccionado = U.Alumnos.Find(a => a.Legajo == int.Parse(LegajoAlumnoSeleccionado));
            int PromA = 0;
            int Prom = 0;
            int A = 0;
            for (int i = 0; i < AlumnoSeleccionado.Especializadas.Count ; i++)
            {
                if(AlumnoSeleccionado.Especializadas[i].Estado == "Aprobado")
                {
                    dataGridView3.Rows.Add(AlumnoSeleccionado.Especializadas[i].Nombre);
                    if(AlumnoSeleccionado.Especializadas[i].Nota >= 6 && AlumnoSeleccionado.Especializadas[i].Nota <= 9)
                    {
                        AlumnoSeleccionado.Especializadas[i].Nota++;
                    }
                    PromA += AlumnoSeleccionado.Especializadas[i].Nota;
                    A++;
                }
                else if(AlumnoSeleccionado.Especializadas[i].Estado == "Desaprobado")
                {
                    dataGridView4.Rows.Add(AlumnoSeleccionado.Especializadas[i].Nombre);
                    Prom += AlumnoSeleccionado.Especializadas[i].Nota;
                }
                else
                {
                    dataGridView2.Rows.Add(AlumnoSeleccionado.Especializadas[i].Nombre);
                    EA++;
                    if (EA < 1)
                    {
                        AlumnoSeleccionado.Especializadas.Remove(AlumnoSeleccionado.Especializadas[i]);
                        EA--;
                        MessageBox.Show("No pueden cursarse 2 materias especiales a la vez.");
                    }
                }
            }
            for (int i = 0; i < AlumnoSeleccionado.Basicas.Count; i++)
            {
                if (AlumnoSeleccionado.Basicas[i].Estado == "Aprobado")
                {
                    dataGridView3.Rows.Add(AlumnoSeleccionado.Basicas[i].Nombre);
                    PromA += AlumnoSeleccionado.Basicas[i].Nota;
                    A++;
                }
                else if (AlumnoSeleccionado.Basicas[i].Estado == "Desaprobado")
                {
                    dataGridView4.Rows.Add(AlumnoSeleccionado.Basicas[i].Nombre);
                    Prom += AlumnoSeleccionado.Basicas[i].Nota;
                }
                else
                {
                    dataGridView2.Rows.Add(AlumnoSeleccionado.Basicas[i].Nombre);
                }
            }
            if(AlumnoSeleccionado.Basicas.Count > 0 || AlumnoSeleccionado.Especializadas.Count > 0)
            {
                textBox1.Text = ((Prom + PromA) / (AlumnoSeleccionado.Basicas.Count + AlumnoSeleccionado.Especializadas.Count)).ToString();
                if(A > 0)
                {
                    textBox2.Text = (PromA / A).ToString();
                }
                U.Evento_Promedio(int.Parse(textBox1.Text));
            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            U.OrdenarAscendentemente();
            CargarDataGrid1();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            U.OrdenarDescendentemente();
            CargarDataGrid1();
        }
    }
}
