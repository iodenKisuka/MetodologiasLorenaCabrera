using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    interface IPasos
    {
        List<int> Mezclar_Maso();
        void Repartir_cartas(List<int> maso);
        void Jugar_Mano();
        Persona Existe_Jugador(Persona J1, Persona J2);

    }
}
