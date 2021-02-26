using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Requerido_SE
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
		#region PROPIEDADES MATERIA
		public int CODIGOMATERIA { get => codigo; }
		public string NOMBREMATERIA { get => asignatura;}
		public int NOTAMATERIA { get => nota;}
		#endregion
		public void ModificarMateria(string nombre, int nota)
		{
			this.asignatura = nombre;
			if(nota <11 && nota>0)
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
		public MateriaEspecial(int codigo, string asignatura) : base(codigo, asignatura)
		{
			notamxima = 0;
			virtud = 0;
		}
		private int notamxima;
		private int virtud;

		public void AsignarNota (int nota)
		{
			if(this.NOTAMATERIA >=6 && this.NOTAMATERIA <=9)
			{
				virtud++;
			}
			else if(this.NOTAMATERIA==10)
			{
				notamxima = 10;
			}
		}
	}	
}
