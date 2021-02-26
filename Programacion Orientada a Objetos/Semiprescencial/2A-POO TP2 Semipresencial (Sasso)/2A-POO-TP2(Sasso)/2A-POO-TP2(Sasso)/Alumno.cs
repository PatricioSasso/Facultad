using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2A_POO_TP2_Sasso_
{
    class Alumno
    {
        private int legajo;
        private string nombre;
        private string apellido;
        private List<Especializadas> especializadas;
        private List<Basicas> basicas;

        public int Legajo { get => legajo; }
        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public List<Especializadas> Especializadas { get => especializadas; }
        public List<Basicas> Basicas { get => basicas; }

        public Alumno(int Legajo, string Nombre, string Apellido)
        {
            this.legajo = Legajo;
            this.nombre = Nombre;
            this.apellido = Apellido;
            this.especializadas = new List<Especializadas>();
            this.basicas = new List<Basicas>();
        }

        public void Modificar(string NuevoNombre, string NuevoApellido)
        {
            this.nombre = NuevoNombre;
            this.apellido = NuevoApellido;
        }

        public void AgregarMateria(string Tipo)
        {
            try
            {
                int Codigo = int.Parse(Interaction.InputBox("Ingrese el código de la materia"));
                string Nombre = Interaction.InputBox("Ingrese el nombre de la materia");
                int Nota = int.Parse(Interaction.InputBox("Ingrese la nota del alumno en la materia \nEn caso de estar cursando la materia ingrese cero"));
                if (Tipo == "Especializada")
                {
                    if (this.especializadas.Exists(e => e.Codigo == Codigo))
                    {
                        MessageBox.Show("El código de materia ya está utilizado");
                    }
                    else
                    {
                        Especializadas.Add(new Especializadas(Codigo, Nombre, Nota));
                        MessageBox.Show("Materia agregada.");
                    }
                }
                if (Tipo == "Basica")
                {
                    if (this.basicas.Exists(b => b.Codigo != Codigo))
                    {
                        MessageBox.Show("El código de materia ya está utilizado");
                    }
                    else
                    {
                        Especializadas.Add(new Especializadas(Codigo, Nombre, Nota));
                        MessageBox.Show("Materia agregada.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void EliminarMateria(int Codigo, string Tipo)
        {
            try
            {
                if (Tipo == "Especializada")
                {
                    if (this.especializadas.Exists(e => e.Codigo == Codigo))
                    {
                        this.especializadas.Remove(this.especializadas.Find(e => e.Codigo == Codigo));
                        MessageBox.Show("Materia eliminada");
                    }
                    else
                    {
                        MessageBox.Show("No existe ninguna materia especializada con ese código en este alumno");
                    }
                }
                if (Tipo == "Basica")
                {
                    if (this.basicas.Exists(b => b.Codigo == Codigo))
                    {
                        this.basicas.Remove(this.basicas.Find(b => b.Codigo == Codigo));
                        MessageBox.Show("Materia eliminada");
                    }
                    else
                    {
                        MessageBox.Show("No existe ninguna materia básica con ese código en este alumno");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ModificarMateria(int Codigo, string Tipo)
        {
            try
            {
                int NuevoCodigo = int.Parse(Interaction.InputBox("Ingrese el código de la materia"));
                string NuevoNombre = Interaction.InputBox("Ingrese el nombre de la materia");
                int NuevaNota = int.Parse(Interaction.InputBox("Ingrese la nota del alumno en la materia \nEn caso de estar cursando la materia ingresar cero"));
                if (Tipo == "Especializada")
                {
                    if (this.especializadas.Exists(e => e.Codigo == NuevoCodigo))
                    {
                        this.especializadas.Find(e => e.Codigo == NuevoCodigo).Modificar(NuevoCodigo, NuevoNombre, NuevaNota);
                        MessageBox.Show("Materia modificada");
                    }
                    else
                    {
                        MessageBox.Show("No existe ninguna materia especializada con ese código en este alumno");
                    }
                }
                if (Tipo == "Basica")
                {
                    if (this.basicas.Exists(b => b.Codigo == NuevoCodigo))
                    {
                        this.basicas.Find(b => b.Codigo == NuevoCodigo).Modificar(NuevoCodigo, NuevoNombre, NuevaNota);
                        MessageBox.Show("Materia modificada");
                    }
                    else
                    {
                        MessageBox.Show("No existe ninguna materia básica con ese código en este alumno");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

