using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    class Juego2 : IPasos
    {
        int jugador1=0;
        int jugador2=0;
        List<int> cartasJ1;
        List<int> cartasJ2;

        

        public Persona Existe_Jugador(Persona J1, Persona J2)
        {
            if (jugador1 > jugador2)
            {
                return J1;
            }
            else
            {
                return J2;
            }
        }

        public void Jugar_Mano()
        {

                for (int cartajugada = 0; cartajugada < 6; cartajugada++)
                {
                    jugador1=jugador1+cartasJ1[cartajugada];
                    jugador2=jugador2+ cartasJ1[cartajugada];
                }

        }

        public List<int> Mezclar_Maso()
        {
            List<int> maso = new List<int>();
            Random num_randon = new Random();
            maso.Add(12);
            do
            {
                bool Sin_repetir = true;
                int numero_aleatorio = num_randon.Next(1, 12);
                for (int posicion = 1; posicion < maso.Count; posicion++)
                {
                    if (numero_aleatorio == maso[posicion])
                    {
                        Sin_repetir = false;
                    }

                }
                if (Sin_repetir)
                {
                    maso.Add(numero_aleatorio);
                }

            } while (maso.Count < 12);

            return maso;
        }

        public void Repartir_cartas(List<int> maso)
        {
            cartasJ1 = maso.GetRange(0, 6);
            cartasJ2 = maso.GetRange(5, 6);
        }
    }
}
