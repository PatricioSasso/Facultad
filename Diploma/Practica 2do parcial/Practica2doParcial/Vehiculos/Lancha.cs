using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo
{
    public class Lancha : ICloneable
    {
        string marca;
        int eslora;
        string motor;

        public Lancha()
        {
            Marca = "MarcaDeLancha";
            Eslora = 20;
            Motor = "MotordeLancha";
        }

        public Lancha(string marca, int eslora, string motor)
        {
            Marca = marca;
            Eslora = eslora;
            Motor = motor;
        }

        public string Marca { get => marca; set => marca = value; }
        public int Eslora { get => eslora; set => eslora = value; }
        public string Motor { get => motor; set => motor = value; }

        public object Clone()
        {
            return (Lancha)this.MemberwiseClone();
        }
    }
}
