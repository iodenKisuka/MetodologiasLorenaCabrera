using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Clase1_.net_core
{
    class GrupoDeAlumno :IcomponenteAlumno
    {
        public List<IcomponenteAlumno> ListagrupodeAlumnos = new List<IcomponenteAlumno>();
        public double calificacionGrupal;

        public double CalificacionI { get => calificacionGrupal; set=> calificacionGrupal=value; }
       
        public void Agregar_alumno(IcomponenteAlumno alumno)
        {
            ListagrupodeAlumnos.Add(alumno);
        }
        //constructor
       public GrupoDeAlumno()
        {
            calificacionGrupal = 0;
        }

        public string GetNombre()
        {
            string nombres = "";
           foreach (IcomponenteAlumno alumnoS in ListagrupodeAlumnos)
            {
                nombres=nombres+" "+alumnoS.GetNombre();
            }
            return nombres;
        }

        public string MostrarCalificacion()
        {
            string mostrar = "";
            foreach (IcomponenteAlumno alumnoS in ListagrupodeAlumnos)
            {
                //GetNombre + " " + UltimaCalificacion;
                mostrar = "\n " + alumnoS.MostrarCalificacion();
            }
            return mostrar;
        }

        public int Responder()
        {
            int R1 = 0;
            int R2 = 0;
            int R3 = 0;
            int Respuesta_Mayoritaria = 0;
            foreach(IcomponenteAlumno alumnoS in ListagrupodeAlumnos)
            {
                switch (alumnoS.Responder()) 
                {
                    case 1:
                        R1 = R1 + 1;
                        break;
                    case 2:
                        R2 = R2 + 1;
                        break;
                    case 3:
                        R3 = R3 + 1;
                        break;
                    default:
                        break;
                }
                if(R1>=R2 && R1 >= R3)
                {
                    return R1;
                }
                else if (R2 >= R1 && R2 >= R3)
                {
                    return R2;
                }
                else if (R3 >= R1 && R3 >= R2)
                {
                    return R1;
                }


            }


            return Respuesta_Mayoritaria;
        }

        public int ResponderPregunta(int pregunta)
        {
           return Responder();
        }

        public double SetCalificacion()
        {
            
            foreach (IcomponenteAlumno alumnoS in ListagrupodeAlumnos)
            {
                calificacionGrupal = calificacionGrupal + alumnoS.SetCalificacion();
                
            }
            return calificacionGrupal/ListagrupodeAlumnos.Count;
        }

        public bool SosIgual(IComparableP variable)
        {
            Alumno alumno = (Alumno)variable;
            foreach (IcomponenteAlumno alumnoS in ListagrupodeAlumnos)
            {
                if (alumnoS.SosIgual(alumno))
                {
                    return true;
                }
            }
            return false;
        }


        

        public bool SosMayor(IComparableP variable)
        {
            Alumno alumno = (Alumno)variable;
            foreach (IcomponenteAlumno alumnoS in ListagrupodeAlumnos)
            {
                if (alumnoS.SosMayor(alumno))
                {
                    return true;
                }
            }
            return false;
        }

        public bool SosMenor(IComparableP variable)
        {
            Alumno alumno = (Alumno)variable;
            foreach (IcomponenteAlumno alumnoS in ListagrupodeAlumnos)
            {
                if (alumnoS.SosMenor(alumno))
                {
                    return true;
                }
            }
            return false;
        }

        
    }
}
