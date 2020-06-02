using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    class OrdenAulaLlena : IOrdenEnAula1
    {
        private Aula aula;
        public OrdenAulaLlena(Aula aulaR)
        {
            aula = aulaR;
        }
        public void Ejecutar()
        {
            aula.ClaseLista();
        }
    }
}
