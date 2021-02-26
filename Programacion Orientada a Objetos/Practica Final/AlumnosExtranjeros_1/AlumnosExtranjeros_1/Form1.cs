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

namespace AlumnosExtranjeros_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UAI.Evento += Mensaje;
        }

        public void Mensaje(object sender, EventoTelefonos e)
        {
            MessageBox.Show("No se puede agregar más de 1 teléfono, se intentó añadir:\r\n" +
                             "ID: " + e.Telefono.Id + " Número: " + e.Telefono.Numero);
        }

        Universidad UAI = new Universidad();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int identificador = int.Parse(Interaction.InputBox("Ingrese el identificador del alumno."));
            UAI.AltaAlumno(identificador, checkBox1.Checked);
            D1();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int identificador = int.Parse(Interaction.InputBox("Ingrese el identificador del alumno."));
            UAI.ModificacionAlumno(identificador);
            D1();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int identificador = int.Parse(Interaction.InputBox("Ingrese el identificador del alumno."));
            UAI.BajaAlumno(identificador);
            D1();
        }

        public void D1()
        {
            dataGridView1.Rows.Clear();
            foreach (var a in UAI.Alumnos)
            {
                dataGridView1.Rows.Add(a.Identificador, a.Nombre, a.Apellido);
            }
            D2();
            D3();
        }

        public void D2()
        {
            Alumno seleccionado = UAI.Alumnos.Find(a => a.Identificador == int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
            dataGridView2.Rows.Clear();
            if(seleccionado.Telefonos != null)
            {
                foreach (var t in seleccionado.Telefonos)
                {
                    dataGridView2.Rows.Add(t.Id, t.Numero);
                }
            }
        }

        public void D3()
        {
            List<Extranjero> Query = (from a in UAI.Alumnos where a is Extranjero select (Extranjero)a).ToList<Extranjero>();
            dataGridView3.Rows.Clear();
            foreach (var a in Query)
            {
                dataGridView3.Rows.Add(a.Identificador, a.Nombre, a.Apellido, a.U_Origen, a.E_MateriasAprobadas);
            }
        }


        private void Button4_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Interaction.InputBox("Ingrese el id del teléfono."));
            UAI.AltaTelefono(id);
            D4();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Interaction.InputBox("Ingrese el id del teléfono."));
            UAI.ModificarTelefono(id);
            D4();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Interaction.InputBox("Ingrese el id del teléfono."));
            UAI.BajaTelefono(id);
            D4();
        }

        public void D4()
        {
            dataGridView4.Rows.Clear();
            foreach (var t in UAI.Telefonos)
            {
                dataGridView4.Rows.Add(t.Id, t.Numero);
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            int identificador = int.Parse(Interaction.InputBox("Ingrese el identificador del alumno."));
            int id = int.Parse(Interaction.InputBox("Ingrese el id del teléfono."));
            UAI.AgregarTelefonoAAlumno(identificador, id);
            D1();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            UAI.OrdenarPorApellidoAsc();
            D1();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            UAI.OrdenarPorApellidoDesc();
            D1();
        }
    }
}
