using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core 
{
    class Clave_Valor 
    {
        private IComparableP clave;
        private object objetoasociado;

        public Clave_Valor(IComparableP clave, object objetoasociado)
        {
            Objetoasociado = objetoasociado;
            Clave = clave;
        }
        //public Clave_Valor() { }

        public object Objetoasociado { get => objetoasociado; set => objetoasociado = value; }
        public IComparableP Clave { get => clave; set => clave = value; }
    }
}
