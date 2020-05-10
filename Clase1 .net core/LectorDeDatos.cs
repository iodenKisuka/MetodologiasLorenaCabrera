using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    class LectorDeDatos
    {
        public static int numeroPorTeclado()
        {
            Console.WriteLine("Ingrese un numero");
            int num = int.Parse(Console.ReadLine());
            return num;  
        }
        public static string stringPorTeclado()
        {
            Console.WriteLine("Ingrese texto");
            string textoingresado=Console.ReadLine();
            return textoingresado;
        }
    }
}
