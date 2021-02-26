using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_5_Facultad
{
    public abstract class Materia
    {
        private int codigo;
        private string nombre;
        private int nota;
        private string estado;

        public Materia(int codigo, string nombre)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.nota = 0;
            this.estado = "En curso";
        }

        public int Codigo { get => codigo; }
        public string Nombre { get => nombre; }
        public int Nota { get => nota ; set => nota = value; }
        public string Estado { get => estado; set => estado = value; }

        public void Modificar(string nuevoNombre)
        {
            this.nombre = nuevoNombre;
        }

        public void ModificarHerencia(int nota, string estado)
        {
            this.nota = nota;
            this.estado = estado;
        }

        public abstract void ModificarNota(int nota);
    }

    public class Basica : Materia
    {
        public Basica(int codigo, string nombre) : base(codigo, nombre)
        {
        }

        public override void ModificarNota(int nota)
        {
            if(nota > 0 && nota < 4)
            {
                ModificarHerencia(nota, "Desaprobado");
            }
            else
            {
                ModificarHerencia(nota, "Aprobado");
            }
        }

    }

    public class Especializada : Materia
    {
        public Especializada(int codigo, string nombre) : base(codigo, nombre)
        {
        }

        public override void ModificarNota(int nota)
        {
            if (nota > 0 && nota < 4)
            {
                ModificarHerencia(nota, "Desaprobado");
                
            }
            else if(nota > 5 && nota < 10)
            {
                ModificarHerencia(nota + 1, "Aprobado");
            }
            else
            {
                ModificarHerencia(nota, "Aprobado");
            }
        }

    }
}
