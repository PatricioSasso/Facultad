using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;
using Interfaces;

namespace Controler
{
    public class ControlerForm1 : Iabmc

    {
        Form Vformulario;
        Bpersona PersonaB;

        public ControlerForm1(Form pFormulario) { Vformulario = pFormulario; PersonaB = new Bpersona(); }

        public void Alta()
        {
            try
            {
                Epersona PersonaE = new Epersona(int.Parse(Vformulario.Controls["textBox1"].Text), Vformulario.Controls["textBox2"].Text, Vformulario.Controls["textBox3"].Text);
                PersonaB.Alta(PersonaE);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            
        }

        public void Baja()
        {
            throw new NotImplementedException();
        }

        public void Consulta()
        {
            throw new NotImplementedException();
        }

        public void ConsultaDesdeHasta()
        {
            throw new NotImplementedException();
        }

        public void ConsultaTodos()
        {
            try
            {
                (Vformulario.Controls["dataGridView1"] as DataGridView).DataSource = null;
                (Vformulario.Controls["dataGridView1"] as DataGridView).DataSource = PersonaB.ConsultaTodos();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void Modificacion()
        {
            throw new NotImplementedException();
        }
    }
}
