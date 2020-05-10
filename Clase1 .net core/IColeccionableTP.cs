using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    interface IColeccionableTP
    {
        int Cuantos();
        IComparableP Minimo();
        IComparableP Maximo();
        void Agregar(IComparableP objeto);
        bool Contiene(IComparableP objeto);

        public Interador iterador();


    }
}
