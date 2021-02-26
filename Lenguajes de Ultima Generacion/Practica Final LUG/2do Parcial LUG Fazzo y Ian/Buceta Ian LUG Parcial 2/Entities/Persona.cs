using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Persona
    {
        public Persona(string Nombre, string Apellido, DateTime FechaDeNacimiento)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.FechaDeNacimiento = FechaDeNacimiento;
        }
        public Persona(int Id, string Nombre, string Apellido, DateTime FechaDeNacimiento)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.FechaDeNacimiento = FechaDeNacimiento;
        }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public byte Edad
        {
            get
            {
                return Convert.ToByte((DateTime.Now - FechaDeNacimiento.Date).Days/365);
            }
        }
        DateTime FechaDeNacimiento { get; set; }
        int Id { get; set; }
        public void SetId(int value)
        {
            Id = value;
        }
        public int GetId()
        {
            return this.Id;
        }
        public DateTime GetFechaDeNacimiento()
        {
            return FechaDeNacimiento;
        }
        public void SetFechaDeNacimiento(DateTime value)
        {
            FechaDeNacimiento = value;
        }
        public override string ToString()
        {
            return $"Nombre: {this.Nombre}\nApellido: {this.Apellido}\nFecha De Nacimiento: {this.FechaDeNacimiento}\nEdad: {this.Edad}";
        }
    }
}
