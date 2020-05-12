using Clase1_.net_core.Patron_observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    public class Gerente:IObservador
    {
        List<Vendedor> Mejores = new List<Vendedor>();


        public void Cerrar()
        {
           
            foreach (Vendedor ven in Mejores)
            {
                
                Console.WriteLine(ven.GetNombre + " Bonus: " + ven.bonus);
            }
        }

        public void Venta(int monto, Vendedor vendedor)
        {
            if (monto > 5000)
            {
                bool estaEnLaLista = false;
                foreach (Vendedor buscar in Mejores)
                {
                    if (buscar.Equals(vendedor))
                    {
                        estaEnLaLista = true;
                        break;
                    }
                }
                if (estaEnLaLista)
                {
                    Mejores.Add(vendedor);
                }
                vendedor.AumentaBonus();
            }
        }

    }
}
