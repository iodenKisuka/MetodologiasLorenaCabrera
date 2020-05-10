using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    class AdaptadorAlumno:Alumno
    {
       public Student estudiante;

        public AdaptadorAlumno(Student estudiante)
        {
            this.estudiante = estudiante;
        }

        public override int responderPregunta(int pregunta)
        {
            return estudiante.yourAnswerIs(pregunta);
        }

        public override string mostrarCalificación()
        {
            return estudiante.showResult();
        }
        public override bool SosIgual(IComparableP variable)
        {
            return estudiante.equals((Student) variable);
        }
        public override bool SosMenor(IComparableP variable)
        {
            return estudiante.lessThan((Student) variable);
        }
        public override bool SosMayor(IComparableP variable)
        {
           return estudiante.greaterThan((Student)variable);
        }

    }
}
