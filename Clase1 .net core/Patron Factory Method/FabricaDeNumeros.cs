using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    class FabricaDeNumeros
    {
        IComparableP numero;
        public IComparableP CrearNumeroAlAzar(int maximo)
        {
            numero = new Numero(GeneradorDeDatosAleatorios.numeroAleatorio(maximo));
            return numero;
      }

        public IComparableP CrearNumeroPorTeclado()
        {
            numero = new Numero(LectorDeDatos.numeroPorTeclado());
            return numero;
        }

    }
}
