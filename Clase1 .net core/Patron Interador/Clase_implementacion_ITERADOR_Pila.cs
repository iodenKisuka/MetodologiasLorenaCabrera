using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    class Clase_implementacion_ITERADOR_Pila : Interador
    {
        Stack<IComparableP> pilas = new Stack<IComparableP>();
        int posicion;

        public Clase_implementacion_ITERADOR_Pila(Stack<IComparableP> pilas)
        {
            this.pilas = pilas;
            this.posicion = 0;
        }

        public IComparableP actual()
        {
           return pilas.Pop();
        }

        public bool fin()
        {
            if (posicion < pilas.Count)
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
