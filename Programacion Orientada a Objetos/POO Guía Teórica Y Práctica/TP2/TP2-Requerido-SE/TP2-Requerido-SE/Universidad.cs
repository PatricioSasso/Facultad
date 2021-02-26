using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace TP2_Requerido_SE
{
	class Universidad
	{
		private List<Alumno> alumnos;

		public Universidad()
		{
			this.alumnos = new List<Alumno>();
		}
		public event EventHandler PromedioEvent; 
        #region AMB ALUMNOS
		public void AgregarAlumno()
		{
			int nuevoleg = int.Parse(Interaction.InputBox("Ingrese el legajo del alumno"));
			if(alumnos.Exists(x=> x.LEGAJOALUMNO==nuevoleg))
			{
				MessageBox.Show("El legajo ya pertenece a un alumno");
			}
			else
			{
				string nuevon = Interaction.InputBox("Ingrese el nombre del alumno");
				string nuevoa = Interaction.InputBox("Ingrese el apellido del alumno");
				Alumno a = new Alumno(nuevoleg, nuevon, nuevoa);
				alumnos.Add(a);
			}
		}

		public void ModificarAlumno()
		{
			int legajomodifcar = int.Parse(Interaction.InputBox("Ingrese el legajo a modificar"));
			if(alumnos.Exists(x=>x.LEGAJOALUMNO==legajomodifcar))
			{
				string nuevonombre = Interaction.InputBox("Ingrese el nuevo nombre");
				string nuevoapellido = Interaction.InputBox("Ingrese el nuevo apellido");
				Alumno a = alumnos.Find(x => x.LEGAJOALUMNO == legajomodifcar);
				a.ModificarAlumno(legajomodifcar, nuevonombre, nuevoapellido);
			}
			else
			{
				MessageBox.Show("El legajo no existe");
			}
		}
		public void EliminarAlumno()
		{
			int legajoborrar = int.Parse(Interaction.InputBox("Ingrese el legajo a borrar"));
			if (alumnos.Exists(x => x.LEGAJOALUMNO == legajoborrar))
			{
				Alumno a = alumnos.Find(x => x.LEGAJOALUMNO == legajoborrar);
				alumnos.Remove(a);
			}
			else
			{
				MessageBox.Show("El legajo no existe");
			}
		}
		#endregion

		#region LISTAS
		public List<Alumno> listalumos()
		{
			return this.alumnos; 
		}
		public List<Materia> MateriasAprobadas(int legajo)
		{
			Alumno alumno = alumnos.Find(x => x.LEGAJOALUMNO == legajo);
			IEnumerable<Materia> aprobadas = alumno.Devolverlista().Where(materia => materia.NOTAMATERIA >= 4);
			return aprobadas.ToList();
		}
		public List<Materia> MateriasDesaprobadas(int legajo)
		{
			Alumno alumno = alumnos.Find(x => x.LEGAJOALUMNO == legajo);
			IEnumerable<Materia> desaprobadas = alumno.Devolverlista().Where(materia => materia.NOTAMATERIA < 4 && materia.NOTAMATERIA > 0);
			return desaprobadas.ToList();
		}
		public List<Materia> MateriasCursando(int legajo)
		{
			Alumno alumno = alumnos.Find(x => x.LEGAJOALUMNO == legajo);
			IEnumerable<Materia> cursando = alumno.Devolverlista().Where(materia => materia.NOTAMATERIA == 0);
			return cursando.ToList();
		}

		#endregion

		#region ABM MATERIAS
		public void AgregarMateriaBasicaaX(int codigo, string nombre)
		{
			int legajo = int.Parse(Interaction.InputBox("Ingrese el legajo del alumno que le desea agregar materias"));
			Alumno a = alumnos.Find(x => x.LEGAJOALUMNO == legajo);
			if(a!=null)
			{
				MateriaBasica basica = new MateriaBasica(codigo, nombre);
				a.AgregarMateria(basica);
			}
			else
			{
				MessageBox.Show("El legajo no existe");
			}
		}
		public void AgregarMateriaEspaX(int codigo, string nombre)
		{
			int legajo = int.Parse(Interaction.InputBox("Ingrese el legajo del alumno que le desea agregar materias"));
			Alumno a = alumnos.Find(x => x.LEGAJOALUMNO == legajo);
			if(a!=null)
			{
				MateriaEspecial nueva = new MateriaEspecial(codigo, nombre);
				a.AgregarMateria(nueva);
			}
		}

		public void ModificarMateriadeX()
		{
			int legajo = int.Parse(Interaction.InputBox("Ingrese el legajo del alumno que le desea modificar materias"));
			Alumno a = alumnos.Find(x => x.LEGAJOALUMNO == legajo);
			if(a!=null)
			{
				int materia = int.Parse(Interaction.InputBox("Ingrese el codigo de la materia"));
				string nombre = Interaction.InputBox("Ingrese el nuevo nombre");
				int nota = int.Parse(Interaction.InputBox("Ingrese la nota"));
				a.AsignarMateria(materia, nombre, nota);
			}
		}

		public void BorrarMateriadeX()
		{
		  int legajo = int.Parse(Interaction.InputBox("Ingrese el legajo del alumno que le desea borrar materias"));
		  Alumno a = alumnos.Find(x => x.LEGAJOALUMNO == legajo);
			if(a!=null)
			{
				int materia = int.Parse(Interaction.InputBox("Ingrese el codigo de la materia"));
				a.BorrarMateria(materia);
			}
		}
		#endregion

        #region Alumno Promedio
		public double Notas(int legajo)
		{
			Alumno a = alumnos.Find(x => x.LEGAJOALUMNO == legajo);
			double promedio= a.Devolverlista().Average(materia => materia.NOTAMATERIA);
			if(promedio>=9)
			{
				string mensaje = string.Format("El alumno {0} tuvo el promedio {1}", a.NOMBREALUMNO, promedio);
				PromedioEvent?.Invoke(mensaje, new EventArgs());
			}
			return promedio;
		}
		public double calcularPromedioAprobadas(int legajoAlumno)
		{
			return MateriasAprobadas(legajoAlumno).Average(materia => materia.NOTAMATERIA);
		}
		#endregion

		#region Interfaces para Ordenar
		public void OrdenarDesc()
		{
			alumnos.Sort(new CompararApellidosDesc());
		}
		public void OrdenarAsc()
		{
			alumnos.Sort(new CompararApellidoAsc());
		}

		class CompararApellidosDesc : IComparer<Alumno>
		{
			public int Compare(Alumno a, Alumno b)
			{
				return a.APELLIDOALUMNO.CompareTo(b.APELLIDOALUMNO);
			}
		}

		class CompararApellidoAsc: IComparer<Alumno>
		{
			public int Compare(Alumno a, Alumno b)
			{
				return -1* a.APELLIDOALUMNO.CompareTo(b.APELLIDOALUMNO);
			}
		}
		#endregion
	}
}
