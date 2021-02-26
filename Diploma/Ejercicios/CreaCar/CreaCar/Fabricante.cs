using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreaCar
{
    public class Fabricante
    {
        public Auto ConstruirAuto(BuilderAuto builderAuto, int cantidadPuertas)
        {
            builderAuto.ConstruirMarca();
            builderAuto.ConstruirModelo();
            builderAuto.ConstruirMotor();
            builderAuto.ConstruirPuertas(cantidadPuertas);

            return builderAuto.auto;
        }

    }
}
