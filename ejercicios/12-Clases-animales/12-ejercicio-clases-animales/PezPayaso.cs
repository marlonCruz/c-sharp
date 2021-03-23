using System;
public class PezPayaso: Pez // <- Herencia
{
    public bool EsDomestico { get; set; }

    public PezPayaso() // <- Polimorfismo
    {
        EsDomestico = false;
    }

    public PezPayaso(bool esDomestico) // <- Polimorfismo
    {
        EsDomestico = esDomestico;
    }

    public void Burbujas() // <- Abstraccion
    {
        Console.WriteLine("No hace sonidos, solo burbujas");
    }

    public void Tamano()
    {
        DescribirTamano();
        OtroMetodo();
    }
    
    private void DescribirTamano() // <- Encapsulamiento
    {
        Console.WriteLine("Muy Pequeño");
    }

    private void OtroMetodo() // <- Encapsulamiento
    {

    }
}