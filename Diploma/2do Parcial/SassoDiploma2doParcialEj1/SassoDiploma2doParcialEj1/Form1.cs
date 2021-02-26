using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SassoDiploma2doParcialEj1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Curso curso;

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Alumno> alumnos = new List<Alumno>()
            {
                new Alumno("201356-22", "Patricio", "Sasso"),
                new Alumno("201236-22", "A", "Sasso"),
                new Alumno("206356-22", "B", "Sasso"),
                new Alumno("131358-22", "C", "Sasso"),
                new Alumno("201229-22", "D", "Sasso"),
                new Alumno("983812-22", "E", "Sasso"),
                new Alumno("943853-22", "F", "Sasso"),
                new Alumno("123743-22", "G", "Sasso"),
                new Alumno("583453-22", "H", "Sasso"),
                new Alumno("102384-22", "I", "Sasso"),
                new Alumno("245824-22", "J", "Sasso"),
                new Alumno("328489-22", "K", "Sasso"),
                new Alumno("312893-22", "L", "Sasso"),
                new Alumno("948372-22", "M", "Sasso"),
                new Alumno("884382-22", "N", "Sasso"),
                new Alumno("478238-22", "O", "Sasso"),
                new Alumno("842384-22", "P", "Sasso"),
                new Alumno("993828-22", "Q", "Sasso"),
                new Alumno("842387-22", "R", "Sasso"),
                new Alumno("204656-22", "S", "Sasso"),
            };
            curso = new Curso(alumnos,"3ero A");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = curso.Alumnos;
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            curso.GuardarEnDiscoXML();
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            curso.GuardarEnDiscoJSON();
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            Alumno agregar = new Alumno();
            agregar.Legajo = Interaction.InputBox("Ingrese el legajo del alumno");
            agregar.Nombre = Interaction.InputBox("Ingrese el nombre del alumno");
            agregar.Apellido = Interaction.InputBox("Ingrese el apellido del alumno");
            curso.Agregar(agregar);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = curso.Alumnos;
        }
    }
}
