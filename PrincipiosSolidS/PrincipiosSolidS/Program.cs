using System;

namespace PrincipiosSolidS
{   /*
     
    Solid S(Single responsibility principle):

    Solid Ejemplo Malas Practicas S:
    
    class Coche
    {
        public string marca = "Renalt";
        public Coche(string marca) { this.marca = marca; }
        public string getMarcaCoche() { return marca; }
        public void guardarCocheDB(Coche coche) { }

    }

    */

    //Solid Ejemplo Buenas Prcticas S:

     // en este principio se utilizó el patrón Grasp (Alta Cohesion,Experto,Controlador)
    class Coche            
    {
        public string marca;
        public Coche(string marca) { this.marca = marca; }
        public string getMarcaCoche() { return marca; }
    }
    class CocheDataBase
    {
        void guardarCoche(Coche auto) { }
        void eliminarCoche(Coche auto) { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}

