using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Clase1_.net_core
{
    class Persona : IComparableP
    {
       protected string nombre;
       protected int dni;
        public Persona(string n, int d)
        {
            this.nombre = n;
            this.dni = d;
        }
        public Persona() { }
        public string GetNombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int GetDni
        {
            get { return dni; }
            set { dni = value; }
        }

        public virtual bool SosIgual(IComparableP variable)
        {
            
            if (((Persona)variable).dni == this.dni && ((Persona)variable).nombre == this.nombre)
                return true;
            else
                return false;

        }

        public virtual bool SosMayor(IComparableP variable)
        {
            return this.dni < ((Persona)variable).dni;
        }

        public virtual bool SosMenor(IComparableP variable)
        {
            return this.dni > ((Persona)variable).dni;
        }


        public override string ToString()
        {
            //return base.ToString();
            return "nombre " + this.nombre + " dni " + this.dni;
        }

    }
}
