using Clase1_.net_core.Patron_Factory_Method;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    class ProxyAlumno : InterfaceAlumno
    {
        public Alumno AlumnoReal;
        public int tipo_alumno;

        public ProxyAlumno()
        {
            tipo_alumno = -1;
        }

        public int ResponderPregunta(int pregunta)
        {
            if (AlumnoReal == null)
            {
                int NumAlum=-1;
                if (tipo_alumno < 0)
                {
                    do
                    {
                        try
                        {
                            Console.WriteLine("Que clase de estudiante quiere llamar :" + "\n Peresione 1_Alumno o 2- Alumno Estudioso");
                            NumAlum = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            NumAlum = 0;
                        }
                    } while (NumAlum < 1 && NumAlum > 2);
                }
                else
                {
                    NumAlum = tipo_alumno;
                }
                if (NumAlum == 2)
                {
                    AlumnoReal = (AlumnoMuyEstudioso)FabricaCreadorIComprable.CrearAleatorio(FabricaCreadorIComprable.CrearAlumnoEstudioso);
                    Console.WriteLine(" --  Se Creo Alumno Muy Estudioso     --");
                }
                else if (NumAlum == 1)
                {
                    AlumnoReal = (Alumno)FabricaCreadorIComprable.CrearAleatorio(FabricaCreadorIComprable.CrearAlumno);
                    Console.WriteLine(" --  Se Creo Alumno      --");
                }

            }
            return AlumnoReal.ResponderPregunta(pregunta);
        }


    }
}
