using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core.Patron_decorador
{
    class DecoradorAterisco : DecoradorGeneralAlumno
    {
        public DecoradorAterisco(Student alumno) : base(alumno)
        {
            alumnoAdaptado = ((AdaptadorAlumno)alumno).estudiante;
        }

        public override string MostrarCalificacionStudiante()
        {
            string TextoAdaptado= "*********************************"+"\n * "+Texto+" *"+ "\n *********************************";
            return TextoAdaptado;
        }
    }
}
