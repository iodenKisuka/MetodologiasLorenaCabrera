using Clase1_.net_core.Patron_Factory_Method;
using System;
using System.Collections.Generic;

namespace Clase1_.net_core
{
    class Program
    {
        static void Main(string[] args)
        {

            //  ContextAlumnoStegy estrategiaalimno = new ContextAlumnoStegy(new Comparar_Alumno_Dni());
            // estrategiaalimno.SosIgual();
            /** //Ejercicio 7
             Console.WriteLine("iniciando programa");
             IColeccionableTP pila = new Pila();
             IColeccionableTP cola = new Cola();
             Llenar(pila);
             Console.WriteLine("ingreso a llenar pila");
             Llenar(cola);
             Informar(pila);
             Console.WriteLine("Datos de la Cola");
             Informar(cola);

             //Ejercicio 8
             Console.WriteLine("Datos de la COLECCION");
             IColeccionableTP pila2 = new Pila();
             IColeccionableTP cola2 = new Cola();
             ColeccionMultiple multiple = new ColeccionMultiple(pila2, cola2);
             Llenar(multiple.pila_colecion);
             Llenar(multiple.cola_coleccion);


             Console.WriteLine("Datos entrando a COLECCION");
             Informar(multiple); **/

            /*   //Ejercicio 13
               Console.WriteLine("Datos de la COLECCION");
               IColeccionableTP pila3 = new Pila();
               IColeccionableTP cola3 = new Cola();
               ColeccionMultiple multiple2 = new ColeccionMultiple(pila3, cola3);
               LlenarPersonas(multiple2.pila_colecion);
               LlenarPersonas(multiple2.cola_coleccion);
               Informar(multiple2);    **/

            //Ejercicio 17
            //Console.WriteLine("Datos de la COLECCION");
            //IColeccionableTP pila4 = new Pila();
            //IColeccionableTP cola4 = new Cola();
            //ColeccionMultiple multiple3 = new ColeccionMultiple(pila4, cola4);
            //LlenarAlumnos(multiple3.pila_colecion);
            //LlenarAlumnos(multiple3.cola_coleccion);
            //Informar(multiple3);

            /** //ejercicio 8 practica 2
             Console.WriteLine("Usando el patron interator");
             IColeccionableTP pila5 = new Pila();
             IColeccionableTP cola5 = new Cola();
             IColeccionableTP conjunto1 = new Conjunto();
             IColeccionableTP diccinario1 = new Diccionario();
             
             LlenarAlumnos(pila5);
             LlenarAlumnos(cola5);
             LlenarAlumnos(conjunto1);
             LlenarAlumnos(diccinario1);
             Console.WriteLine("Usando pila");
             ImprimirElementos(pila5);
             Console.WriteLine("Usando cola");
             ImprimirElementos(cola5);
             Console.WriteLine("Usando conjunto");
             ImprimirElementos(conjunto1);
             Console.WriteLine("Usando diccionario");
             ImprimirElementos(diccinario1);
             **/

            /* //Ejercicio 10
             IColeccionableTP pila6 = new Pila();
             LlenarAlumnos(pila6);
             ImprimirElementos(pila6);
             //CambiarEstrategia(pila6, new Comparar_Alumno_GetNombre());
             CambiarEstrategia(pila6, new Comparar_Alumno_Dni());
             Informar(pila6);*/

            IColeccionableTP conjunto2 = new Conjunto();
            LLenar(conjunto2,FabricaCreadorIComprable.CrearAlumno);
            ImprimirElementos(conjunto2);
            Informar(conjunto2, FabricaCreadorIComprable.CrearAlumno);

            //Ejercicio 4 Practica 4 reparar
        /**    Teacher profesor = new Teacher();
            for (int n = 1; n <= 10; n++)
            {
                Alumno alumno1 = new Alumno();
                AlumnoMuyEstudioso alumnoE1 = new AlumnoMuyEstudioso();
                AdaptadorAlumno alumno2 = new AdaptadorAlumno((Student)alumno1);
                AdaptadorAlumno alumnoE2 = new AdaptadorAlumno((Student)alumnoE1);
                profesor.goToClass(alumno2.estudiante);
                profesor.goToClass(alumnoE2.estudiante);

            }   **/


            // Console.WriteLine("Hello World!");
        }

        /*  //EJERCICIO  5
          public static void Llenar(IColeccionableTP coleccionable)
          {
              Random rnd = new Random();

              for (int x = 1; x <= 20; x++)
              {
                  int valor_elegido_al_azar = rnd.Next(0, 100);
                  IComparableP comparable = new Numero(valor_elegido_al_azar);
                  //IColeccionableTP coleccionable = new Pila();
                  coleccionable.Agregar(comparable);
              }

          }   **/

        /**EJERCICIO 6
        public static void Informar(IColeccionableTP coleccionable)
        {
            Console.WriteLine("Cantidad " + coleccionable.Cuantos());
            if (coleccionable.Cuantos() > 0)
            {
                // Console.WriteLine("Minimo " + ((Numero)(coleccionable.Minimo())).Valor);
                Console.WriteLine("Minimo " + coleccionable.Minimo());
                Console.WriteLine("Maximo " + coleccionable.Maximo());
                Console.WriteLine("Ingrese un numero que quiere buscar");
                int num = int.Parse(Console.ReadLine());

                //  IComparableP compara = new Numero(num);
                Sub_programa_informar(coleccionable, num);

                // IComparableP compara = new Persona("",num) ;
                // IComparableP compara;


                /*  if (coleccionable.Contiene(compara))
                  {
                      Console.WriteLine("El elemento leído está en la colección");
                  }
                  else
                  {
                      Console.WriteLine("El elemento leído NO está en la colección");
                  +++ fin de comentario
            }
            Console.WriteLine(" ");
        }

        //sub_programa
        public static void Sub_programa_informar(IColeccionableTP coleccionable, int num)
        {
            bool saber_si_ando = false;
            try
            {
                IComparableP compara = new Numero(num);
                saber_si_ando = coleccionable.Contiene(compara);
            }
            catch (Exception)
            {
                try
                {
                    IComparableP compara = new Alumno("", num, num, num);
                    saber_si_ando = coleccionable.Contiene(compara);
                    //ejercici practica 2 probando si funciona
                    //Aplicando_Estrategia_Comparar_Alumno_Ejercicio2_practica2();

                }
                catch (Exception)
                {
                    IComparableP compara = new Persona("", num);
                    saber_si_ando = coleccionable.Contiene(compara);
                }
            }
            finally
            {
                if (saber_si_ando)
                {
                    Console.WriteLine("El elemento leído está en la colección");
                }
                else
                {
                    Console.WriteLine("El elemento leído NO está en la colección");
                }
            }

        }   **/

        /** Ejercicio 12
         public static void LlenarPersonas(IColeccionableTP coleccionable)
         {
             for (int L = 0; L < 20; L++)
             {
                 Random aleatorio = new Random();
                 //string nombre_al_azar = Path.GetRandomFileName();
                 IComparableP comp = new Persona(Nombre_al_azar(), aleatorio.Next(10000000, 99999999));
                 coleccionable.Agregar(comp);
             }
         }
         public static string Nombre_al_azar()
         {
             //string texto_aleatorio = "";
             List<string> nombres = new List<string> { "JUAN", "JOSÉ LUIS", "JOSÉ", "MARÍA GUADALUPE", "FRANCISCO", "GUADALUPE", "MARÍA", "JUANA", "ANTONIO", "JESÚS", "MIGUEL ÁNGEL", "PEDRO", "ALEJANDRO", "MANUEL", "MARGARITA", "MARÍA DEL CARMEN", "JUAN CARLOS", "ROBERTO", "FERNANDO", "DANIEL", "CARLOS", "JORGE", "RICARDO", "MIGUEL", "EDUARDO", "JAVIER", "RAFAEL", "MARTÍN", "RAÚL", "DAVID", "JOSEFINA", "JOSÉ ANTO" };
             Random aleatorio = new Random();
             int cantidad = nombres.Count - 1;

             return nombres[aleatorio.Next(0, cantidad)];
         }
         public static void LlenarAlumnos(IColeccionableTP coleccionable)
         {
             for (int L = 0; L < 20; L++)
             {
                 Random aleatorio = new Random();

                 IComparableP compA = new Alumno(Nombre_al_azar(), aleatorio.Next(10000000, 99999999), aleatorio.Next(100, 99999), aleatorio.Next(1, 10));
                 coleccionable.Agregar(compA);
             }

         }   **/
        //public static void Aplicando_Estrategia_Comparar_Alumno_Ejercicio2_practica2() {
        //    //Ejercicio 2 Practica 2
        //    Random aleatorio = new Random();
        //    List<IEstrategia_Comparar_Alumno> Lista_Estrategia_Comparar_Alumno = new List<IEstrategia_Comparar_Alumno>() { new Comparar_Alumno_Nombre(), new Comparar_Alumno_Dni(), new Comparar_Alumno_Promedio(), new Comparar_Alumno_Legajo() };

        //    IEstrategia_Comparar_Alumno estrategia = Lista_Estrategia_Comparar_Alumno[aleatorio.Next(4)];
        //    Alumno alumno_A = new Alumno();
        //    alumno_A.Estrategia_elegida = estrategia;
        //}



        //Ejercicio 7 Practica 2
        public static void  ImprimirElementos(IColeccionableTP coleccionable)
        {
            Interador interador = coleccionable.iterador();

            while(!interador.fin())
            {
                object elemento = interador.actual();
                interador.siguiente();
                //si no agregara siguiente seria un bucle infinito
                Console.WriteLine(elemento);
            }
        }


        //Ejercicio 9 Practica 2
        public static void CambiarEstrategia(IColeccionableTP coleccionable,IEstrategia_Comparar_Alumno estrategia)
        {
            Interador interador = coleccionable.iterador();
            while (!interador.fin())
            {
                IComparableP elemento = interador.actual();
                interador.siguiente();

                ((Alumno)elemento).Estrategia_elegida = estrategia;

                ((Alumno)elemento).Comparar_Alumnos();

                IComparableP alumnoSiguiente = (Alumno)interador.actual();

                //si no agregara siguiente seria un bucle infinito
                //IEstrategia_Comparar_Alumno cambiandoestrategia = new ContextAlumnoStegy(estrategia);
                ContextAlumnoStegy estrategiaalimno = new ContextAlumnoStegy(new Comparar_Alumno_Dni());

                Console.WriteLine("el alumno " + elemento + " es el MISMO que " + alumnoSiguiente + " = " + "\n " + estrategiaalimno.SosIgual(elemento, alumnoSiguiente));
                Console.WriteLine("el alumno " + elemento + " es MENOR que " + alumnoSiguiente + " = " + "\n " + estrategiaalimno.SosMenor(elemento, alumnoSiguiente));
                Console.WriteLine("el alumno " + elemento + " es MAYOR que " + alumnoSiguiente + " = " + "\n " + estrategiaalimno.SosMayor(elemento, alumnoSiguiente));
                
            }
        }
        // Ejercicio 6 TP 3
        public static void LLenar(IColeccionableTP coleccionable, int opcion)
        {
            for(int x = 0; x < 20; x++)
            {
                IComparableP comparable = FabricaCreadorIComprable.CrearAleatorio(opcion);
                coleccionable.Agregar(comparable);
            }

        }

        public static void Informar(IColeccionableTP coleccionable,int opcion)
        {
            Console.WriteLine(coleccionable.Cuantos());
            Console.WriteLine(coleccionable.Maximo());
            Console.WriteLine(coleccionable.Maximo());
            IComparableP comparable = FabricaCreadorIComprable.CrearPorTeclado(opcion);
            if (coleccionable.Contiene(comparable))
            {
                Console.WriteLine("El elemento leído está en la colección");
            }
            else
            {
                Console.WriteLine("El elemento leído no está en la colección");
            }
        }

    }
}
