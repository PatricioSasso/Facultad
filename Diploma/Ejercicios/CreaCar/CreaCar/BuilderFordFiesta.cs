using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreaCar
{
    public class BuilderFordFiesta:BuilderAuto
    {
        public BuilderFordFiesta()
        {
            auto = new Auto();
        }
        public override void ConstruirMarca()
        {
            auto.Marca = "Ford";
        }
        public override void ConstruirModelo()
        {
            auto.Modelo = "Fiesta";
        }
        public override void ConstruirMotor()
        {
            Motor motor = new Motor();
            motor.Numero = "1235";
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
