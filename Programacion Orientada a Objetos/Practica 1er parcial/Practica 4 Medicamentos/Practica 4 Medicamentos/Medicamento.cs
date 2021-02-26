using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4_Medicamentos
{
    class Medicamento
    {
        private int codigo;
        private int lote;
        private string descripcion;
        private DateTime vencimiento;
        private int cantidad;

        public Medicamento(int codigo, int lote, string descripcion, DateTime vencimiento, int cantidad)
        {
            this.codigo = codigo;
            this.lote = lote;
            this.descripcion = descripcion;
            this.vencimiento = vencimiento;
            this.cantidad = cantidad;
        }

        public int Codigo { get => codigo; }
        public int Lote { get => lote; set => lote = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime Vencimiento { get => vencimiento; set => vencimiento = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        public void Modificar(int nuevoLote, string nuevaDescripcion, DateTime nuevoVencimiento, int nuevaCantidad)
        {
            this.lote = nuevoLote;
            this.descripcion = nuevaDescripcion;
            this.vencimiento = nuevoVencimiento;
            this.cantidad = nuevaCantidad;
        }

        public void ModificarCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }

    }
}
