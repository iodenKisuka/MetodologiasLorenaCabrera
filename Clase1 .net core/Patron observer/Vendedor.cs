using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    public class Vendedor: Persona
    {
        double sueldoBasico;
        public  double bonus;
        public List<Gerente> ListaObservador = new List<Gerente>();


        public Vendedor(string n, int d, double sueldoBasico, double bonus) : base(n, d)
        {
            this.sueldoBasico = sueldoBasico;
            this.bonus = bonus;
        }

        public void Venta(int monto)
        {
            Console.WriteLine("Monto "+monto);
            avisarHizoUnaVenta(monto);
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

        //avisa al gerente cada vez que El objeto vendedor realice una venta
        public void avisarHizoUnaVenta(int monto)
        {
            Vendedor vendedor = new Vendedor(base.nombre, base.dni, this.sueldoBasico, this.bonus);
            foreach (Gerente avisarGerente in ListaObservador)
            {
                //Console.WriteLine("Aviso al gerente");
                avisarGerente.Venta(monto, vendedor); 
            }
        }
        public void AgregargerentecomoObservador(Gerente gerente)
        {
            ListaObservador.Add(gerente);
        }


    }
}
