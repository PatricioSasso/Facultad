using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1___EJ_2
{
    class Banco
    {
        private List<Titular> titulares;
        private List<Cuentas> cuentas;
        private List<cajaAhorro> cajasAhorro;
        private List<CuentaCorriente> cuentasCorriente;

        public Banco()
        {
            titulares = new List<Titular>();
            cuentas = new List<Cuentas>();
            cajasAhorro = new List<cajaAhorro>();
            cuentasCorriente = new List<CuentaCorriente>();
        }

        public event EventHandler DepositoEvent;
        public event EventHandler ImporteEvent;

        public bool AñadirTitularr(string nombre, string apellido, double dni, string tipoDni)
        {
            if (!ExisteTitular(dni) && dni != 0)
            {
                Titular añadir = new Titular(nombre, apellido, dni, tipoDni);
                titulares.Add(añadir);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ModificarTitular(double dniOrigen, string nombre, string apellido, double dni, string tipoDni)
        {
            if (ExisteTitular(dniOrigen) && !ExisteTitular(dni))
            {
                Titular modificar = ObtenerTitular(dniOrigen);
                modificar.Modificar(nombre, apellido, dni, tipoDni);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EliminarTitular(double dni)
        {
            if (ExisteTitular(dni))
            {
                Titular eliminar = ObtenerTitular(dni);
                titulares.Remove(eliminar);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AñadirCuentaCorriente(double descubierto, double saldo, int id)
        {
            if (!ExisteCuenta(id) && id != 0)
            {
                CuentaCorriente añadirCuenta = new CuentaCorriente(descubierto, saldo, id);
                cuentas.Add(añadirCuenta);
                cuentasCorriente.Add(añadirCuenta);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ModificarCuentaCorriente(int idOrigen, double descubierto, double saldo, int id)
        {
            if (ExisteCuenta(idOrigen))
            {
                CuentaCorriente modificar = ObtenerCuentaCorriente(idOrigen);
                modificar.Modificar(descubierto, saldo, id);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EliminarCuentaCorriente(int id)
        {
            if (ExisteCuenta(id))
            {
                CuentaCorriente eliminar = ObtenerCuentaCorriente(id);
                cuentas.Remove(eliminar);
                cuentasCorriente.Remove(eliminar);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AñadirCajaAhorro(double saldo, int id)
        {
            if (!ExisteCuenta(id) && id != 0)
            {
                cajaAhorro añadirCaja = new cajaAhorro(saldo, id);
                cajasAhorro.Add(añadirCaja);
                cuentas.Add(añadirCaja);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ModificarCajaAhorro(int idorigen, double saldo, int id)
        {
            if (ExisteCuenta(idorigen))
            {
                cajaAhorro modificarCaja = ObtenerCajaAhorro(idorigen);
                modificarCaja.Modificar(saldo, id);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EliminarCajaAhorro(int id)
        {
            if (ExisteCuenta(id))
            {
                cajaAhorro eliminarCaja = ObtenerCajaAhorro(id);
                cajasAhorro.Remove(eliminarCaja);
                cuentas.Remove(eliminarCaja);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ExtraerCuentaCorriente(int id, double cantidad)
        {
            if (ExisteCuenta(id))
            {
                CuentaCorriente Extraer = ObtenerCuentaCorriente(id);
                bool resultado = Extraer.Extraer(cantidad);
                if (resultado)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public bool ExtraerCajaAhorro(int id, double cantidad)
        {
            if (ExisteCuenta(id))
            {
                cajaAhorro Extraer = ObtenerCajaAhorro(id);
                bool resultado = Extraer.Extraer(cantidad);
                if (resultado)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public bool Depositar(int id, double cantidad)
        {
            if (ExisteCuenta(id))
            {
                if (cantidad > 1000)
                {
                    string mensaje = string.Format("el importe es {0}", cantidad);
                    ImporteEvent(mensaje, new EventArgs());
                }
                Cuentas DepositarCuenta = ObtenerCuenta(id);
                DepositarCuenta.Depositar(cantidad);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool TransferirCuentaCorriente(int idOrigen, double cantidad, int idDestino)
        {
            if (ExisteCuenta(idOrigen) && ExisteCuenta(idDestino))
            {
                CuentaCorriente cuentaCorriente = ObtenerCuentaCorriente(idOrigen);
                Cuentas cuenta = ObtenerCuenta(idDestino);
                bool resultado = cuentaCorriente.Extraer(cantidad);
                if (resultado)
                {
                    if (cantidad > 1000)
                    {
                        string mensaje = string.Format("el ID de la cuenta de origen es {0}", idOrigen);
                        DepositoEvent(mensaje, new EventArgs());
                    }
                    cuenta.Depositar(cantidad);
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }

        public bool TransfererirCajaAhorro(int idOrigen, double cantidad, int idDestino)
        {
            if (ExisteCuenta(idOrigen) && ExisteCuenta(idDestino))
            {
                cajaAhorro cajaAhorro = ObtenerCajaAhorro(idOrigen);
                Cuentas cuenta = ObtenerCuenta(idDestino);
                bool resultado = cajaAhorro.Extraer(cantidad);
                if (resultado)
                {
                    if (cantidad > 1000)
                    {
                        string mensaje = string.Format("el ID de la cuenta de origen es {0}", idOrigen);
                        DepositoEvent(mensaje, new EventArgs());
                    }
                    cuenta.Depositar(cantidad);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool Añadir_Titular_Cuenta(int dni, int id)
        {
            if (ExisteTitular(dni) && ExisteCuenta(id))
            {
                Titular titular = ObtenerTitular(dni);
                Cuentas cuenta = ObtenerCuenta(id);
                titular.AñadirCuenta(cuenta);
                cuenta.AñadirTitular(titular);
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Eliminar_Titular_Cuenta(int dni, int id)
        {
            if (ExisteTitular(dni) && ExisteCuenta(id))
            {
                Titular titular = ObtenerTitular(dni);
                Cuentas cuenta = ObtenerCuenta(id);
                titular.BorrarCuenta(cuenta);
                cuenta.BorrarTitular(titular);
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Titular> ObtenerTitular()
        {
            return titulares;
        }

        public List<Cuentas> ObtenerCuentasDeTitulares(int index)
        {
            Titular titularBuscado = titulares[index];
            return titularBuscado.ObtenerCuentas();
        }

        public List<Cuentas> ObtenerCuenta()
        {
            return cuentas;
        }

        public List<CuentaCorriente> ObtenerCuentasCorrientes()
        {
            return cuentasCorriente;
        }

        public List<Titular> ObtenerTitularesDeCuentas(int index)
        {
            Cuentas cuentaBusqueda = cuentas[index];
            return cuentaBusqueda.ObtenerTitulares();
        }

        private Titular ObtenerTitular(double dni)
        {
            Titular titularBuscado = titulares.Find(buscado => buscado.DNI == dni);
            return titularBuscado;
        }

        private Cuentas ObtenerCuenta(int id)
        {
            Cuentas cuentaBuscada = cuentas.Find(buscada => buscada.Id == id);
            return cuentaBuscada;
        }

        private cajaAhorro ObtenerCajaAhorro(int id)
        {
            cajaAhorro cajaBuscada = cajasAhorro.Find(buscada => buscada.Id == id);
            return cajaBuscada;
        }

        private CuentaCorriente ObtenerCuentaCorriente(int id)
        {
            CuentaCorriente cuentaBuscada = cuentasCorriente.Find(buscada => buscada.Id == id);
            return cuentaBuscada;
        }

        private bool ExisteCuenta(int id)
        {
            Cuentas buscada = ObtenerCuenta(id);
            if (buscada != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool ExisteTitular(double dni)
        {
            Titular buscado = ObtenerTitular(dni);
            if (buscado != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
