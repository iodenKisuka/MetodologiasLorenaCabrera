using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core.Patron_Command
{
    class OrdenInicio : IOrdenEnAula1
    {
        private Aula aula;
        public OrdenInicio(Aula aulaR)
        {
            aula = aulaR;
        }
        public void Ejecutar()
        {
            aula.Comenzar();
        }

        
    }
}
