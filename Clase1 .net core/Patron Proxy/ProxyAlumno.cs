using Clase1_.net_core.Patron_Factory_Method;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core.Patron_Proxy
{
    class ProxyAlumno: Alumno
    {
        Alumno AlumnoReal;

        public  Alumno RespondioLAPregunta(int pregunta,int nota)
        {
            if (nota ==pregunta % 3)
            {
               return (AlumnoMuyEstudioso)FabricaCreadorIComprable.CrearAleatorio(FabricaCreadorIComprable.CrearAlumnoEstudioso) ;
            }
            else
            {
                return (Alumno)FabricaCreadorIComprable.CrearAleatorio(FabricaCreadorIComprable.CrearAlumno);
            }

            //return pregunta % 3;
        }

    }
}
