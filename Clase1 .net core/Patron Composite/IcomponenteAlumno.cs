using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    interface IcomponenteAlumno: IComparableP,InterfaceAlumnoProxy
    {
        public double CalificacionI { get; set; }
        string GetNombre();
        int Responder();
        double SetCalificacion();
       string MostrarCalificacion();
        /**bool SosIgual(IComparableP variable);
        bool SosMenor(IComparableP variable);
        bool SosMayor(IComparableP variable);   **/


    }
}
