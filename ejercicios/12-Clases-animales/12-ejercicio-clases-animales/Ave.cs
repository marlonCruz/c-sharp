using System;

public abstract class Ave: Animal
{
    public int Alas { get; set; }

    public void Volar()
    {
        Console.WriteLine("Volando...");
    }
}