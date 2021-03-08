using System;

namespace PrincipioSolidI
{
    //Solid I(Interface segregation principle):

    //Solid Ejemplo Malas Practicas I:
    /*
    interface IAve
    {
        public void volar();
        public void comer();
        public void nadar();
    }

    class Loro : IAve
    { 
        public void volar() 
        {
            //...
        }
        public void comer()
        {
            //...
        }
        public void nadar()
        {
            //...
        }
    }
    class Pinguino : IAve 
    {
        public void volar()
        {
            //...
        }
        public void comer()
        {
            //...
        }
        public void nadar()
        {
            //...
        }
    } */

    //Solid Ejemplo Buenas Practicas I:

    public interface IAve
    {
        void comer();
    }
    public interface IAveVoladora
    {
        void volar();
    }
    public interface IAveNadadora
    {
        void nadar();
    }
    public class Loro : IAve, IAveVoladora
    {
        public void volar()
        {
            //...
        }
        public void comer()
        {
            //...
        }
    }
    class Pinguino : IAve, IAveNadadora
    {
        public void nadar()
        {
            //...
        }
        public void comer()
        {
            //...
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }

}
