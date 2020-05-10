using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    class Comparar_Alumno_Legajo : IEstrategia_Comparar_Alumno
    {
        public bool SosIgual(IComparableP comparable, IComparableP comparable2)
        {
            if (((Alumno)comparable).GetLegajo== ((Alumno)comparable2).GetLegajo)
                return true;
            else
                return false;
        }

        public bool SosMayor(IComparableP comparable, IComparableP comparable2)
        {
            if (((Alumno)comparable).GetLegajo > ((Alumno)comparable2).GetLegajo)
                return true;
            else
                return false;
        }

        public bool SosMenor(IComparableP comparable, IComparableP comparable2)
        {
            if (((Alumno)comparable).GetLegajo < ((Alumno)comparable2).GetLegajo)
                return true;
            else
                return false;
        }
    }
}
