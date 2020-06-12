using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    class FabricaGrupoProxy
    {
        private string Nombre_al_azar()
        {
            //string texto_aleatorio = "";
            List<string> nombres = new List<string> { "JUAN", "JOSÉ LUIS", "JOSÉ", "MARÍA GUADALUPE", "FRANCISCO", "GUADALUPE", "MARÍA", "JUANA", "ANTONIO", "JESÚS", "MIGUEL ÁNGEL", "PEDRO", "ALEJANDRO", "MANUEL", "MARGARITA", "MARÍA DEL CARMEN", "JUAN CARLOS", "ROBERTO", "FERNANDO", "DANIEL", "CARLOS", "JORGE", "RICARDO", "MIGUEL", "EDUARDO", "JAVIER", "RAFAEL", "MARTÍN", "RAÚL", "DAVID", "JOSEFINA", "JOSÉ ANTO" };
            Random aleatorio = new Random();
            int cantidad = nombres.Count - 1;

            return nombres[aleatorio.Next(0, cantidad)];
        }
        public  IComparableP CrearAlumnosAlAzar()
        {
            GrupoDeAlumno grupo = new GrupoDeAlumno();
            for (int n = 0; n < 5; n++)
            {
                ProxyAlumno alumnoProxy = new ProxyAlumno();
                grupo.Agregar_alumno(alumnoProxy);
            }
            return grupo;
        }

        public IComparableP CrearAlumnosPorTeclado()
        {
            GrupoDeAlumno grupo= new GrupoDeAlumno();
            for (int n = 0; n < 5; n++)
            {
                Console.WriteLine("Estamos creando un alumno compuesto de 5 alumnos, es decir un grupo de alumno de 5 integrantes");
                Console.WriteLine("Hasta ahora a creado " + n + " alumnos");
                ProxyAlumno alumnoProxy = new ProxyAlumno();
                grupo.Agregar_alumno(alumnoProxy);
            }
            return grupo;

        }
    }
}
