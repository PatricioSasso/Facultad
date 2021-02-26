using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreaCar
{
    public abstract class BuilderAuto
    {
        public Auto auto{ get; set; }
        public virtual void ConstruirMarca() { }
        public virtual void ConstruirModelo() { }
        public virtual void ConstruirPuertas(int cantidadPuertas) { }
        public virtual void ConstruirMotor() { }
    }
}
