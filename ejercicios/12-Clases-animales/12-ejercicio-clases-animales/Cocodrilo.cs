using System;
public class Cocodrilo: Reptil // <- Herencia
{
    public bool EsDomestico { get; set; }

    public Cocodrilo() // <- Polimorfismo
    {
        EsDomestico = false;
    }

    public Cocodrilo(bool esDomestico) // <- Polimorfismo
    {
        EsDomestico = esDomestico;
    }

    public void Gruñir() // <- Abstraccion
    {
        Console.WriteLine("roar roa roar");
    }

    public void Tamano()
    {
        DescribirTamano();
        OtroMetodo();
    }

    private void DescribirTamano() // <- Encapsulamiento
    {
        Console.WriteLine("Casi del tamano de un humano de largo");
    }

    private void OtroMetodo() // <- Encapsulamiento
    {

    }
}