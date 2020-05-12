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
            Stack<IComparableP> pilas_copia2;
            pilas_copia2 = Clonar();
            return pilas_copia2.Pop();
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

        public Stack<IComparableP> Clonar()
        {
            Stack<IComparableP> pila_clon = new Stack<IComparableP>();
            Stack<IComparableP> pila_clon2 = new Stack<IComparableP>();
            int total = pilas.Count;
            for (int x = 0; x < total; x++)
            {
                pila_clon.Push(pilas.Peek());
                pila_clon2.Push(pilas.Pop());

            }
            pilas = pila_clon2;
            return pila_clon;
        }

    }
}
