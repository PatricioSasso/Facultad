using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreaCar
{
    public class BuilderFiatSiena:BuilderAuto
    {
        public BuilderFiatSiena()
        {
            auto = new Auto();
        }
        public override void ConstruirMarca()
        {
            auto.Marca = "Fiat";
        }
        public override void ConstruirModelo()
        {
            auto.Modelo = "Siena";
        }
        public override void ConstruirMotor()
        {
            Motor motor = new Motor();
            motor.Numero = "1236";
            motor.Potencia = "1.6";
            auto.Motor = motor;
        }
        public override void ConstruirPuertas(int cantidadPuertas)
        {
            if (cantidadPuertas == 3)
            {
                auto.CamtidadPuertas = "3";
            }
            if (cantidadPuertas == 5)
            {
                auto.CamtidadPuertas = "5";
            }
        }
    }
}
