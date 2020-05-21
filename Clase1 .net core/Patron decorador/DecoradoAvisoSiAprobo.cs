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
            string SaberSiAprobo;
            if (alumnoAdaptado.UltimaCalificacion>=7)
            {
                SaberSiAprobo = " Promocion";
            }
            if (alumnoAdaptado.UltimaCalificacion<7 & alumnoAdaptado.UltimaCalificacion>4)
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
