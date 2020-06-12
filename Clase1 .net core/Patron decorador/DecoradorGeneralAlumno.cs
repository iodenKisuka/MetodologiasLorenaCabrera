using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core.Patron_decorador
{
    abstract class DecoradorGeneralAlumno
    {
        
        protected string Texto;
        protected IcomponenteAlumno alumnoAdaptado;

        protected DecoradorGeneralAlumno(Student alumno)
        {
            alumnoAdaptado = ((AdaptadorAlumno)alumno).estudiante;
            Texto = alumnoAdaptado.GetNombre() + " " + alumnoAdaptado.SetCalificacion();
        }

        public abstract string MostrarCalificacionStudiante();

    }
}
