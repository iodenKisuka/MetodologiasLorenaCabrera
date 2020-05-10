using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

namespace Clase1_.net_core
{
    class ContextAlumnoStegy : IEstrategia_Comparar_Alumno
    {
        public IEstrategia_Comparar_Alumno estrategia;

        public ContextAlumnoStegy(IEstrategia_Comparar_Alumno estrategia)
        {

            this.estrategia = estrategia;
        }

        public bool SosIgual(IComparableP comparable, IComparableP comparable2)
        {
            return this.estrategia.SosIgual(comparable, comparable2);
        }

        public bool SosMayor(IComparableP comparable, IComparableP comparable2)
        {
           
            return this.estrategia.SosMayor(comparable, comparable2);
        }

        public bool SosMenor(IComparableP comparable, IComparableP comparable2)
        {
            return this.estrategia.SosMenor(comparable, comparable2);
        }
    }
}
