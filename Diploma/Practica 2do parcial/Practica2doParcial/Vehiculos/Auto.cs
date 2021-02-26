using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo
{
    public class Auto : ICloneable
    {
        string patente;
        string marca;
        string modelo;

        public Auto()
        {
            Patente = "KHE-999";
            Marca = "Fiat?";
            Modelo = "NiIdea";
        }

        public Auto(string patente, string marca, string modelo)
        {
            Patente = patente;
            Marca = marca;
            Modelo = modelo;
        }

        public string Patente { get => patente; set => patente = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }

        public object Clone()
        {
            return (Auto)this.MemberwiseClone();
        }
    }
}
