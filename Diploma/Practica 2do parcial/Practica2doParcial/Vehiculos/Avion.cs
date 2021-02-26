using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo
{
    public class Avion : ICloneable
    {
        string matricula;
        int autonomia;
        int cantidadPasajeros;

        public Avion()
        {
            Matricula = "MatriculaAvioncito";
            Autonomia = 50;
            CantidadPasajeros = 15;
        }

        public Avion(string matricula, int autonomia, int cantidadPasajeros)
        {
            Matricula = matricula;
            Autonomia = autonomia;
            CantidadPasajeros = cantidadPasajeros;
        }

        public string Matricula { get => matricula; set => matricula = value; }
        public int Autonomia { get => autonomia; set => autonomia = value; }
        public int CantidadPasajeros { get => cantidadPasajeros; set => cantidadPasajeros = value; }

        public object Clone()
        {
            return (Avion)this.MemberwiseClone();
        }
    }
}
