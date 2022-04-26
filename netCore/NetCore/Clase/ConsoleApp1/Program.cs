using System;

namespace ConsoleApp1
{

    class Escuela
    {

        public string nombre;

        public string direccion;

        public int anoFundacion;

        public string ceo;

        public void Timbrar()
        {
            Console.Beep(10000, 30000);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            var miEscuela = new Escuela();


            miEscuela.nombre = "Pruebas Personales";
            miEscuela.direccion = "Calle 92 83-46";
            miEscuela.anoFundacion = 2001;
            Console.WriteLine("timbre");
            
            miEscuela.Timbrar();

        }   
            //Console.WriteLine("Hello World!");


     }
    
}
