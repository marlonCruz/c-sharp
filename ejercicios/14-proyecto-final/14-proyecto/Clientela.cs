public class Clientela : Clientes 
{
    public string CodigoCliente { get; set; }
   
public Clientela(int codigo, int id, string nombre, string apellido, int telefono, string codigocliente)
    {
        Codigo = codigo;
        ID = id;
        Nombre = nombre;
        Apellido = apellido;
        Telefono = telefono;
        CodigoCliente = codigocliente;

    }

}