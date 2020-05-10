using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    interface IEstrategia_Comparar_Alumno
    {
        public bool SosIgual(IComparableP comparable, IComparableP comparable2);
        public bool SosMenor(IComparableP comparable, IComparableP comparable2);
        public bool SosMayor(IComparableP comparable, IComparableP comparable2);

    }
}
