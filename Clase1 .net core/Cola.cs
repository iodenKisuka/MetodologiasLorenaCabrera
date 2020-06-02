using Clase1_.net_core.Patron_Command;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    class Cola: IColeccionableTP, IOrdenable
    {
        private Queue<IComparableP> colas = new Queue<IComparableP>();

        public void Agregar(IComparableP objeto)
        {
            colas.Enqueue(objeto);
        }

        public bool Contiene(IComparableP objeto)
        {
            Queue<IComparableP> colas_copia3;
            colas_copia3 = Clonar();
            bool aviso = false;
            while (colas_copia3.Count > 0)
            {
                IComparableP comparar = colas_copia3.Dequeue();

                if (comparar.SosIgual(objeto))
                {
                    aviso=true;
                }

            }
            return aviso;
        }
        public int Cuantos()
        {
            return colas.Count;
        }

        public IComparableP Maximo()
        {
           
            Queue<IComparableP> colas_copia2;
            colas_copia2 = Clonar();
            IComparableP max= colas_copia2.Dequeue();
            
            while (colas_copia2.Count>0)
            {
                IComparableP comparar = colas_copia2.Dequeue();
               
                if (comparar.SosMayor(max))
                {
                    max = comparar;
                }

            }
            
            return max;
        }

        public IComparableP Minimo()
        {
            Queue<IComparableP> colas_copia;
            colas_copia = Clonar();
            IComparableP min = colas_copia.Dequeue();
            while (colas_copia.Count> 0)
            {
                IComparableP comparar =colas_copia.Dequeue();
                if (comparar.SosMenor(min)){
                    min = comparar;
                }
            }
            return min;
        }
        public Queue<IComparableP> Clonar()
        {
            Queue<IComparableP> cola_copia = new Queue<IComparableP>();
            int total = colas.Count;
            for (int x = 0; x < total; x++)
            {
                colas.Enqueue(colas.Peek());
                //IComparableP comparar = colas.Dequeue();

                cola_copia.Enqueue(colas.Dequeue());
               /** cola_copia.Enqueue(comparar);
                int texto = ((Numero)(comparar)).Valor;
                Console.WriteLine("elemento " + texto); **/
            }

            return cola_copia;
        }

        public Interador iterador()
        {
            return new Clase_implementacion_ITERADOR_Cola(Clonar());
        }


        //IMPLEMENTACION DE IORDEABLE
        public void SetOrdenInicio(IOrdenEnAula1 orden)
        {
            if (Cuantos()==1)
            {   //Comente esto por las dudas 
                /** Queue<IComparableP> colas_copia4;
                colas_copia4 = Clonar();
                Aula aula = (Aula)colas_copia4.Peek();
                orden = new OrdenInicio(aula); **/
                orden.Ejecutar();
            }
        }

        public void SetOrdenLLegaAlumno(IOrdenEnAula2 orden2)
        {
            Cola colaActual = new Cola();
            colaActual.colas = colas;
            orden2.ejecutar(colaActual);
        }

        public void SetOrdenAulaLlena(IOrdenEnAula1 orden)
        {
            if (Cuantos()==40)
            {
                orden.Ejecutar();
            }
        }


        //EJERCICIO  5
        /** public void Llenar(IColeccionableTP coleccionable)
         {
             Random rnd = new Random();
             int valor_elegido_al_azar = rnd.Next(0, 100);
             for (int x = 1; x <= 20; x++)
             {
                 IComparableP comparable = new Numero(valor_elegido_al_azar);
                 //IColeccionableTP coleccionable = new Cola();

                 coleccionable.Agregar(comparable);
                
             }
         }**/

    }
}
