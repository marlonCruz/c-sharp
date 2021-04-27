using System;
using System.Collections.Generic;

public class Habitaciones
{
    public int Numero { get; set; }
    public int Piso { get; set; }
    public string Tipo { get; set; }
    public double Precio { get; set; }
    public string CodigoHabitacion { get; set; }
    
    
    public Habitaciones(int numero, int piso, string tipo, double precio, string codigoHabitacion)
    {
        Numero = numero;
        Piso = piso;
        Tipo = tipo;
        Precio = precio;
        CodigoHabitacion = codigoHabitacion;
        
    }
}