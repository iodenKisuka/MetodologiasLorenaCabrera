using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    class Numero : IComparableP
    {
        public Numero(int valor)
        {
            this.Valor = valor;
        }
        public Numero()
        {

        }
        public int Valor { get; set; }

        public bool SosIgual(IComparableP variable)
        {
            Numero comparable = (Numero)variable;
            if (comparable.Valor == this.Valor)
                return true;
            else
                return false;
        }

        public bool SosMayor(IComparableP variable)
        {
            Numero comparable = (Numero)variable;
            if (comparable.Valor < this.Valor)
                return true;
            else
                return false;

        }

        public bool SosMenor(IComparableP variable)
        {
            Numero comparable = (Numero)variable;
            if (comparable.Valor > this.Valor)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            // return base.ToString();
            return Valor.ToString();
        }
    }
}
