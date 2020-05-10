using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Clase1_.net_core.Patron_Factory_Method
{
    class FabricaCreadorIComprable
    {
        public const int CrearNumero = 0;
        public const int CrearAlumno = 1;
        public const int Crearvendedor = 2;
        public static int valorMaximo;
        public static IComparableP CrearAleatorio(int tipo)
        {
            switch (tipo)
            {
                case CrearAlumno:
                    return new FabricaDeAlumnos().CrearAlumnoAlAzar();
                case CrearNumero:
                    valorMaximo = 100;
                    return new FabricaDeNumeros().CrearNumeroAlAzar(valorMaximo);
                case Crearvendedor:
                    return new FabricaVendedor().CrearVendedorAlAzar();
                default:
                    return null;
            }
        }
        public static IComparableP CrearPorTeclado(int tipo)
        {
            switch (tipo)
            {
                case CrearAlumno:
                    return new FabricaDeAlumnos().CrearAlumnoPorTeclado();
                case CrearNumero:
                    return new FabricaDeNumeros().CrearNumeroPorTeclado();
                case Crearvendedor:
                    return new FabricaVendedor().CrearVendedorPorTeclado();
                default:
                    return null;
            }
        }

    }
}
