using System;

public abstract class Anfibio: Animal
{
    public int Patas { get; set; }

    public void Respirar()
    {
        Console.WriteLine("Respira por la piel...");
    }
}