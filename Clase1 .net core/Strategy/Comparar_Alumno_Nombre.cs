using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    class Comparar_Alumno_GetNombre : IEstrategia_Comparar_Alumno
    {
        public bool SosIgual(IComparableP IComparable, IComparableP IComparable2)
        {
            if (((Alumno)IComparable).GetNombre.CompareTo(((Alumno)IComparable2).GetNombre) == 0)
            return true;
            else
                return false;
        }

        public bool SosMayor(IComparableP IComparable, IComparableP IComparable2)
        {
            if (((Alumno)IComparable2).GetNombre.CompareTo(((Alumno)IComparable).GetNombre)==1)
                return true;
            else
                return false;
        }

        public bool SosMenor(IComparableP IComparable, IComparableP IComparable2)
        {
            if ((((Alumno)IComparable2).GetNombre).CompareTo(((Alumno)IComparable).GetNombre) == -1)
                return true;
            else
                return false;
        }
    }
}
