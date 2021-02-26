using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapper;
using Entidades;
using Interfaces;

namespace Negocio
{
    public class gestorPersona : IABMC_Generico<Persona>
    {
        private mapper mapper;

        public gestorPersona()
        {
            mapper = new mapper();
        }
        public void Alta(Persona value)
        {
            mapper.Alta(value);
        }

        public void Baja(Persona value)
        {
            mapper.Baja(value);
        }

        public List<Persona> Consultar()
        {
            return mapper.Consultar(); 
        }

        public List<Persona> ConsultarFiltro(string filtro)
        {
            return mapper.ConsultarFiltro(filtro);
        }

        public void Modificacion(Persona value)
        {
            mapper.Modificacion(value);
        }
    }
}
