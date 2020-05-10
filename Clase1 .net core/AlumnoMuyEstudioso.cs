using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    class AlumnoMuyEstudioso: Alumno
    {
        public override int responderPregunta(int pregunta)
        {
            return pregunta%3;
        }
    }
}
