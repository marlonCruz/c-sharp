using System;

public abstract class Reptil: Animal
{
    public int Patas { get; set; }

    public void Defensa()
    {
        Console.WriteLine("Cola para defenderse...");
    }
}