using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumnosExtranjeros_1
{
    public class Telefono
    {
        int id;
        int numero;
        bool usado;

        public Telefono(int id, int numero, bool usado)
        {
            this.id = id;
            this.numero = numero;
            this.usado = usado;
        }

        public int Id { get => id; set => id = value; }
        public int Numero { get => numero; set => numero = value; }
        public bool Usado { get => usado; set => usado = value; }

        public void Modificar(int numero)
        {
            this.numero = numero;
        }

        public void EnUso()
        {
            this.usado = true;
        }
    }
}
