using System;

namespace PrincipiosSolidO
{/*
     
    Solid O(Open/closed principle):

    Solid Ejemplo Malas Practicas O:

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
            Coche[] arrayCoches = {
                new Coche("Renault"),new Coche("Audi"),new Coche("Mercedes")
            };
            imprimirPrecioMedioCoche(arrayCoches);
            Console.ReadKey();
        }
        public static void imprimirPrecioMedioCoche(Coche[] arrayCoches) 
        {
            foreach (Coche coche in arrayCoches) 
            {
                if (arrayCoches[0] == arrayCoches[i]) { Console.WriteLine(18000);};
                if (arrayCoches[1] == arrayCoches[i]) { Console.WriteLine(25000);};
                if (arrayCoches[2] == arrayCoches[i]) { Console.WriteLine(27000);};
            }
        }
    }
    */

    //Solid Ejemplo Buenas Practicas O:
    public abstract class Coche
    {
        public abstract int precioMedioCoche();
    }
    public class Renault : Coche
    {
        public override int precioMedioCoche() { return 18000;}
    }
    public class Audi : Coche
    {
        public override int precioMedioCoche() { return 25000;}
    }
    public class Mercedes : Coche
    {
        public override int precioMedioCoche() { return 27000;}
    }

    class Program 
    {        
        static void Main(string[] args)
        {
            Coche[] arraycoches = {
                new Renault(),new Audi(),new Mercedes()
            };
            imprimirPrecioMedioCoche(arraycoches);
            Console.ReadKey();
        }
        public static void imprimirPrecioMedioCoche(Coche[] arrayCoches) 
        {
            foreach (Coche coche in arrayCoches) 
            {
                Console.WriteLine(coche.precioMedioCoche());
            }
        }
        
    }
}
