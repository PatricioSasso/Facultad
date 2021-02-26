using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1___EJ_2
{
    class Titular
    {
        private string nombre;
        private string apellido;
        private double dni;
        private string tipoDNI;
        private List<Cuentas> cuentas;

        public Titular(string nombre, string apellido, double dni, string tipoDNI)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.tipoDNI = tipoDNI;
            this.cuentas = new List<Cuentas>();
        }

        public double DNI { get => dni; }
        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public string TipoDNI { get => tipoDNI; }

        public void AñadirCuenta(Cuentas añadir)
        {
            bool contiene = cuentas.Contains(añadir);
            if (!contiene)
            {
                this.cuentas.Add(añadir);
            }
        }

        public void BorrarCuenta(Cuentas borrar)
        {
            bool contieneCuenta = cuentas.Contains(borrar);
            if (contieneCuenta)
            {
                this.cuentas.Remove(borrar);
            }
        }

        public List<Cuentas> ObtenerCuentas()
        {
            return this.cuentas;
        }

        public void Modificar(string nombre, string apellido, double dni, string tipoDNI)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.tipoDNI = tipoDNI;
        }
    }

    abstract class Cuentas
    {
        private double saldo;
        private int id;
        private List<Titular> titulares;

        protected Cuentas(double saldo, int id)
        {
            this.saldo = saldo;
            this.id = id;
            titulares = new List<Titular>();
        }

        public int Id { get => id; set => id = value; }
        public double Saldo { get => saldo; set => saldo = value; }

        public virtual bool Extraer(double cantidad)
        {
            if (cantidad <= saldo)
            {
                saldo -= cantidad;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Depositar(double cantidad)
        {
            saldo += cantidad;
        }

        public void Modificar(double cantidad, int id)
        {
            saldo = cantidad;
            this.id = id;
        }

        public List<Titular> ObtenerTitulares()
        {
            return titulares;
        }

        public void AñadirTitular(Titular añadir)
        {
            bool contiene = titulares.Contains(añadir);
            if (!contiene)
            {
                titulares.Add(añadir);
            }
        }

        public void BorrarTitular(Titular borrar)
        {
            bool contiene = titulares.Contains(borrar);
            if (contiene)
            {
                titulares.Remove(borrar);
            }
        }
    }

    class cajaAhorro : Cuentas
    {
        public cajaAhorro(double saldo, int id) : base(saldo, id)
        {

        }
    }

    class CuentaCorriente : Cuentas
    {
        private double descubierto;
        public CuentaCorriente(double descubierto, double dineroCuenta, int id) : base(dineroCuenta, id)
        {
            this.descubierto = descubierto;
        }

        public double Descubierto { get => descubierto; set => descubierto = value; }

        public override bool Extraer(double cantidad)
        {
            double dineroTotal = Saldo + descubierto;
            if (cantidad <= dineroTotal)
            {
                Saldo -= cantidad;
                return true;
            }
            else
            {
                return false;
            }

        }

        public void Modificar(double descubierto, double saldo, int id)
        {
            this.descubierto = descubierto;
            Saldo = saldo;
            Id = id;
        }
    }
}
