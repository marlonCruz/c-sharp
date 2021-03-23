using System;
public class Zancudo: Insecto // <- Herencia
{
    public bool EsDomestico { get; set; }

    public Zancudo() // <- Polimorfismo
    {
        EsDomestico = false;
    }

    public Zancudo(bool esDomestico) // <- Polimorfismo
    {
        EsDomestico = esDomestico;
    }

    public void Zumbido() // <- Abstraccion
    {
        Console.WriteLine("Zumbido");
    }

    public void Tamano()
    {
        DescribirTamano();
        OtroMetodo();
    }

    private void DescribirTamano() // <- Encapsulamiento
    {
        Console.WriteLine("Casi microscopico");
    }

    private void OtroMetodo() // <- Encapsulamiento
    {

    }
}
