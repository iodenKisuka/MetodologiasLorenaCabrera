using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    class Aula
    {
        Teacher teacher;

        public void Comenzar()
        {
            teacher = new Teacher();
            Console.WriteLine("Ya se instacion un teacher");
        }

        public void NuevoAlumno(Alumno alumno)
        {
            AdaptadorAlumno estudiante = new AdaptadorAlumno(alumno);
            teacher.goToClass(estudiante);
        }
        public void ClaseLista()
        {
            teacher.teachingAClass();
        }

    }
}
