using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    class Conjunto : IColeccionableTP
    {
        // HashSet<IComparableP> Lista_conjunto= new HashSet<IComparableP> ();
       public List<IComparableP> Listacomparable = new List<IComparableP>();

        public void Agregar(IComparableP objeto)
        {
            if (Listacomparable.Count > 0)
            {
                if (!Contiene(objeto)) {
                    Listacomparable.Add(objeto);
                }
            }
            else
            {
                Listacomparable.Add(objeto);
            }
        }

        public bool Contiene(IComparableP objeto)
        {
            bool esta = false;
            foreach (IComparableP num in Listacomparable)
            {

                if (objeto.GetType() == num.GetType())
                {
                    if (num.SosIgual(objeto))
                    {
                        esta = true;
                    }
                }
            }
            return esta;
        }

        public int Cuantos()
        {
            return Listacomparable.Count;
        }

        

        public IComparableP Maximo()
        {
            int contador = 1;
            IComparableP primer_tipo_mayor = Listacomparable[1];
            while (contador<Listacomparable.Count)
            {
                IComparableP valor_que_cambia= Listacomparable[contador];
               
                if (valor_que_cambia.GetType() == primer_tipo_mayor.GetType())
                {
                    if (valor_que_cambia.SosMayor(primer_tipo_mayor))
                    {
                        primer_tipo_mayor = valor_que_cambia;
                    }
                }

                contador++;
            }
            Console.WriteLine("Tomamos el primer tipo de dato ingresado para seleccionar sobre ese tipo cual es el mayor");
            Console.WriteLine("El tipo de dato comparado es " + (primer_tipo_mayor.GetType()));
            return primer_tipo_mayor;
        }

        public IComparableP Minimo()
        {
            int contador = 1;
            IComparableP primer_tipo_menor = Listacomparable[1];
            while (contador < Listacomparable.Count)
            {
                IComparableP valor_que_cambia = Listacomparable[contador];

                if (valor_que_cambia.GetType() == primer_tipo_menor.GetType())
                {
                    if (valor_que_cambia.SosMenor(primer_tipo_menor))
                    {
                        primer_tipo_menor = valor_que_cambia;
                    }
                }

                contador++;
            }
            Console.WriteLine("Tomamos el primer tipo de dato ingresado para seleccionar sobre ese tipo cual es el menor");
            Console.WriteLine("El tipo de dato comparado es "+ primer_tipo_menor.GetType());
            return primer_tipo_menor;
        }

        public Interador iterador()
        {
           return new Clase_implementacion_ITERADOR_Conjunto(Listacomparable);
        }
    }
}
