using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    class AdaptadorAlumno : Student
    {
        public Alumno estudiante;

         public AdaptadorAlumno(Alumno estudiante)
         {
             this.estudiante = estudiante;
         }

        public bool equals(Student student)
        {
            AdaptadorAlumno alumno = (AdaptadorAlumno)student;
            return estudiante.SosIgual(alumno.estudiante);
        }

        public string getName()
        {
            return estudiante.GetNombre;
        }

        public bool greaterThan(Student student)
        {
            AdaptadorAlumno alumno = (AdaptadorAlumno)student;
            return estudiante.SosMayor(alumno.estudiante);
        }

        public bool lessThan(Student student)
        {
            AdaptadorAlumno alumno = (AdaptadorAlumno)student;
            return estudiante.SosMenor(alumno.estudiante);
        }

        public void setScore(int score)
        {
            estudiante.UltimaCalificacion = score;
            estudiante.mostrarCalificación();
        }

        public string showResult()
        {
            return estudiante.mostrarCalificación();
        }

        public int yourAnswerIs(int question)
        {
            return estudiante.responderPregunta(question) ;
        }
    }
}
