using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreaCar
{
    public class Auto
    {

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string CamtidadPuertas { get; set; }
        public Motor Motor  { get; set; }

    }
    public class Motor
    {
        public string Numero { get; set; }
        public string Potencia{ get; set; }

    }
}
