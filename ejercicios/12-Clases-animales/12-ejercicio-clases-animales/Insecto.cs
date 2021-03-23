using System;

public abstract class Insecto: Animal
{
    public int Alas { get; set; }

    public void Alimento()
    {
        Console.WriteLine("Chupa sangre...");
    }
}