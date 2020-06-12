using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    class Jugar
    {
        Persona jugador_1; 
        Persona jugador_2;
        public Jugar(Persona jugador1, Persona jugador2)
        {
            jugador_1 = jugador1;
            jugador_2= jugador2;
        }
        public void Comenzar_Juego(IPasos juego)
        {
            Console.WriteLine("Empezamos a  jugar");
            List<int> cartas =juego.Mezclar_Maso();
            Console.WriteLine("Se repartio las cartas ");
            juego.Repartir_cartas(cartas);
            Console.WriteLine("Se inicio el juego");
            juego.Jugar_Mano();
            //me quedo sin cartas termina el juego
            Persona ganador = juego.Existe_Jugador(jugador_1, jugador_2);
            Console.WriteLine("El ganador es "+ganador);

        }
    }
}
