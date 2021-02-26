using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_5_Facultad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UAI.PromedioMayorOIguala9 += Mensaje_Evento;
        }

        public void Mensaje_Evento(object sender, EventArgs e)
        {
            MessageBox.Show("¡El promedio del alumno es mayor o igual a 9!");
        }

        Facultad UAI = new Facultad();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region ABM Alumno

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int legajo = int.Parse(textBox1.Text);
                string nombre = textBox2.Text;
                string apellido = textBox3.Text;
                UAI.AltaAlumno(legajo, nombre, apellido);
                CargarData1();
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
                UAI.ModificarAlumno(legajo, nuevoNombre, nuevoApellido);
                CargarData1();
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
                UAI.BajaAlumno(legajo);
                CargarData1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region ABM Basica y Especializada

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(textBox4.Text);
                string nombre = textBox5.Text;
                string tipo = comboBox1.Text;
                if (tipo == "Especializada")
                {
                    UAI.AltaEspecializada(codigo, nombre);
                }
                else if (tipo == "Basica")
                {
                    UAI.AltaBasica(codigo, nombre);
                }
                else
                {
                    throw new Exception("No ha seleccionado ningún tipo");
                }
                CargarData2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(textBox4.Text);
                string nuevoNombre = textBox5.Text;
                string tipo = comboBox1.Text;
                if (tipo == "Especializada")
                {
                    UAI.ModificarEspecializada(codigo, nuevoNombre);
                }
                else if (tipo == "Basica")
                {
                    UAI.ModificarBasica(codigo, nuevoNombre);
                }
                else
                {
                    throw new Exception("No ha seleccionado ningún tipo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            CargarData2();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(textBox4.Text);
                string tipo = comboBox1.Text;
                if (tipo == "Especializada")
                {
                    UAI.BajaEspecializada(codigo);
                }
                else if (tipo == "Basica")
                {
                    UAI.BajaBasica(codigo);
                }
                else
                {
                    throw new Exception("No ha seleccionado ningún tipo");
                }
                CargarData2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        private void Button7_Click(object sender, EventArgs e)
        {
            try
            {
                int legajo = int.Parse(textBox6.Text);
                int codigo = int.Parse(textBox7.Text);
                int nota = int.Parse(textBox8.Text);
                if (nota < 0 || nota > 10) { throw new Exception("La nota debe estar entre 1 y 10"); }
                string tipo = comboBox3.Text;
                Alumno elegido = UAI.Alumnos.Find(a => a.Legajo == legajo);
                if(elegido == null) { throw new Exception("El legajo elegido no pertenece a ningún alumno."); }
                if (tipo == "Especializada")
                {
                    Especializada materia = elegido.A_especializadas.Find(m => m.Codigo == codigo);
                    materia.ModificarNota(nota);
                }
                else if (tipo == "Basica")
                {
                    Basica materia = elegido.A_basicas.Find(m => m.Codigo == codigo);
                    materia.ModificarNota(nota);
                }
                else
                {
                    throw new Exception("No seleccionó ningún tipo.");
                }
                CargarData3y4y5yTextBox11y13();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region Agregar y Sacar Notas

        private void Button8_Click(object sender, EventArgs e)
        {
            try
            {
                int legajo = int.Parse(textBox9.Text);
                int codigo = int.Parse(textBox10.Text);
                string tipo = comboBox2.Text;
                Alumno agregara = UAI.Alumnos.Find(a => a.Legajo == legajo);
                if(agregara == null) { throw new Exception("El legajo ingresado no pertenece a ningún alumno."); }
                if (tipo == "Especializada")
                {
                    Especializada materia = UAI.Especializadas.Find(m => m.Codigo == codigo);
                    agregara.AgregarMateria(materia.Codigo, materia.Nombre, "Especializada");
                }
                else if (tipo == "Basica")
                {
                    Basica materia = UAI.Basicas.Find(m => m.Codigo == codigo);
                    agregara.AgregarMateria(materia.Codigo, materia.Nombre, "Basica");
                }
                else
                {
                    throw new Exception("No seleccionó ningún tipo.");
                }
                CargarData1();
                CargarData3y4y5yTextBox11y13();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            try
            {
                int legajo = int.Parse(textBox9.Text);
                int codigo = int.Parse(textBox10.Text);
                string tipo = comboBox2.Text;
                Alumno sacara = UAI.Alumnos.Find(a => a.Legajo == legajo);
                if (sacara == null) { throw new Exception("El legajo ingresado no pertenece a ningún alumno."); }
                if (tipo == "Especializada")
                {
                    Especializada materia = UAI.Especializadas.Find(m => m.Codigo == codigo);
                    sacara.SacarMateria(materia.Codigo, "Especializada");
                }
                else if (tipo == "Basica")
                {
                    Basica materia = UAI.Basicas.Find(m => m.Codigo == codigo);
                    sacara.SacarMateria(materia.Codigo, "Basica");
                }
                else
                {
                    throw new Exception("No seleccionó ningún tipo.");
                }
                CargarData1();
                CargarData3y4y5yTextBox11y13();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Ordenar por Apellido con IComparer (Ascendente y Descendente)

        private void Button10_Click(object sender, EventArgs e)
        {
            UAI.Alumnos.Sort(new OrdenarAscendente());
            CargarData1();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            UAI.Alumnos.Sort(new OrdenarDescendente());
            CargarData1();
        }

        #endregion

        #region CargarDataGrids

        public void CargarData1()
        {
            dataGridView1.Rows.Clear();
            foreach(var a in UAI.Alumnos)
            {
                dataGridView1.Rows.Add(a.Legajo, a.Nombre, a.Apellido);
            }
        }

        public void CargarData2()
        {
            dataGridView2.Rows.Clear();
            foreach (var m in UAI.Basicas)
            {
                dataGridView2.Rows.Add(m.Codigo, m.Nombre,"Basica");
            }
            foreach (var m in UAI.Especializadas)
            {
                dataGridView2.Rows.Add(m.Codigo, m.Nombre, "Especializada");
            }
        }

        public void CargarData3y4y5yTextBox11y13()
        {
            textBox11.Text = "";
            textBox13.Text = "";
            dataGridView3.Rows.Clear();
            dataGridView4.Rows.Clear();
            dataGridView5.Rows.Clear();
            int legajoSeleccionado = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            Alumno seleccionado = UAI.Alumnos.Find(a => a.Legajo == legajoSeleccionado);
            decimal proma = 0;
            decimal promr = 0;
            int cantr = 0;
            int canta = 0;
            foreach (var m in seleccionado.A_especializadas)
            {
                if(m.Estado == "En curso")
                {
                    dataGridView3.Rows.Add(m.Codigo, m.Nombre, "Especializada");
                }
                else if(m.Estado == "Aprobado")
                {
                    dataGridView4.Rows.Add(m.Codigo, m.Nombre, "Especializada");
                    proma += m.Nota;
                    canta++;
                }
                else
                {
                    dataGridView5.Rows.Add(m.Codigo, m.Nombre, "Especializada");
                    promr += m.Nota;
                    cantr++;
                }
            }
            foreach (var m in seleccionado.A_basicas)
            {
                if (m.Estado == "En curso")
                {
                    dataGridView3.Rows.Add(m.Codigo, m.Nombre, "Basica");
                }
                else if (m.Estado == "Aprobado")
                {
                    dataGridView4.Rows.Add(m.Codigo, m.Nombre, "Basica");
                    proma += m.Nota;
                    canta++;
                }
                else
                {
                    dataGridView5.Rows.Add(m.Codigo, m.Nombre, "Basica");
                    promr += m.Nota;
                    cantr++;
                }
            }
            if(cantr != 0 || canta != 0)
            {
                textBox11.Text = ((promr + proma) / (cantr + canta)).ToString();
                if (decimal.Parse(textBox11.Text) >= 9) { UAI.LlamarEvento(); }
            }
            if(canta != 0)
            {
                textBox13.Text = ((proma) / canta).ToString();
            }
        }

        #endregion

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarData3y4y5yTextBox11y13();
        }

    }
}
