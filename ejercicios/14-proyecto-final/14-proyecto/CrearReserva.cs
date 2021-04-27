using System;
using System.Collections.Generic;

public class CrearReserva
{
    public int Reserva { get; set; }
    public List<Habitaciones> ListadeHabitaciones { get; set; }
    public Habitaciones Habitacion { get; set; }
    public Clientes Clientess { get; set; }
    public double Total { get; set; }
     public DateTime Fecha { get; set; }


    public CrearReserva(int reserva, Habitaciones habitacion, Clientes clientess, DateTime fecha)
    {
        Reserva = reserva;
        Habitacion = habitacion;
        Clientess = clientess;
        Fecha = fecha;
        ListadeHabitaciones = new List<Habitaciones>();
    }

    public void agregarReserva(Habitaciones habitaciones){
        int nuevoNumero = ListadeHabitaciones.Count + 1;
        

        Habitaciones r1 = new Habitaciones(nuevoNumero, 1, "Sencilla", 600, "1" );
        ListadeHabitaciones.Add(r1);

        Total += habitaciones.Precio;
    } 

}