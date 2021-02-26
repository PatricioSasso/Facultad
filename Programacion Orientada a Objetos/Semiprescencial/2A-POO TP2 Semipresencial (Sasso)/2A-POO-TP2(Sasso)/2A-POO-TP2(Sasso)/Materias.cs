using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _2A_POO_TP2_Sasso_
{
    abstract class Materia
    {
        private int codigo;
        private string nombre;
        private int nota;
        private string estado;

        public int Codigo { get => codigo; }
        public string Nombre { get => nombre; }
        public int Nota { get => nota; set => nota = value; }
        public string Estado { get => estado; set => estado = value; }

        public Materia(int Codigo, string Nombre, int Nota)
        {
            this.codigo = Codigo;
            this.nombre = Nombre;
            this.nota = Nota;
        }

        public void Modificar(int NuevoCodigo, string NuevoNombre, int NuevaNota)
        {
            this.codigo = NuevoCodigo;
            this.nombre = NuevoNombre;
            this.nota = NuevaNota;
            this.estado = SacarEstado();
        }

        abstract public string SacarEstado();
    }

    class Basicas : Materia
    {
        public Basicas(int Codigo, string Nombre, int Nota) : base(Codigo, Nombre, Nota)
        {
            this.Estado = this.SacarEstado();
        }

        public override string SacarEstado()
        {
            if (Nota >= 4 && Nota <= 10)
            {
                return "Aprobado";
            }
            else if (Nota < 4 && Nota > 0)
            {
                return "Desaprobado";
            }
            else
            {
                return "En curso";
            }
        }
    }

    class Especializadas : Materia
    {
        public Especializadas(int Codigo, string Nombre, int Nota) : base(Codigo, Nombre, Nota)
        {
            this.Estado = this.SacarEstado();
        }

        public override string SacarEstado()
        {
            int NotaConPlus = Nota + 1;
            if(Nota == 0)
            {
                return "En curso";
            }
            else if (NotaConPlus >= 4 && NotaConPlus <= 10)
            {
                return "Aprobado";
            }
            else if (NotaConPlus >= 6 && NotaConPlus <= 9)
            {
                Nota++;
                return "Aprobado";
            }
            else if (NotaConPlus + 1 < 4 && NotaConPlus + 1 > 0)
            {
                return "Desaprobado";
            }
            else
            {
                return null;
            }
        }
    }
}
