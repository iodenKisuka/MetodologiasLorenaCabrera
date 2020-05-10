using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    class Clase_implementacion_ITERADOR_Conjunto : Interador
    {
        List<IComparableP> conjunto = new List<IComparableP>();
        int posicion;

        public Clase_implementacion_ITERADOR_Conjunto(List<IComparableP> listacomparable)
        {
            conjunto = listacomparable;
            posicion = 0;
        }

        public IComparableP actual()
        {
            return conjunto[posicion];
        }

        public bool fin()
        {
            if (posicion < conjunto.Count)
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
