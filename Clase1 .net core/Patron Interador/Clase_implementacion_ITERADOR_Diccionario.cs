using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    class Clase_implementacion_ITERADOR_Diccionario : Interador
    {
        private Dictionary<IComparableP, object> diccionario = new Dictionary<IComparableP, object>();
        private int posicion;

        public Clase_implementacion_ITERADOR_Diccionario(Dictionary<IComparableP, object> diccionario)
        {
            this.diccionario = diccionario;
            this.posicion = 0;
        }

        public IComparableP actual()
        { 
            int contador = 0;
            IComparableP objetoActual = null;
            foreach (IComparableP donde_estoy in diccionario.Keys)
            {
                if (contador == posicion)
                {
                    return donde_estoy;

                }
                contador++;
            }

           
            return objetoActual;
            
        }

        public bool fin()
        {
            if (posicion<diccionario.Count)
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
