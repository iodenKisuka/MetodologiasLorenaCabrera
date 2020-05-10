using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    class Pila : IColeccionableTP
    {
        Stack<IComparableP> pilas= new Stack<IComparableP>();

        public int Cuantos()
        {
           return pilas.Count;
        }

        public IComparableP Minimo()
        {
            Stack<IComparableP> pila_copia;
            pila_copia = Clonar();
            IComparableP min = pila_copia.Pop();
            while (pila_copia.Count > 0)
            {
                IComparableP comparar = pila_copia.Pop();
                if (comparar.SosMenor(min))
                {
                    min = comparar;
                }
            }
            return min;
        }

        public IComparableP Maximo()
        {
            Stack<IComparableP> pilas_copia2;
            pilas_copia2 = Clonar();
            IComparableP max;
         
                max = pilas_copia2.Pop();

                while (pilas_copia2.Count > 0)
                {
                    IComparableP comparar = pilas_copia2.Pop();

                    if (comparar.SosMayor(max))
                    {
                        max = comparar;
                    }

                }
             
            return max;
          
        }

        public void Agregar(IComparableP objeto)
        {
            pilas.Push(objeto);
        }

        public bool Contiene(IComparableP objeto)
        {
            Stack<IComparableP> pila_copia3;
            pila_copia3 = Clonar();
            bool aviso = false;
            while (pila_copia3.Count > 0)
            {
                IComparableP comparar = pila_copia3.Pop();

                if (comparar.SosIgual(objeto))
                {
                    aviso = true;
                }

            }
            return aviso;
        }

        //EJERCICIO  5
      /**  public void Llenar(IColeccionableTP coleccionable) {
            Random rnd = new Random();
            int valor_elegido_al_azar=rnd.Next(0, 100);
            for (int x = 1; x <= 20; x++){
                IComparableP comparable=new Numero(valor_elegido_al_azar);
                //IColeccionableTP coleccionable = new Pila();
                coleccionable.Agregar(comparable);
            }
        } **/



        public Stack<IComparableP> Clonar()
        {
            Stack<IComparableP> pila_clon = new Stack<IComparableP>();
            Stack<IComparableP> pila_clon2 = new Stack<IComparableP>();
            int total = pilas.Count;
            for (int x = 0; x < total; x++)
            {
                pila_clon.Push(pilas.Peek());
                pila_clon2.Push(pilas.Pop());
               
            }
            pilas = pila_clon2;
            return pila_clon;
        }

        public Interador iterador()
        {
            return new Clase_implementacion_ITERADOR_Pila(Clonar());
        }


        //EJERCICIO 6
        /** public void Informar(IColeccionableTP coleccionable)
         {
             Console.WriteLine(coleccionable.Cuantos());
             Console.WriteLine(coleccionable.Minimo());
             Console.WriteLine(coleccionable.Maximo());
             int num = int.Parse(Console.ReadLine());
           //IColeccionableTP coleccionable = new Pila();
             IComparableP compara = new Numero(num);
         } **/

    }
}
