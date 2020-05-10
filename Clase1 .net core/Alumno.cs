using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    class Alumno : Persona
    {
        int legajo;
        int promedio;
        private double calificacion;

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
          ContextAlumnoStegy estrategia = new ContextAlumnoStegy(Estrategia_elegida);
          

        }

        //Ejercicio 1 TP4
       public virtual int responderPregunta(int pregunta)
        {
            Random aleatorio = new Random();

            return aleatorio.Next(1,3);
        }
        public virtual string mostrarCalificación()
        {

            return GetNombre+" "+UltimaCalificacion;
        }



    }
}
