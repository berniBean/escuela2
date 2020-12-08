using System.Collections.Generic;

namespace escuelaPlatzi.entidades
{
    public class Escuela
    {
        string nombre;

        public string Nombre{
            get{return nombre;}
            set{nombre = value.ToUpper();}
        }
        public int AñoDeCreación {get; set;}
        public string Pais {get; set;}
        public string Ciudad {get; set;} 
        public TiposEscuela TipoEscuela{get; set;}
        public Escuela(string nombre, int año){
            this.nombre = nombre;
            AñoDeCreación = año;
            
        }

        public Escuela(string nombre, int año, TiposEscuela tipos, string pais ="", string ciudad ="") {
            (Nombre, AñoDeCreación)=(nombre, año);
            Pais = pais;
            Ciudad = ciudad;
            
        }

        public List<Curso> Cursos {get; set;}

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Tipo: {TipoEscuela} \n Pais: {Pais}, Ciudad: {Ciudad}";
        }

    }
}