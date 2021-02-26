using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U1_Ej1
{
	public abstract class Materia
	{
		private int codigo;
		private string asignatura;
		private int nota;

		public Materia(int codigo, string asignatura)
		{
			this.codigo = codigo;
			this.asignatura = asignatura;
			this.nota = 0;
		}

		public int Codigo { get => codigo; }
		public string Nombre { get => asignatura; }
		public int Nota { get => nota; }

		public void ModificarMateria(string nombre, int nota)
		{
			this.asignatura = nombre;
			if (nota < 11 && nota > 0)
			{
				this.nota = nota;
			}
			else
			{
				System.Windows.Forms.MessageBox.Show("La nota es incorrecta");
			}
		}

		public override string ToString() => codigo.ToString() + "," + asignatura + ".";
	}

	class MateriaBasica : Materia
	{
		public MateriaBasica(int codigo, string asignatura) : base(codigo, asignatura)
		{

		}
	}

	class MateriaEspecial : Materia
	{
        private int notaMaxima;
        private int virtud;

        public MateriaEspecial(int codigo, string asignatura) : base(codigo, asignatura)
		{
			notaMaxima = 0;
			virtud = 0;
		}

		public void AsignarNota(int nota)
		{
			if (this.Nota >= 6 && this.Nota <= 9)
			{
				virtud++;
			}
			else if (this.Nota == 10)
			{
				notaMaxima = 10;
			}
		}
	}
}
