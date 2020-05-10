using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Clase1_.net_core.Patron_Factory_Method
{
    class FabricaVendedor
    {
        private IComparableP vendedor;


        
        public IComparableP CrearVendedorAlAzar()
        {
            int max = 100;
            vendedor = new Vendedor(GeneradorDeDatosAleatorios.stringAleatorio(4), GeneradorDeDatosAleatorios.numeroAleatorio(max), GeneradorDeDatosAleatorios.numeroAleatorio(max), GeneradorDeDatosAleatorios.numeroAleatorio(max));
            return vendedor;
        }

        public IComparableP CrearVendedorPorTeclado()
        {
            vendedor = new Vendedor(LectorDeDatos.stringPorTeclado(), LectorDeDatos.numeroPorTeclado(), LectorDeDatos.numeroPorTeclado(), LectorDeDatos.numeroPorTeclado());
            return vendedor;
        }

    }
}
