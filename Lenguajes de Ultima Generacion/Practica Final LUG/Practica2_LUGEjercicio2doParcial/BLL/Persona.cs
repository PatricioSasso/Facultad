using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Persona
    {
        int id;
        string nombre;
        string apellido;
        DateTime fechaNacimiento;

        public Persona(int id, string nombre, string apellido, DateTime fechaNacimiento)
        {
            this.Id = id;
            this.Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            this.Apellido = apellido ?? throw new ArgumentNullException(nameof(apellido));
            this.FechaNacimiento = fechaNacimiento;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }

        public int GetEdad()
        {
            return (DateTime.Now - FechaNacimiento).Days / 365;
        }
    }

    public class VistaPersona
    {
        int id;
        string nombre;
        string apellido;
        int edad;
        Persona persona;

        public VistaPersona(Persona persona)
        {
            Id = persona.Id;
            Nombre = persona.Nombre ?? throw new ArgumentNullException(nameof(nombre));
            Apellido = persona.Apellido ?? throw new ArgumentNullException(nameof(apellido));
            Edad = persona.GetEdad();
            this.persona = persona;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }

        public Persona GetPersona()
        {
            return persona;
        }
    }
}
