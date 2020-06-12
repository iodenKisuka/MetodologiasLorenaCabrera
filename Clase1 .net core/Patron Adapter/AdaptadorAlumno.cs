using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    class AdaptadorAlumno : Student
    {
        public IcomponenteAlumno estudiante;
      

         public AdaptadorAlumno(IcomponenteAlumno estudiante1)
         {

             this.estudiante = estudiante1;
         }

        public bool equals(Student student)
        {
            AdaptadorAlumno alumno = (AdaptadorAlumno)student;
            return estudiante.SosIgual(alumno.estudiante);
        }

        public string getName()
        {
            return estudiante.GetNombre();
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
            estudiante.CalificacionI = score;
        }

        public string showResult()
        {
            return estudiante.MostrarCalificacion();
        }

        public int yourAnswerIs(int question)
        {
            return estudiante.ResponderPregunta(question) ;
        }
    }
}
