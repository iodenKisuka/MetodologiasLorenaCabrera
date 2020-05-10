using System;
using System.Collections.Generic;
using System.Text;

namespace Clase1_.net_core
{
    class FabricaDeAlumnos
    {
        private IComparableP alumno;


        private string Nombre_al_azar()
        {
            //string texto_aleatorio = "";
            List<string> nombres = new List<string> { "JUAN", "JOSÉ LUIS", "JOSÉ", "MARÍA GUADALUPE", "FRANCISCO", "GUADALUPE", "MARÍA", "JUANA", "ANTONIO", "JESÚS", "MIGUEL ÁNGEL", "PEDRO", "ALEJANDRO", "MANUEL", "MARGARITA", "MARÍA DEL CARMEN", "JUAN CARLOS", "ROBERTO", "FERNANDO", "DANIEL", "CARLOS", "JORGE", "RICARDO", "MIGUEL", "EDUARDO", "JAVIER", "RAFAEL", "MARTÍN", "RAÚL", "DAVID", "JOSEFINA", "JOSÉ ANTO" };
            Random aleatorio = new Random();
            int cantidad = nombres.Count - 1;

            return nombres[aleatorio.Next(0, cantidad)];
        }
        public  IComparableP CrearAlumnoAlAzar()
        {
            Random aleatorio = new Random();    // IComparableP compA 
            alumno = new Alumno(Nombre_al_azar(), aleatorio.Next(10000000, 99999999), aleatorio.Next(100, 99999), aleatorio.Next(1, 10));
            return alumno;
        }

        public IComparableP CrearAlumnoPorTeclado()
        {
            alumno = new Alumno(LectorDeDatos.stringPorTeclado(), LectorDeDatos.numeroPorTeclado(), LectorDeDatos.numeroPorTeclado(), LectorDeDatos.numeroPorTeclado());
            return alumno;
        }
    }
}
