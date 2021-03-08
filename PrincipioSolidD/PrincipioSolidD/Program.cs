using System;

namespace PrincipioSolidD
{
    /*

    Solid D(Dependency inversion principl):

    Solid Ejemplo Malas Practicas D:
    class DatabaseService 
    {
        public void getdatos()
        {
            //...
        }
    }
    class AccesoADatos
    {

        private DatabaseService databaseService;

        public AccesoADatos(DatabaseService databaseService)
        {
            this.databaseService = databaseService;
        }

        void getDatos()
        {
            databaseService.getdatos();
            //...
        }*/


    //Solid Ejemplo Buenas Practicas D:
    interface Conexion
 {
     void getDatos();
     void setDatos();
    }
    class AccesoADatos
    {
     private Conexion conexion;
     public AccesoADatos(Conexion conexion)
     {
         this.conexion = conexion;
     }
     void getDatos()
     {
         conexion.getDatos();
     }
     }
    public class DatabaseService : Conexion
    {
     public void getDatos()
     { //...
     }
     public void setDatos()
     { //... 
     }
    }
     class APIService : Conexion
    {
     public void getDatos()
     { //...
     }
     public void setDatos()
     { //...
     }
    }
     class Program
    {
     static void Main(string[] args)
     {
         Console.ReadKey();
     }
    }

}
