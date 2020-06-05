using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Clase1_.net_core
{
    class GrupoDeAlumno : IcomponenteAlumno
    {
        List<IcomponenteAlumno> grupodeAlumnos = new List<IcomponenteAlumno>();
        public void Agregar_alumno(IcomponenteAlumno alumno)
        {
            grupodeAlumnos.Add(alumno);
        }
        public string GetNombre()
        {
            string nombres = "";
           foreach (IcomponenteAlumno alumnoS in grupodeAlumnos)
            {
                nombres=nombres+" "+alumnoS.GetNombre();
            }
            return nombres;
        }

        public string MostrarCalificacion()
        {
            string mostrar = "";
            foreach (IcomponenteAlumno alumnoS in grupodeAlumnos)
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
            foreach(IcomponenteAlumno alumnoS in grupodeAlumnos)
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

        public double SetCalificacion()
        {
            double calificacion = 0;
            foreach (IcomponenteAlumno alumnoS in grupodeAlumnos)
            {
                calificacion = calificacion + alumnoS.SetCalificacion();
            }
            return calificacion;
        }

        public bool SosIgual(Alumno alumno)
        {
            throw new NotImplementedException();
        }

        public bool SosMayor(Alumno alumno)
        {
            throw new NotImplementedException();
        }

        public bool SosMenor(Alumno alumno)
        {
            throw new NotImplementedException();
        }

        double IcomponenteAlumno.SetCalificacion()
        {
            throw new NotImplementedException();
        }
    }
}
