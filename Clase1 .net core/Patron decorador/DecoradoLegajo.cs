using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core.Patron_decorador
{
    class DecoradoLegajo : DecoradorGeneralAlumno
    {
        public DecoradoLegajo(Student alumno) : base(alumno)
        {
             alumnoAdaptado = ((AdaptadorAlumno)alumno).estudiante;
            
        }

        public override string MostrarCalificacionStudiante()
        {
            Alumno alumnoA = (Alumno)alumnoAdaptado;
            string textoAdaptado = Texto.Substring(0,Texto.Length-2) + " (" + alumnoA.GetLegajo + "/" + Texto.Substring(Texto.Length - 2) + ") " + Texto.Substring(Texto.Length - 2);
            return textoAdaptado;
        }
    }
}
