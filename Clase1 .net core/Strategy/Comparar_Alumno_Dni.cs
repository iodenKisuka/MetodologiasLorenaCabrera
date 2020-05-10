using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    class Comparar_Alumno_Dni : IEstrategia_Comparar_Alumno
    {
        public bool SosIgual(IComparableP comparable, IComparableP comparable2)
        {
            if (((Alumno)comparable).GetDni == ((Alumno)comparable2).GetDni)
                return true;
            else
                return false;
        }

        public bool SosMayor(IComparableP comparable, IComparableP comparable2)
        {
            if (((Alumno)comparable2).GetDni < ((Alumno)comparable).GetDni)
                return true;
            else
                Console.WriteLine(((Alumno)comparable2).GetDni+" compare "+((Alumno)comparable).GetDni);
                return false;
        }

        public bool SosMenor(IComparableP comparable, IComparableP comparable2)
        {
            if (((Alumno)comparable2).GetDni > ((Alumno)comparable).GetDni)
                return true;
            else
                return false;
        }
    }
}
