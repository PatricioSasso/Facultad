using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_Requerido_SE
{
	 public class Alumno
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
		public void ModificarAlumno(int legajo, string nombre, string apellido)
		{
			this.legajo = legajo;
			this.nombre = nombre;
			this.apellido = apellido;
		}
		#region PROPIEDADES ALUMNOS
		public string NOMBREALUMNO { get => nombre; set => nombre = value; }
		public string APELLIDOALUMNO { get => apellido; set => apellido = value; }
		public int LEGAJOALUMNO { get => legajo; set => legajo = value; }
		#endregion
		public override string ToString() =>legajo.ToString() + ", " + nombre + ", " + apellido + ".";
		
		#region AMB de MATERIAS
		public void AgregarMateria(Materia buscar)
		{
			if(listadomaterias.Contains(buscar))
			{
				MessageBox.Show("EL ALUMNO YA TIENE ESTA MATERIA REGISTRADA");
			}
			else
			{
				bool NoAprob = GetNoAprobada(buscar);
				bool NoEsp = GetNoEspecial();
				bool Esp = GetEspecial(buscar);
				if(NoAprob && NoEsp)
				{
					listadomaterias.Add(buscar);
					MessageBox.Show("Materia dada de alta con éxito");
				}
				else if(NoAprob && !Esp)
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

		public void BorrarMateria (int codigo)
		{
			Materia a = listadomaterias.Find(x => x.CODIGOMATERIA == codigo);
			if(a!=null)
			{
				listadomaterias.Remove(a);
				MessageBox.Show("Materia eliminada");
			}
			else
			{
				MessageBox.Show("NO EXISTE LA MATERIA EN ESTE ALUMNO");
			}
		}

		public void ModificarMat(string nombre, int nota, Materia modificar)
		{
			if(nota<11 && nota>0)
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
			if(nota<11 && nota>0)
			{
				Materia a = listadomaterias.Find(x => x.CODIGOMATERIA == codigo);
				ModificarMat(nombre, nota, a);
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
			return Agregar.NOTAMATERIA < 4;
		}

		public List<Materia> Devolverlista()
		{
			return listadomaterias;
		}
		
		#endregion

	}
}
