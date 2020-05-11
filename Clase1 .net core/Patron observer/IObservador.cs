using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core.Patron_observer
{
  public  interface IObservador
    {
     public  void Venta(int monto, Vendedor vendedor);
    }
}
