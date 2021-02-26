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
        int edad;

        public Persona(int id, string nombre, string apellido, DateTime fechaNacimiento)
        {
            Id = id;
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            Apellido = apellido ?? throw new ArgumentNullException(nameof(apellido));
            FechaNacimiento = fechaNacimiento;
            edad = CalcularEdad();
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Edad { get => edad; set => edad = value; }

        public int CalcularEdad()
        {
            return (DateTime.Now - fechaNacimiento).Days / 365;
        }
    }

    public class VistaPersona
    {
        int id;
        string nombre;
        string apellido;
        int edad;
        Persona persona;

        public VistaPersona(int id, string nombre, string apellido, int edad, Persona persona)
        {
            Id = id;
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            Apellido = apellido ?? throw new ArgumentNullException(nameof(apellido));
            Edad = edad;
            this.persona = persona;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }

        public DateTime GetFechaNacimiento()
        {
            return persona.FechaNacimiento;
        }
    }
}
