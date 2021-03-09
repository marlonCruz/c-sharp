using System;

namespace _04_Constructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a = new Alumno();
            a.PrimerNombre = "cruz";
            a.SegundoNombre = "marlon";

            Alumno b = new Alumno();
            b.Id = 2;
            b.PrimerNombre = "Walter";
            b.SegundoNombre = "Augusto";

            Alumno c = new Alumno(3);
            c.PrimerNombre = "Juana";
            c.SegundoNombre = "Maria";


            Console.WriteLine(a.Id);
            Console.WriteLine(b.Id);
            Console.WriteLine(c.Id);
        }
    }
}