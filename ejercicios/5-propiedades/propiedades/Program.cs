using System;

namespace _05_Propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a = new Alumno();
            a.id = 1;
            a.PrimerNombre = "Cruz";
            a.SegundoNombre = "Marlon";
            Console.WriteLine("Hello World!");
        }
    }
}