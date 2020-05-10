using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Clase1_.net_core
{
    class Diccionario : IColeccionableTP{

        public Dictionary<IComparableP, object> diccionario = new Dictionary<IComparableP, object>();

        public void Agregar(Clave_Valor clave) {
            if (diccionario.Count>0) {
                if (!diccionario.ContainsKey(clave.Clave) ){
                    diccionario.Add(clave.Clave, clave.Objetoasociado);
                }
                else
                {
                    diccionario[clave.Clave] = clave.Objetoasociado;
                }
            }
            else
            {

                diccionario.Add(clave.Clave, clave.Objetoasociado);
            }
            /**     FORMAS DE RECORRER UN DICCIONARIO
                        foreach (KeyValuePair<IComparableP, object> result in nuevoDiccinario.diccionario)
                        {
                            Console.WriteLine(string.Format("Key-{0}:Value-{1}", result.Key, result.Value));
                        }
                        foreach (var economica in nuevoDiccinario.diccionario)
                        {
                            Console.WriteLine("{0} : {1}", economica.Key, economica.Value);
                        } **/

        }

        public object valorDe(Clave_Valor clave)
        {

            if (diccionario.ContainsKey(clave.Clave))
            {
                return diccionario[clave.Clave];
            }
            else
            {
                Console.WriteLine("No contiene elemento");
                return null;
            }

        }
       
        public void Agregar(IComparableP objeto)
        {
            if (diccionario.Count > 0)
            {
                if (!diccionario.ContainsKey(objeto))
                {
                    diccionario.Add(objeto, objeto);
                }
                else
                {
                    diccionario[objeto] = objeto;
                }
            }
            else
            {

                diccionario.Add(objeto, objeto);
            }
        }

        public bool Contiene(IComparableP objeto)
        {
            return diccionario.ContainsValue(objeto);
        }

        public int Cuantos()
        {
            return diccionario.Count;
        }

        public IComparableP Minimo()
        {
           object primer_tipo_menor = diccionario.Values;
            foreach (object valor_que_cambia in diccionario.Values)
            {
                if (valor_que_cambia.GetType() == primer_tipo_menor.GetType())
                {
                    if (((IComparableP)valor_que_cambia).SosMenor(((IComparableP)primer_tipo_menor)))
                    {
                        primer_tipo_menor = valor_que_cambia;
                    }
                }
            }

            Console.WriteLine("Tomamos el primer tipo de dato ingresado para seleccionar sobre ese tipo cual es el menor");
            Console.WriteLine("El tipo de dato comparado es " + primer_tipo_menor.GetType());
            return ((IComparableP)primer_tipo_menor);



        }

        public IComparableP Maximo()
        {
            object primer_tipo_mayor = diccionario.Values;
            foreach (object valor_que_cambia in diccionario.Values)
            {
                if (valor_que_cambia.GetType() == primer_tipo_mayor.GetType())
                {
                    if (((IComparableP)valor_que_cambia).SosMayor(((IComparableP)primer_tipo_mayor)))
                    {
                        primer_tipo_mayor = valor_que_cambia;
                    }
                }
            }

            Console.WriteLine("Tomamos el primer tipo de dato ingresado para seleccionar sobre ese tipo cual es el menor");
            Console.WriteLine("El tipo de dato comparado es " + primer_tipo_mayor.GetType());
            return ((IComparableP)primer_tipo_mayor);

        }


        public Interador iterador()
        {
            return new Clase_implementacion_ITERADOR_Diccionario(diccionario);
        }

    }
}
