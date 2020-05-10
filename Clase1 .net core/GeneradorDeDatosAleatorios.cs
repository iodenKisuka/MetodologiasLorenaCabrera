using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    class GeneradorDeDatosAleatorios
    {
        static Random aleatorio = new Random();
        public static int numeroAleatorio( int max)
        {
            return aleatorio.Next(0, max);
        }

        public static string stringAleatorio(int cant) {

            string Textoaleatorio="";
            string listaLetras = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int x=0; x<cant;x++)
            {
                Textoaleatorio =Textoaleatorio+listaLetras[aleatorio.Next(0, listaLetras.Length-1)];
            }

            return Textoaleatorio;
        }
    }
}
