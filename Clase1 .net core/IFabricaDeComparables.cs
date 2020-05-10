using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    interface IFabricaDeComparables
    {
        IComparableP crearAleatorio();
        IComparableP crearPorTeclado();

    }
}
