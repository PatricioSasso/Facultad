using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Entity;
using ORM;
using System.Windows.Forms;

namespace BLL
{
    public class Bpersona : Iabmc<Epersona>
    {
        Opersona PersonaO;
        public Bpersona() { PersonaO = new Opersona(); }
        public void Alta(Epersona pObject)
        {
            try
            {
                PersonaO.Alta(pObject);
            }
            catch (Exception ex) {  MessageBox.Show(ex.Message); }
        }

        public void Baja(Epersona pObject)
        {
            throw new NotImplementedException();
        }

        public void Consulta(Epersona pObject)
        {
            throw new NotImplementedException();
        }

        public List<Epersona> ConsultaDesdeHasta(Epersona pObject1, Epersona pObject2)
        {
            throw new NotImplementedException();
        }

        public List<Epersona> ConsultaTodos()
        {
            List<Epersona> L = null;
            try
            {
              L= PersonaO.ConsultaTodos();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return L;
        }

        public void Modificacion(Epersona pObject)
        {
            throw new NotImplementedException();
        }
    }
}
