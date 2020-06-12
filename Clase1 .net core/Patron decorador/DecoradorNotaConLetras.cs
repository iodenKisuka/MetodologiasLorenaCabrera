using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core.Patron_decorador
{
    class DecoradorNotaConLetras : DecoradorGeneralAlumno
    {
        public DecoradorNotaConLetras(Student alumno) : base(alumno)
        {

            alumnoAdaptado = ((AdaptadorAlumno)alumno).estudiante;
        }

        public override string MostrarCalificacionStudiante()
        {
            string calificacion = "";
            switch (alumnoAdaptado.SetCalificacion())
            {
                case 1:
                    calificacion = " UNO";
                    break;
                case 2:
                    calificacion = " DOS";
                    break;
                case 3:
                    calificacion = " TRES";
                    break;
                case 4:
                    calificacion = " CUATRO";
                    break;
                case 5:
                    calificacion = " CINCO";
                    break;
                case 6:
                    calificacion = " SEIS";
                    break;
                case 7:
                    calificacion = " SIETE";
                    break;
                case 8:
                    calificacion = " OCHO";
                    break;
                case 9:
                    calificacion = " NUEVE";
                    break;
                case 10:
                    calificacion = " DIEZ";
                    break;
                default:
                    calificacion = " La calificacion no es valida";
                    break;
            }


            string textoAdaptado = Texto +calificacion;
            return textoAdaptado;
        }
    }
}
