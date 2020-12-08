using System;
using static System.Console;
using escuelaPlatzi.entidades;

namespace escuelaPlatzi
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 1988, TiposEscuela.Secundaria, "México", ciudad: "Xalapa");

            Curso[] arregloCursos = {
                     new Curso(){ Nombre="101"},
                     new Curso(){ Nombre="201"},
                     new Curso(){ Nombre="301"},
            };

            escuela.Cursos = arregloCursos;
            
            WriteLine(escuela);
            ImprimirCursosEscuela(escuela);


            // WriteLine(escuela);
            // WriteLine("===============");
            // ImprimirCursos(arregloCursos);

        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            WriteLine("====================");
            WriteLine("Cursos de la escuela");
            WriteLine("====================");

            if ( escuela?.Cursos != null)
            {
                foreach (var item in escuela.Cursos)
                {
                    System.Console.WriteLine(item);
                }
            }

        }

        private static void ImprimirCursos(Curso[] arregloCursos)
        {
            foreach (var item in arregloCursos)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
