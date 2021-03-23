using System;
public class Gallina: Ave // <- Herencia
{
    public bool EsDomestico { get; set; }

    public Gallina() // <- Polimorfismo
    {
        EsDomestico = true;
    }

    public Gallina(bool esDomestico) // <- Polimorfismo
    {
        EsDomestico = esDomestico;
    }

    public void Kikikear() // <- Abstraccion
    {
        Console.WriteLine("Kikiriki");
    }

    public void Tamano()
    {
        DescribirTamano();
        OtroMetodo();
    }

    private void DescribirTamano() // <- Encapsulamiento
    {
        Console.WriteLine("Es un ave de corral mediana");
    }

    private void OtroMetodo() // <- Encapsulamiento
    {

    }
}