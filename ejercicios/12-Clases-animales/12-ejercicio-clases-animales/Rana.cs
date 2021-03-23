using System;
public class Rana: Anfibio // <- Herencia
{
    public bool EsDomestico { get; set; }

    public Rana() // <- Polimorfismo
    {
        EsDomestico = false;
    }

    public Rana(bool esDomestico) // <- Polimorfismo
    {
        EsDomestico = esDomestico;
    }

    public void Croac() // <- Abstraccion
    {
        Console.WriteLine("croac croac croa");
    }

    public void Tamano()
    {
        DescribirTamano();
        OtroMetodo();
    }

    private void DescribirTamano() // <- Encapsulamiento
    {
        Console.WriteLine("Diferentes tamanos");
    }

    private void OtroMetodo() // <- Encapsulamiento
    {

    }
}