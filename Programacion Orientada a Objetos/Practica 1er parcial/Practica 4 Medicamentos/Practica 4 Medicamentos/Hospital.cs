using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_4_Medicamentos
{
    class Hospital
    {
        private List<Medicamento> medicamentos;
        private List<Paciente> pacientes;

        public event EventHandler<EventoMedicamentoEntregadoAnteriormente> Evento;

        public Hospital()
        {
            this.medicamentos = new List<Medicamento>();
            this.pacientes = new List<Paciente>();
        }

        internal List<Medicamento> Medicamentos { get => medicamentos; }
        internal List<Paciente> Pacientes { get => pacientes; }

        #region ABM Paciente

        public void AltaPaciente(int dni, string apellido, string nombre)
        {
            if(pacientes.Exists(p => p.Dni == dni))
            {
                MessageBox.Show("Ya existe un paciente con ese DNI");
            }
            else
            {
                pacientes.Add(new Paciente(dni, apellido, nombre));
            }
        }

        public void ModificarPaciente(int dni, string nuevoApellido, string nuevoNombre)
        {
            Paciente buscar = pacientes.Find(p => p.Dni == dni);
            if (buscar != null)
            {
                buscar.Modificar(nuevoApellido, nuevoNombre);
            }
            else
            {
                MessageBox.Show("No existe ningún paciente con ese DNI");
            }
        }

        public void BajaPaciente(int dni)
        {
            Paciente buscar = pacientes.Find(p => p.Dni == dni);
            if (buscar != null)
            {
                pacientes.Remove(buscar);
            }
            else
            {
                MessageBox.Show("No existe ningún paciente con ese DNI");
            }
        }

        #endregion

        #region ABM Medicamento

        public void AltaMedicamento(int codigo, int lote, string descripcion, DateTime vencimiento, int cantidad)
        {
            if(medicamentos.Exists(m => m.Codigo == codigo))
            {
                MessageBox.Show("Ya existe un medicamento con ese CÓDIGO");
            }
            else
            {
                medicamentos.Add(new Medicamento(codigo, lote, descripcion, vencimiento, cantidad));
            }
        }

        public void ModificarMedicamento(int codigo, int nuevoLote, string nuevaDescripcion, DateTime nuevoVencimiento, int nuevaCantidad)
        {
            Medicamento buscar = medicamentos.Find(m => m.Codigo == codigo);
            if (buscar != null)
            {
                buscar.Modificar(nuevoLote, nuevaDescripcion, nuevoVencimiento, nuevaCantidad);
            }
            else
            {
                MessageBox.Show("No existe ningún medicamento con ese CÓDIGO");
            }
        }

        public void BajaMedicamento(int codigo)
        {
            Medicamento buscar = medicamentos.Find(m => m.Codigo == codigo);
            if (buscar != null)
            {
                medicamentos.Remove(buscar);
            }
            else
            {
                MessageBox.Show("No existe ningún medicamento con ese CÓDIGO");
            }
        }

        #endregion

        public void EntregarMedicamento(int codigo, int dni, int cantidadAEntregar)
        {
            try
            {
                Paciente p_buscar = pacientes.Find(p => p.Dni == dni);
                Medicamento p_ya_tiene_el_medicamento = p_buscar.P_medicamentos.Find(m => m.Codigo == codigo);
                Medicamento m_buscar = medicamentos.Find(m => m.Codigo == codigo);
                if (p_buscar != null && m_buscar != null && p_ya_tiene_el_medicamento == null)
                {
                    p_buscar.P_medicamentos.Add(new Medicamento(m_buscar.Codigo, m_buscar.Lote, m_buscar.Descripcion, m_buscar.Vencimiento, cantidadAEntregar));
                    m_buscar.ModificarCantidad(m_buscar.Cantidad - cantidadAEntregar);
                }
                else if (p_buscar != null && m_buscar != null)
                {
                    p_ya_tiene_el_medicamento.ModificarCantidad(p_ya_tiene_el_medicamento.Cantidad + cantidadAEntregar);
                    m_buscar.ModificarCantidad(m_buscar.Cantidad - cantidadAEntregar);
                    Evento?.Invoke(this, new EventoMedicamentoEntregadoAnteriormente(p_ya_tiene_el_medicamento.Cantidad));
                }
                else
                {
                    throw new Exception("El DNI o el CÓDIGO ingresados son erróneos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    public class EventoMedicamentoEntregadoAnteriormente : EventArgs
    {
        private int entregasPrevias;

        public int EntregasPrevias { get => entregasPrevias; set => entregasPrevias = value; }

        public EventoMedicamentoEntregadoAnteriormente(int entregasPrevias)
        {
            this.entregasPrevias = entregasPrevias;
        }
    }
}
