using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    class Clase_implementacion_ITERADOR_Cola : Interador
    {
        private Queue<IComparableP> colas = new Queue<IComparableP>();
        int posicion;

        public Clase_implementacion_ITERADOR_Cola(Queue<IComparableP> colas)
        {
            this.colas = colas;
            posicion = 0;
        }

        public IComparableP actual()
        {
           return colas.Dequeue();
        }

        public bool fin()
        {
            if (posicion < colas.Count)
            {
                return false;
            }
            else { return true; }
        }

        public void siguiente()
        {
            posicion++;
        }
    }
}
