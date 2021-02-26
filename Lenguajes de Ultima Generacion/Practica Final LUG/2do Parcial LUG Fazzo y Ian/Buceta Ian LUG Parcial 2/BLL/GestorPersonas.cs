using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Entities;
using ORMDAL;

namespace BLL
{
    public class GestorPersonas : IABMC<Persona>
    {
        List<Persona> Personas;
        ServicioORMDAL servicioOrmDal;
        public GestorPersonas()
        {
            Personas = new List<Persona>();
            servicioOrmDal = new ServicioORMDAL();
        }

        public void Alta(Persona objeto)
        {
            if (Personas.Count != 0)
            {
                objeto.SetId(Personas.Max(x => x.GetId()) + 1);
                
            }
            else
            {
                objeto.SetId(0);
            }
            servicioOrmDal.Alta(objeto);
        }

        public void Baja(Persona objeto)
        {
            servicioOrmDal.Baja(objeto);
        }

        public void Modificacion(Persona objeto)
        {
            servicioOrmDal.Modificacion(objeto);
        }

        public Persona Consulta(int idObjeto)
        {
            return servicioOrmDal.Consulta(idObjeto);
        }

        public List<Persona> ConsultaTodos()
        {
            Personas = servicioOrmDal.ConsultaTodos();
            return Personas;
        }

        public void Guardar()
        {
            servicioOrmDal.Guardar();
        }

        public List<Persona> Ordenar(bool tipoOrden)
        {
            if (tipoOrden == true)
            {
                Personas.Sort(new ComparadorAscendente());
            }
            else
            {
                Personas.Sort(new ComparadorDescendente());
            }
            return Personas;
        }

        public List<Persona> ConsultaFiltro(string filtro)
        {
            return servicioOrmDal.ConsultaFiltro(filtro);
        }
    }
    public class ComparadorAscendente : IComparer<Persona>
    {
        public int Compare(Persona x, Persona y)
        {
            if (x.Edad > y.Edad) return 1;
            if (x.Edad == y.Edad) return 0;
            else
            {
                return -1;
            }
        }
    }
    public class ComparadorDescendente : IComparer<Persona>
    {
        public int Compare(Persona x, Persona y)
        {
            if (x.Edad > y.Edad) return -1;
            if (x.Edad == y.Edad) return 0;
            else
            {
                return 1;
            }
        }
    }

}
