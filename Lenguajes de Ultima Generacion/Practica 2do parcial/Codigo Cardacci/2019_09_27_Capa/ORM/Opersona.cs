using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Entity;
using System.Windows.Forms;
using System.Data;
using DAL;





namespace ORM
{
    public class Opersona : Iabmc<Epersona>
    {
        DALServicio DS;
        public Opersona() { DS = new DALServicio(); }
        
        public void Alta(Epersona pObject)
        {
            try
            {
                DataTable DT = DS.RetornaDataTableVacio("Persona");
                object[] O = { pObject.id, pObject.Nombre, pObject.Apellido };
                DT.Rows.Add(O);
                DS.Guardar(DT);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
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
            List<Epersona> L = new List<Epersona>();
            try
            {
               
                DataTable DT= DS.Leer("Select * from Persona");
                foreach (DataRow R in DT.Rows)
                {
                    L.Add(new Epersona((int)R[0], R[1].ToString(), R[2] as string));
                }

            
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
