using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    class Vendedor: Persona
    {
        double sueldoBasico;
        public  double bonus;

        public Vendedor(string n, int d, double sueldoBasico, double bonus) : base(n, d)
        {
            this.sueldoBasico = sueldoBasico;
            this.bonus = bonus;
        }

        public void Venta(double monto)
        {
            Console.WriteLine("Monto "+monto);
        }
        public void AumentaBonus()
        {
            bonus = bonus + 0.1;
        }

        public override bool SosIgual(IComparableP variable)
        {

            if (((Vendedor)variable).bonus == this.bonus)
                return true;
            else
                return false;

        }

        public override bool SosMayor(IComparableP variable)
        {
            return this.bonus < ((Vendedor)variable).bonus;
        }

        public override bool SosMenor(IComparableP variable)
        {
            return this.bonus > ((Vendedor)variable).bonus;
        }


        public override string ToString()
        {
            return "nombre " + base.nombre + " dni " + base.dni;
        }


    }
}
