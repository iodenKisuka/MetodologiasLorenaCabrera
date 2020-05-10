using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    public interface Interador
    {   //es la interfaz que tiene todos los metodos que se utilizan para recorrer  
        void siguiente();
        bool fin();
        IComparableP actual();
    }
}
