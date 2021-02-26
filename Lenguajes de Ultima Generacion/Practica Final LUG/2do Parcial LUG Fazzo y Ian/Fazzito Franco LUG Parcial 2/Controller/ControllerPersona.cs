using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Interfaces;
using Negocio;
using Entidades;

namespace Controller
{
    public class ControllerPersona : IABMC
    {
        
        private Form formPersona;
        private gestorPersona gestorPersona;

        public ControllerPersona(Form form)
        {
            this.formPersona = form;
            this.gestorPersona = new gestorPersona();
        }

        public void Alta()
        {
            Persona persona = new Persona();

            TextBox textboxId = this.formPersona.Controls[NombresForm.ID] as TextBox;
            TextBox textboxNombre = this.formPersona.Controls[NombresForm.NOMBRE] as TextBox;
            TextBox textboxApellido = this.formPersona.Controls[NombresForm.APELLIDO] as TextBox;
            DateTime Nacimiento = DateTime.Parse(this.formPersona.Controls[NombresForm.NACIMIENTO].Text);

            persona.Id = getId(textboxId);
            persona.Nombre = textboxNombre.Text;
            persona.Apellido = textboxApellido.Text;
            persona.FechaNacimiento = Nacimiento;

            gestorPersona.Alta(persona);
        }

        private int getId(TextBox txt)
        {
            int value;
            if (int.TryParse(txt.Text,out value))
            {
                return value;
            }
            else
            {
                throw new Exception("invalido");
            }
        }

        public void Modificacion()
        {
            DataGridView dgv = this.formPersona.Controls[NombresForm.DGV_PERSONA] as DataGridView;
            VistaPersona personaVista = dgv.SelectedRows[0].DataBoundItem as VistaPersona;
            Persona persona = personaVista.getPersona();

            TextBox textboxNombre = this.formPersona.Controls[NombresForm.NOMBRE] as TextBox;
            TextBox textboxApellido = this.formPersona.Controls[NombresForm.APELLIDO] as TextBox;
            DateTime Nacimiento = DateTime.Parse(this.formPersona.Controls[NombresForm.NACIMIENTO].Text);

            persona.Nombre = textboxNombre.Text;
            persona.Apellido = textboxApellido.Text;
            persona.FechaNacimiento = Nacimiento;

            gestorPersona.Modificacion(persona);         
        }

        public void LimpiarDGVIncremental()
        {
            DataGridView dgv = this.formPersona.Controls[NombresForm.DGV_PERSONA_INCREMENTAL] as DataGridView;
            dgv.DataSource = null;
            dgv.Rows.Clear();
        }

        public void sortDes()
        {
            List<Persona> personas = gestorPersona.Consultar();
            List<VistaPersona> vista = new List<VistaPersona>();
            foreach (var p in personas)
            {
                vista.Add(new VistaPersona(p));
            }
            List<VistaPersona> vistaSort = vista.OrderByDescending(v => v.edad).ToList();
            DataGridView dgv = this.formPersona.Controls[NombresForm.DGV_PERSONA] as DataGridView;
            dgv.DataSource = null;
            dgv.DataSource = vistaSort;
        }

        public void dibujarBarras()
        {
            List<Persona> personas = gestorPersona.Consultar();
            if (personas.Count() > 0)
            {
                List<VistaPersona> listadoVista = new List<VistaPersona>();

                foreach (var p in personas)
                {
                    listadoVista.Add(new VistaPersona(p));
                }

                List<int> datos = new List<int>();

                int edadMinTarget = 0;
                int edadMaxTarget = 10;

                for (int i = 0; i < 10; i++)
                {
                    int count = listadoVista.Count(v => v.edad > edadMinTarget && v.edad < edadMaxTarget);
                    datos.Add(count);

                    edadMinTarget += 10;
                    edadMaxTarget += 10;
                }
                int X = 15;
                int altoRec = 265;
                Graphics g = this.formPersona.CreateGraphics();
                g.Clear(Color.LightGray);
                Rectangle rec = new Rectangle(new Point(X, 346), new Size(975, altoRec));
                g.DrawRectangle(new Pen(Brushes.Black, 3), rec);


                int x = 40;
                int max = datos.Max();
                foreach (int num in datos)
                {
                    int alto = num * 10 / max;
                    Rectangle recDato = new Rectangle(x, 500 + alto , 10, 10 * alto);
                    g.DrawRectangle(new Pen(Brushes.Black, 3), recDato);
                    g.FillRectangle(Brushes.Red, recDato);
                    x += 100;
                }
                g.Dispose();
            }
            else
            {
                Graphics g = this.formPersona.CreateGraphics();
                g.Clear(Color.LightGray);
            }
        }

        public void sort()
        {
            List<Persona> personas = gestorPersona.Consultar();
            List<VistaPersona> vista = new List<VistaPersona>();
            foreach (var p in personas)
            {
                vista.Add(new VistaPersona(p));
            }
            List<VistaPersona> vistaSort = vista.OrderBy(v => v.edad).ToList();
            DataGridView dgv = this.formPersona.Controls[NombresForm.DGV_PERSONA] as DataGridView;
            dgv.DataSource = null;
            dgv.DataSource = vistaSort;
        }

        public void CargaGrid()
        {
            DataGridView dgv = this.formPersona.Controls[NombresForm.DGV_PERSONA] as DataGridView;
            VistaPersona personaVista = dgv.SelectedRows[0].DataBoundItem as VistaPersona;
            Persona persona = personaVista.getPersona();

            this.formPersona.Controls[NombresForm.ID].Text = persona.Id.ToString();
            this.formPersona.Controls[NombresForm.NOMBRE].Text = persona.Nombre;
            this.formPersona.Controls[NombresForm.APELLIDO].Text = persona.Apellido;
            this.formPersona.Controls[NombresForm.NACIMIENTO].Text = $"{persona.FechaNacimiento.Day}-{persona.FechaNacimiento.Month}-{persona.FechaNacimiento.Year}";
        }

        public void Baja()
        {
            DataGridView dgv = this.formPersona.Controls[NombresForm.DGV_PERSONA] as DataGridView;
            VistaPersona personaVista = dgv.SelectedRows[0].DataBoundItem as VistaPersona;
            gestorPersona.Baja(personaVista.getPersona());
        }

        public void Consultar()
        {
            List<Persona> personas = gestorPersona.Consultar();
            List<VistaPersona> vista = new List<VistaPersona>();
            foreach (var p in personas)
            {
                vista.Add(new VistaPersona(p));
            }
            DataGridView dgv = this.formPersona.Controls[NombresForm.DGV_PERSONA] as DataGridView;
            dgv.DataSource = null;
            dgv.DataSource = vista;
        }

        public void ConsultarFiltro()
        {
            TextBox textboxNombre = this.formPersona.Controls[NombresForm.INCREMENTAL] as TextBox;
            string filtro = textboxNombre.Text;
            List<Persona> personas = gestorPersona.ConsultarFiltro(filtro);
            List<VistaPersona> vista = new List<VistaPersona>();
            foreach (var p in personas)
            {
                vista.Add(new VistaPersona(p));
            }
            DataGridView dgv = this.formPersona.Controls[NombresForm.DGV_PERSONA_INCREMENTAL] as DataGridView;
            dgv.DataSource = null;
            dgv.DataSource = vista;
        }

    }

    public class VistaPersona
    {
        private Persona persona;

        public VistaPersona(Persona PersonaEntrada)
        {
            this.persona = new Persona(PersonaEntrada.Id, PersonaEntrada.Nombre, PersonaEntrada.Apellido, PersonaEntrada.FechaNacimiento);
        }

        public int id
        {
            get
            {
                return this.persona.Id;
            }
        }
        public string nombre
        {
            get
            {
                return this.persona.Nombre;
            }
        }
        public string apellido
        {
            get
            {
                return this.persona.Apellido;
            }
        }
        public int edad
        {
            get
            {
                return (DateTime.Now - persona.FechaNacimiento).Days / 365;
            }
        }
        public Persona getPersona()
        {
            return this.persona;
        }
    }

    public static class NombresForm
    {
        public const string ID = "txt_id";
        public const string NOMBRE = "txt_nombre";
        public const string APELLIDO = "txt_apellido";
        public const string NACIMIENTO = "controlNacimiento";
        public const string INCREMENTAL = "txt_incremental";
        public const string DGV_PERSONA = "dgv_persona";
        public const string DGV_PERSONA_INCREMENTAL = "dgv_persona_incremental";
    }
}
