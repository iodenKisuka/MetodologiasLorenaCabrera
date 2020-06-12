using Clase1_.net_core.Patron_Factory_Method;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Clase1_.net_core
{
    class ProxyAlumno : InterfaceAlumnoProxy,IcomponenteAlumno
    {
        public IcomponenteAlumno AlumnoReal;
        public int tipo_alumno;
        private double nota_Alumno;
        public double CalificacionI { get => nota_Alumno; set => nota_Alumno = value; }

        public ProxyAlumno()
        {
            tipo_alumno = -1;
        }
        public string GetNombre()
        {
            InstanciaAlumno();
            return AlumnoReal.GetNombre();
        }

        public string MostrarCalificacion()
        {
            InstanciaAlumno();
            return AlumnoReal.MostrarCalificacion();
        }

        public int Responder()
        {
            InstanciaAlumno();
            return AlumnoReal.Responder();
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

        public double SetCalificacion()
        {
            InstanciaAlumno();
           return AlumnoReal.SetCalificacion();
        }

        public bool SosIgual(IComparableP variable)
        {
            InstanciaAlumno();
           return AlumnoReal.SosIgual(variable);
        }

        public bool SosMayor(IComparableP variable)
        {
            InstanciaAlumno();
            return AlumnoReal.SosMayor(variable);
        }

        public bool SosMenor(IComparableP variable)
        {
            InstanciaAlumno();
            return AlumnoReal.SosMenor(variable);
        }

            private void InstanciaAlumno()
        {
            if (AlumnoReal == null)
            {

                if (tipo_alumno == 2)
                {
                    AlumnoReal = (AlumnoMuyEstudioso)FabricaCreadorIComprable.CrearAleatorio(FabricaCreadorIComprable.CrearAlumnoEstudioso);
                    Console.WriteLine(" --  Se Creo Alumno Muy Estudioso     --");
                }
                else if (tipo_alumno == 1)
                {
                    AlumnoReal = (Alumno)FabricaCreadorIComprable.CrearAleatorio(FabricaCreadorIComprable.CrearAlumno);
                    Console.WriteLine(" --  Se Creo Alumno      --");
                }
               /* descubri que esto no tiene sentido else if (tipo_alumno == FabricaCreadorIComprable.CrearGrupoAlumnosProxy)
                {
                    AlumnoReal = (GrupoDeAlumno)FabricaCreadorIComprable.CrearAleatorio(FabricaCreadorIComprable.CrearGrupoAlumnos);
                    Console.WriteLine(" --  Se Creo Alumno      --");
                }*/

            }
            
        }
    }
}
