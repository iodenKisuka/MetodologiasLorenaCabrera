using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    interface IOrdenable
    {
        void SetOrdenble(IOrdenEnAula1 orden);
        void SetOrdenLLegaAlumno(IOrdenEnAula2 orden2);
        void SetOrdenAulaLlena(IOrdenEnAula1 orden);

    }
}
