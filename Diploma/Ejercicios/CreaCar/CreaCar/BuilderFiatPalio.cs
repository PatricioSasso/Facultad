using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreaCar
{
    public class BuilderFiatPalio:BuilderAuto
    {

        public BuilderFiatPalio()
        {
            auto = new Auto();
        }
        public override void ConstruirMarca()
        {
            auto.Marca = "Fiat";
        }
        public override void ConstruirModelo()
        {
            auto.Modelo = "Palio";
        }
        public override void ConstruirMotor()
        {
            Motor motor = new Motor();
            motor.Numero = "1237";
            motor.Potencia = "1.3";
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
