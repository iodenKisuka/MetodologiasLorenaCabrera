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
        public const int CrearAlumnoEstudioso = 2;
        public const int Crearvendedor = 3;
        public const int CrearGrupoAlumnos = 4;
        public const int CrearGrupoAlumnosProxy = 5;
        public static int valorMaximo;



        public static IComparableP CrearAleatorio(int tipo)
        {
            switch (tipo)
            {
                case CrearAlumno:
                    return new FabricaDeAlumnos().CrearAlumnoAlAzar();
                case CrearAlumnoEstudioso:
                    return new FabricaDeAlumnoEstudioso().CrearAlumnoAlAzar();
                case CrearNumero:
                    valorMaximo = 100;
                    return new FabricaDeNumeros().CrearNumeroAlAzar(valorMaximo);
                case Crearvendedor:
                    return new FabricaVendedor().CrearVendedorAlAzar();
                case CrearGrupoAlumnos:
                    return new FabricaDe5Alumnos_compuesto().CrearAlumnosAlAzar();
                case CrearGrupoAlumnosProxy:
                    return new FabricaGrupoProxy().CrearAlumnosAlAzar();
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
                case CrearAlumnoEstudioso:
                    return new FabricaDeAlumnoEstudioso().CrearAlumnoPorTeclado();
                case CrearNumero:
                    return new FabricaDeNumeros().CrearNumeroPorTeclado();
                case Crearvendedor:
                    return new FabricaVendedor().CrearVendedorPorTeclado();
                case CrearGrupoAlumnos:
                    return new FabricaDe5Alumnos_compuesto().CrearAlumnosPorTeclado();
                case CrearGrupoAlumnosProxy:
                    return new FabricaGrupoProxy().CrearAlumnosPorTeclado();

                default:
                    return null;
            }
        }

    }
}
