public class Restaurante
{
    public string Desayuno { get; set; }
    public double Saldo1 { get; set; }
    public string Almuerzo { get; set; }
    public double  Saldo2 { get; set; }
    public string  Cena { get; set; }
    public double Saldo3 { get; set; }

    public Restaurante(string desayuno, double saldo1, string almuerzo, double saldo2, string cena, double saldo3)
    {
        Desayuno = desayuno;
        Saldo1 = saldo1;
        Almuerzo = almuerzo;
        Saldo2 = saldo2;
        Cena = cena;
        Saldo3 = saldo3;
    }
}