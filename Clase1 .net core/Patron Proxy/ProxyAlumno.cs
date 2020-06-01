using Clase1_.net_core.Patron_Factory_Method;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core.Patron_Proxy
{
    class ProxyAlumno : InterfaceAlumnoparaProxy
    {
        Alumno AlumnoReal;


        public int ResponderPregunta(int pregunta)
        {
            if (AlumnoReal == null)
            {
                int NumAlum;
                do
                {
                    try
                    {
                        Console.WriteLine("Que clase de estudiante quiere llamar :" + "\n Peresione 1_Alumno o 2- Alumno Estudioso");
                        NumAlum = int.Parse(Console.ReadLine());
                        if (NumAlum == 2)
                        {
                            AlumnoReal = (AlumnoMuyEstudioso)FabricaCreadorIComprable.CrearAleatorio(FabricaCreadorIComprable.CrearAlumnoEstudioso);

                        }
                        else if (NumAlum == 1)
                        {
                            AlumnoReal = (Alumno)FabricaCreadorIComprable.CrearAleatorio(FabricaCreadorIComprable.CrearAlumno);
                        }
                    }
                    catch (Exception)
                    {
                        NumAlum = 0;
                    }
                } while (NumAlum < 1 && NumAlum > 2);
  
            }
            return AlumnoReal.responderPregunta(pregunta);
        }


    }
}
