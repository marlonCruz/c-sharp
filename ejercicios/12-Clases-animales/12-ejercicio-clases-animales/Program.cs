using System;

namespace _12_ejercicio_clase_animales
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilidades.EnviarCorreo();

            Perro p = new Perro();
            p.Nombre = "Perro";
            p.Patas = 4;
            p.EsDomestico = true;
            if (p.EsDomestico == true)
            {
                Console.WriteLine("Es un animal domestico"); 
            }else{
                Console.WriteLine("No es un animal domestico"); 
            }
            p.Comer();
            p.Caminar();
            p.Ladrar();
            p.Tamano();
            Console.WriteLine(p.Nombre);
            Console.WriteLine(p.Patas);
            Console.WriteLine("--------------------------------------");

            Gallina a = new Gallina();
            a.Nombre = "Gallina";
            a.Alas = 2;
            a.EsDomestico = true;
            if (a.EsDomestico == true)
            {
                Console.WriteLine("Es un animal domestico"); 
            }else{
                Console.WriteLine("No es un animal domestico"); 
            }
            a.Comer();
            a.Volar();
            a.Kikikear();
            a.Tamano();
            Console.WriteLine(a.Nombre);
            Console.WriteLine(a.Alas);
            Console.WriteLine("--------------------------------------");

            Gato g = new Gato();
            g.Nombre = "Gato";
            g.Patas = 4;
            g.Pelaje = "Peludo";
            g.Comer();
            g.Caminar();
            g.Maullar();
            Console.WriteLine("Es un animal domestico");
            Console.WriteLine(g.Nombre);
            Console.WriteLine(g.Patas);
            Console.WriteLine("--------------------------------------");

            Rana r = new Rana();
            r.Nombre = "Rana";
            r.Patas = 4;
            r.EsDomestico = false;
            if (r.EsDomestico == true)
            {
                Console.WriteLine("Es un animal domestico"); 
            }else{
                Console.WriteLine("No es un animal domestico"); 
            }
            r.Comer();
            r.Atrapar();
            r.Croac();
            r.Tamano();
            Console.WriteLine(r.Nombre);
            Console.WriteLine(r.Patas);
            Console.WriteLine("--------------------------------------");

            Zancudo z = new Zancudo();
            z.Nombre = "Aedes Aegipty";
            z.Alas = 2;
            z.EsDomestico = false;
            if (z.EsDomestico == true)
            {
                Console.WriteLine("Es un animal domestico"); 
            }else{
                Console.WriteLine("No es un animal domestico"); 
            }
            z.Inquieto();
            z.Alimento();
            z.Zumbido();
            z.Tamano();
            Console.WriteLine(z.Nombre);
            Console.WriteLine(z.Alas);
            Console.WriteLine("--------------------------------------");

            PezPayaso pp = new PezPayaso();
            pp.Nombre = "Pez Payaso";
            pp.Aletas = 2;
            pp.EsDomestico = false;
            if (pp.EsDomestico == true)
            {
                Console.WriteLine("Es un animal domestico"); 
            }else{
                Console.WriteLine("No es un animal domestico"); 
            }
            pp.Banar();
            pp.Agallas();
            pp.Burbujas();
            pp.Tamano();
            Console.WriteLine(pp.Nombre);
            Console.WriteLine(pp.Aletas);
            Console.WriteLine("--------------------------------------");

            Cocodrilo c = new Cocodrilo();
            c.Nombre = "Cocodrilo de pantano";
            c.Patas = 4;
            c.EsDomestico = false;
            if (r.EsDomestico == true)
            {
                Console.WriteLine("Es un animal domestico"); 
            }else{
                Console.WriteLine("No es un animal domestico"); 
            }
            c.Comer();
            c.Defensa();
            c.Gruñir();
            c.Tamano();
            Console.WriteLine(c.Nombre);
            Console.WriteLine(c.Patas);
            Console.WriteLine("--------------------------------------");

        }
    }
}