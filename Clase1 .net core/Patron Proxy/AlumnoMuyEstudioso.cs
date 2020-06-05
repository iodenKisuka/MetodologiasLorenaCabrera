using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    class AlumnoMuyEstudioso: Alumno
    {
        public AlumnoMuyEstudioso(string n, int d, int l, int p) : base(n, d, l, p)
        {
        }

        public  int ResponderPregunta(int pregunta)
        {
            return pregunta%3;
        }
    }
}
