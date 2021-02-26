using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U1_Ej1
{
	class Alumno
	{
		private int legajo;
		private string nombre;
		private string apellido;
		private List<Materia> listadomaterias;

		public Alumno(int legajo, string nombre, string apellido)
		{
			this.legajo = legajo;
			this.nombre = nombre;
			this.apellido = apellido;
			this.listadomaterias = new List<Materia>();
		}

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Legajo { get => legajo; set => legajo = value; }

        public override string ToString() => legajo.ToString() + ", " + nombre + ", " + apellido + ".";

        public void ModificarAlumno(int legajo, string nombre, string apellido)
		{
			this.legajo = legajo;
			this.nombre = nombre;
			this.apellido = apellido;
		}

		#region AMB Materias

		public void AgregarMateria(Materia buscar)
		{
			if (listadomaterias.Contains(buscar))
			{
				MessageBox.Show("El alumno ya se registró a esta materia.");
			}
			else
			{
				bool NoAprobada = GetNoAprobada(buscar);
				bool NoEspecial = GetNoEspecial();
				bool Especial = GetEspecial(buscar);
				if (NoAprobada && NoEspecial)
				{
					listadomaterias.Add(buscar);
					MessageBox.Show("Materia dada de alta con éxito");
				}
				else if (NoAprobada && !Especial)
				{
					listadomaterias.Add(buscar);
					MessageBox.Show("Materia dada de alta con éxito");
				}
				else
				{
					MessageBox.Show("No se puede agregar esta materia");
				}
			}
		}

		public void EliminarMateria(int codigo)
		{
			Materia eliminar = listadomaterias.Find(x => x.Codigo == codigo);
			if (eliminar != null)
			{
				listadomaterias.Remove(eliminar);
				MessageBox.Show("Materia eliminada");
			}
			else
			{
				MessageBox.Show("NO EXISTE LA MATERIA EN ESTE ALUMNO");
			}
		}

		public void ModificarMateria(string nombre, int nota, Materia modificar)
		{
			if (nota < 11 && nota > 0)
			{
				modificar.ModificarMateria(nombre, nota);
			}
			else
			{
				MessageBox.Show("La nota no tiene el formato correcto");
			}
		}

		public void AsignarMateria(int codigo, string nombre, int nota)
		{
			if (nota < 11 && nota > 0)
			{
				Materia asignar = listadomaterias.Find(x => x.Codigo == codigo);
				ModificarMateria(nombre, nota, asignar);
			}
			else
			{
				MessageBox.Show("La nota es incorrecta");
			}
		}

		private bool GetNoEspecial()
		{
			return listadomaterias.Count(buscar => buscar is MateriaEspecial) < 1;
		}

		private static bool GetEspecial(Materia Agregar)
		{
			return Agregar is MateriaEspecial;
		}

		private static bool GetNoAprobada(Materia Agregar)
		{
			return Agregar.Nota < 4;
		}

		public List<Materia> DevolverLista()
		{
			return listadomaterias;
		}

		#endregion
	}
}
