using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace U1_Ej1
{
	class Universidad
	{
		private List<Alumno> alumnos;

		public Universidad()
		{
			this.alumnos = new List<Alumno>();
		}

		#region AMB ALUMNOS

		public void AgregarAlumno()
		{
			int legajo = int.Parse(Interaction.InputBox("Ingrese el legajo del alumno"));
			if (alumnos.Exists(x => x.Legajo == legajo))
			{
				MessageBox.Show("El legajo ya pertenece a un alumno");
			}
			else
			{
				string nombre = Interaction.InputBox("Ingrese el nombre del alumno");
				string apellido = Interaction.InputBox("Ingrese el apellido del alumno");
				Alumno agregar = new Alumno(legajo, nombre, apellido);
				alumnos.Add(agregar);
			}
		}

		public void ModificarAlumno()
		{
			int legajo = int.Parse(Interaction.InputBox("Ingrese el legajo a modificar"));
			if (alumnos.Exists(x => x.Legajo == legajo))
			{
				string nuevoNombre = Interaction.InputBox("Ingrese el nuevo nombre");
				string nuevoApellido = Interaction.InputBox("Ingrese el nuevo apellido");
				Alumno modificar = alumnos.Find(x => x.Legajo == legajo);
				modificar.ModificarAlumno(legajo, nuevoNombre, nuevoApellido);
			}
			else
			{
				MessageBox.Show("El legajo no existe");
			}
		}

		public void EliminarAlumno()
		{
			int legajo = int.Parse(Interaction.InputBox("Ingrese el legajo a borrar"));
			if (alumnos.Exists(x => x.Legajo == legajo))
			{
				Alumno eliminar = alumnos.Find(x => x.Legajo == legajo);
				alumnos.Remove(eliminar);
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
			Alumno alumno = alumnos.Find(x => x.Legajo == legajo);
			IEnumerable<Materia> aprobadas = alumno.DevolverLista().Where(materia => materia.Nota >= 4);
			return aprobadas.ToList();
		}

		public List<Materia> MateriasDesaprobadas(int legajo)
		{
			Alumno alumno = alumnos.Find(x => x.Legajo == legajo);
			IEnumerable<Materia> desaprobadas = alumno.DevolverLista().Where(materia => materia.Nota < 4 && materia.Nota > 0);
			return desaprobadas.ToList();
		}

		public List<Materia> MateriasCursando(int legajo)
		{
			Alumno alumno = alumnos.Find(x => x.Legajo == legajo);
			IEnumerable<Materia> cursando = alumno.DevolverLista().Where(materia => materia.Nota == 0);
			return cursando.ToList();
		}

		#endregion

		#region ABM MATERIAS

		public void AgregarBasica(int codigo, string nombre)
		{
			int legajo = int.Parse(Interaction.InputBox("Ingrese el legajo del alumno que le desea agregar materias"));
			Alumno agregar = alumnos.Find(x => x.Legajo == legajo);
			if (agregar != null)
			{
				MateriaBasica basica = new MateriaBasica(codigo, nombre);
				agregar.AgregarMateria(basica);
			}
			else
			{
				MessageBox.Show("El legajo no existe");
			}
		}

		public void AgregarEspecial(int codigo, string nombre)
		{
			int legajo = int.Parse(Interaction.InputBox("Ingrese el legajo del alumno que le desea agregar materias"));
			Alumno agregar = alumnos.Find(x => x.Legajo == legajo);
			if (agregar != null)
			{
				MateriaEspecial especial = new MateriaEspecial(codigo, nombre);
				agregar.AgregarMateria(especial);
			}
		}

		public void ModificarMateria()
		{
			int legajo = int.Parse(Interaction.InputBox("Ingrese el legajo del alumno que le desea modificar materias"));
			Alumno modificar = alumnos.Find(x => x.Legajo == legajo);
			if (modificar != null)
			{
				int materia = int.Parse(Interaction.InputBox("Ingrese el codigo de la materia"));
				string nombre = Interaction.InputBox("Ingrese el nuevo nombre");
				int nota = int.Parse(Interaction.InputBox("Ingrese la nota"));
				modificar.AsignarMateria(materia, nombre, nota);
			}
		}

		public void EliminarMateria()
		{
			int legajo = int.Parse(Interaction.InputBox("Ingrese el legajo del alumno que le desea eliminar materias"));
			Alumno alumno = alumnos.Find(x => x.Legajo == legajo);
			if (alumno != null)
			{
				int eliminar = int.Parse(Interaction.InputBox("Ingrese el codigo de la materia"));
				alumno.EliminarMateria(eliminar);
			}
		}

		#endregion

	}
}
