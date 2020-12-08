using System.ComponentModel;
using System;
using static System.Console;
using escuelaPlatzi.entidades;
using System.Collections.Generic;

namespace escuelaPlatzi
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 1988, TiposEscuela.Secundaria, "México", ciudad: "Xalapa");

            escuela.Cursos = new List<Curso>(){
                     new Curso(){ Nombre="101", Jornada = TiposJornada.Mañana},
                     new Curso(){ Nombre="201", Jornada = TiposJornada.Mañana},
                     new Curso(){ Nombre="301", Jornada = TiposJornada.Mañana},
            };

            var otraColeccion =  new List<Curso>(){
                     new Curso(){ Nombre="401", Jornada = TiposJornada.Mañana},
                     new Curso(){ Nombre="501", Jornada = TiposJornada.Mañana},
                     new Curso(){ Nombre="601", Jornada = TiposJornada.Tarde},
            };

            escuela.Cursos.Add( new Curso(){ Nombre = "102", Jornada = TiposJornada.Tarde});
            escuela.Cursos.Add( new Curso(){ Nombre = "202", Jornada = TiposJornada.Tarde});
            
            escuela.Cursos.AddRange(otraColeccion);

            
            WriteLine(escuela);
            ImprimirCursosEscuela(escuela);

            //Predicate<Curso> miAlgoritmo = Predicado;
            escuela.Cursos.RemoveAll(Predicado);

            escuela.Cursos.RemoveAll(delegate (Curso cu){ return cu.Nombre == "101";});

            escuela.Cursos.RemoveAll((cur)=>cur.Nombre=="501");


            ImprimirCursosEscuela(escuela);

            // WriteLine(escuela);
            // WriteLine("===============");
            // ImprimirCursos(arregloCursos);

        }

        private static bool Predicado (Curso curobj){
            return curobj.Nombre == "301";
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

    }
}
