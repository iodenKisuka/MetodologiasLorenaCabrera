using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core.Patron_Command
{
    class OrdenLlegaAlumno : IOrdenEnAula2
    {
        Aula nuevaAula;
        public OrdenLlegaAlumno(Aula aula)
        {
            nuevaAula = aula;
        }
        public void ejecutar(IColeccionableTP coleccionable)
        {
            Interador interador = coleccionable.iterador();
            while (!interador.fin())
            {
                IComparableP elemento = interador.actual();
                interador.siguiente();
                nuevaAula.NuevoAlumno(((Alumno)elemento));
            }
        }
    }
}
