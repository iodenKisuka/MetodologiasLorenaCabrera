using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    class ColeccionMultiple: IColeccionableTP
    {
      public Pila pila_colecion = new Pila();
      public Cola cola_coleccion = new Cola();
        private IColeccionableTP pila;
        private IColeccionableTP cola;

        public ColeccionMultiple(Pila p, Cola c) {
            this.pila_colecion =p;
            this.cola_coleccion = c;
        }

        public ColeccionMultiple(IColeccionableTP pila, IColeccionableTP cola)
        {
            this.pila = pila;
            this.cola = cola;
        }

        public void Agregar(IComparableP objeto)
        {
            throw new NotImplementedException();
        }

        public bool Contiene(IComparableP objeto)
        {
            return cola_coleccion.Contiene(objeto) || pila_colecion.Contiene(objeto);
            
        }

        public int Cuantos()
        {
            return pila_colecion.Cuantos()+cola_coleccion.Cuantos();
        }

       

        public IComparableP Maximo()
        {
           IComparableP maximo_pila =pila_colecion.Maximo();
           IComparableP maximo_Cola = cola_coleccion.Maximo();
            if (maximo_Cola.SosMayor(maximo_pila)){
                return maximo_Cola;
            }
            else { return maximo_pila; }
        }

        public IComparableP Minimo()
        {
            IComparableP minimo_pila = pila_colecion.Maximo();
            IComparableP minimo_Cola = cola_coleccion.Maximo();
            if (minimo_Cola.SosMenor(minimo_pila))
            {
                return minimo_Cola;
            }
            else { return minimo_pila; }
        }

        public Interador iterador()
        {
            throw new NotImplementedException();
        }

    }
}
