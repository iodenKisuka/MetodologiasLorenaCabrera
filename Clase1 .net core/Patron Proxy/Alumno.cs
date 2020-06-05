using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    class Alumno : Persona, InterfaceAlumno,IcomponenteAlumno
    {
        int legajo;
        int promedio;
        private double calificacion;
        // agregue esto como adicional para aplicar interface icomplementoAlumno
        private int respuesta;
       

        public double UltimaCalificacion { get => calificacion; set => calificacion = value; }
        public int GetLegajo
        {
            get { return legajo; }
            set { legajo = value; }
        }
        public int GetPromedio
        {
            get { return promedio; }
            set { promedio = value; }
        }

        public Alumno(string n, int d, int l, int p) : base(n, d)
        {
            this.legajo = l;
            this.promedio = p;
            respuesta = 0;
        }
        public Alumno() { }

        public override string ToString()
        {
            return base.ToString() + " legajo " + this.legajo;
        }

        /** public override bool SosMayor(IComparableP variable)
         {
             return this.legajo < ((Alumno)variable).legajo;
         }

         public override bool SosMenor(IComparableP variable)
         {
             return this.legajo < ((Alumno)variable).legajo;
         } **/

       public IEstrategia_Comparar_Alumno Estrategia_elegida{ get; set; }
        
       

        //delegar las acciones
        public void Comparar_Alumnos()
        {
            //return this.Estrategia_elegida.SosIgual(this, comparable);
            //este contextAlumnoStrategia lo hice yo 
            if (Estrategia_elegida == null)
            {
                Estrategia_elegida = new Comparar_Alumno_Dni();
            }
            ContextAlumnoStegy estrategia = new ContextAlumnoStegy(Estrategia_elegida);
          

        }

        //Ejercicio 1 TP4
       public  int ResponderPregunta(int pregunta)
        {
            Random aleatorio = new Random();
            //adicional
           respuesta= aleatorio.Next(1, 3);

            return  respuesta ;
        }


        //modifique para implementar practica 6 ejercicio 1 interfaz icomponenteAlumno
        string IcomponenteAlumno.GetNombre()
        {
           string nombre= ""+ base.GetNombre;
            return nombre;
        }

        
        public int Responder()
        {
            return respuesta;
            
        }

        public double SetCalificacion()
        {
          return UltimaCalificacion;
        }

        public string MostrarCalificacion()
        {
            return GetNombre + " " + UltimaCalificacion;
        }

        public bool SosIgual(Alumno alumno)
        {
            if (Estrategia_elegida == null)
            {
                Estrategia_elegida = new Comparar_Alumno_Dni();
            }
            ContextAlumnoStegy estrategia = new ContextAlumnoStegy(Estrategia_elegida);
            Alumno ThisAlumno = new Alumno(nombre, dni,legajo,promedio);
           return estrategia.SosIgual(ThisAlumno,alumno);
        }

        public bool SosMenor(Alumno alumno)
        {
            if (Estrategia_elegida == null)
            {
                Estrategia_elegida = new Comparar_Alumno_Dni();
            }
            ContextAlumnoStegy estrategia = new ContextAlumnoStegy(Estrategia_elegida);
            Alumno ThisAlumno = new Alumno(nombre, dni, legajo, promedio);
            return estrategia.SosMenor(ThisAlumno, alumno);
        }

        public bool SosMayor(Alumno alumno)
        {
            if (Estrategia_elegida == null)
            {
                Estrategia_elegida = new Comparar_Alumno_Dni();
            }
            ContextAlumnoStegy estrategia = new ContextAlumnoStegy(Estrategia_elegida);
            Alumno ThisAlumno = new Alumno(nombre, dni, legajo, promedio);
            return estrategia.SosMayor(ThisAlumno, alumno);
        }
    }
}
