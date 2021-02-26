using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Vehiculo;

namespace Procesador
{
    public class Hangar : IEnumerator
    {
        List<Avion> aviones;
        int posicion;

        public Hangar(List<Avion> aviones)
        {
            this.aviones = aviones;
            posicion = 0;
        }

        public object Current => CurrentMember();

        private object CurrentMember()
        {
            return aviones[posicion];
        }

        public bool MoveNext()
        {
            if(posicion + 2 <= aviones.Count)
            {
                posicion++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            posicion = 0;
        }
    }
}
