using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core.Patron_decorador
{
    class DecoradoAvisoSiAprobo : DecoradorGeneralAlumno
    {
        public DecoradoAvisoSiAprobo(Student alumno) : base(alumno)
        {
            alumnoAdaptado = ((AdaptadorAlumno)alumno).estudiante;
        }

        public override string MostrarCalificacionStudiante()
        {
           // Alumno alumnoA = (Alumno)alumnoAdaptado;
            string SaberSiAprobo;
            if (alumnoAdaptado.CalificacionI>=7)
            {
                SaberSiAprobo = " Promocion";
            }
            if (alumnoAdaptado.CalificacionI<7 & alumnoAdaptado.CalificacionI>4)
            {
                SaberSiAprobo = " Aprobado";
            }
            else
            {
                SaberSiAprobo = " Desaprobado";
            }


            string textoAdaptado=Texto+SaberSiAprobo;
            return textoAdaptado;
        }
    }
}
