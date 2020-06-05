using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    interface IcomponenteAlumno
    {
        string GetNombre();
        int Responder();
        double SetCalificacion();
       string MostrarCalificacion();
        bool SosIgual(Alumno alumno);
        bool SosMenor(Alumno alumno);
        bool SosMayor(Alumno alumno);


    }
}
