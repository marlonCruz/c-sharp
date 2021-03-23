using System;

public abstract class Pez: Animal
{
    public int Aletas { get; set; }

    public void Agallas()
    {
        Console.WriteLine("Respira bajo el agua...");
    }
}