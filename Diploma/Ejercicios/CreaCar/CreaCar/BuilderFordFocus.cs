using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CreaCar
{
    public class BuilderFordFocus: BuilderAuto
    {
        public BuilderFordFocus()
        {
            auto = new Auto();
        }
        public override void ConstruirMarca()
        {
            auto.Marca = "Ford";
        }
        public override void ConstruirModelo()
        {
            auto.Modelo= "Focus";
        }
        public override void ConstruirMotor()
        {
            Motor motor = new Motor();
            motor.Numero = "1234";
            motor.Potencia = "2.0";
            auto.Motor=motor;
        }
        public override void ConstruirPuertas(int cantidadPuertas)
        {
            if (cantidadPuertas==3)
            {
                auto.CamtidadPuertas="3";
            }
            if (cantidadPuertas == 5)
            {
                auto.CamtidadPuertas = "5";
            }
        }

    }
}
