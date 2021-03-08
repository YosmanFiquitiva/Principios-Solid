using System;

namespace PrincipioSolidL
{/*
   
     Solid L(Liskov substitution principle):

     Solid Ejemplo Malas Practicas L:

    public abstract class Coche
    {
        public abstract int precioMedioCoche();        
    }
    public class Renault : Coche
    {
        public override int precioMedioCoche() { return 18000; }        
    }
    public class Audi : Coche
    {
        public override int precioMedioCoche() { return 25000; }        
    }
    public class Mercedes : Coche
    {
        public override int precioMedioCoche() { return 27000; }       
    }
    public class Ford : Coche
    {
        public override int precioMedioCoche() { return 30000; }        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Coche[] arraycoches = {
                new Renault(),new Audi(),new Mercedes(),new Ford(),
            };
            imprimirNumAsientos(arraycoches);

            Console.ReadKey();
        }
        public static void imprimirNumAsientos(Coche[] arrayCoches)
        {
            foreach (Coche coche in arrayCoches)
            {
                if (coche is Renault) { Console.WriteLine(numasietosRenault(coche); }
                if (coche is Renault) { Console.WriteLine(numasietosAudi(coche); }
                if (coche is Renault) { Console.WriteLine(numasietosMercedes(coche); }
                if (coche is Renault) { Console.WriteLine(numasietosFord(coche); }
            }
        }
        public static void imprimirPrecioMedioCoche(Coche[] arrayCoches)
        {
            foreach (Coche coche in arrayCoches)
            {
                Console.WriteLine(coche.precioMedioCoche());
            }
        }

    }


    */

    //Solid Ejemplo Buenas Practicas L:
    public abstract class Coche
    {
        public abstract int precioMedioCoche();
        public abstract int numAsientos();
    }
    public class Renault : Coche
    {
        public override int precioMedioCoche() { return 18000; }
        public override int numAsientos(){ return 2;  }
    }
    public class Audi : Coche
    {
        public override int precioMedioCoche() { return 25000; }
        public override int numAsientos() { return 4; }
    }
    public class Mercedes : Coche
    {
        public override int precioMedioCoche() { return 27000; }
        public override int numAsientos() { return 2; }
    }
    public class Ford : Coche 
    {
        public override int precioMedioCoche() { return 30000; }
        public override int numAsientos() { return 4; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Coche[] arraycoches = {
                new Renault(),new Audi(),new Mercedes(),new Ford()
            };
            imprimirNumAsientos(arraycoches);

            Console.ReadKey();
        }
        public static void imprimirNumAsientos(Coche[] arrayCoches) 
        {
            foreach (Coche coche in arrayCoches) 
            {
                Console.WriteLine(coche.numAsientos());
            }
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
