using System;
using escuelaPlatzi.entidades;

namespace escuelaPlatzi
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 1988,TiposEscuela.Secundaria,"México",ciudad: "Xalapa");

            var arregloCursos = new Curso[3];


            arregloCursos[0] = new Curso() {
                Nombre="101",
                Jornada = TiposJornada.Mañana
            };

            arregloCursos[1] = new Curso(){
                Nombre = "202"
            };

            arregloCursos[2] = new Curso(){
                Nombre = "303"
            };

            
            
            
            Console.WriteLine(escuela);
            System.Console.WriteLine("===============");
            ImprimirCursos(arregloCursos);

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
