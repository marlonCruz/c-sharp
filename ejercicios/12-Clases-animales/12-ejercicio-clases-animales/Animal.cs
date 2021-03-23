using System;
public abstract class Animal
{
    public string Nombre { get; set; }

    public void Comer()
    {
        Console.WriteLine("Comiendo...");
    }
    public void Jugar()
    {
        Console.WriteLine("Jugando...");
    }
    public void Triste()
    {
        Console.WriteLine("Triste...");
    }
    public void Inquieto()
    {
        Console.WriteLine("Inquieto...");
    }
    public void Banar()
    {
        Console.WriteLine("Banandose...");
    }
    public void Secar()
    {
        Console.WriteLine("Secandose...");
    }
    public void Atrapar()
    {
        Console.WriteLine("Atrapando bichos...");
    }
}
