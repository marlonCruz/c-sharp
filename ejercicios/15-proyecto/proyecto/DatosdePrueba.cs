using System;
using System.Collections.Generic;
public class DatosdePrueba
{
    public List<Producto> ListadeProductos { get; set; }
    public List<Clientes> ListadeClientes { get; set; }
    public List<Vendedor> ListadeVendedores { get; set; }
    public List<Venta> ListaVentas { get; set; }

    public DatosdePrueba()
    {
        ListadeProductos = new List<Producto>();
        cargarProductos();

        ListadeClientes = new List<Clientes>();
        cargarClientes();

        ListadeVendedores = new List<Vendedor>();
        cargarVendedores();

        ListaVentas = new List<Venta>();
    }

    private void cargarProductos()
    {
        Producto p1 = new Producto(1, "iPhone 12Pro 256GB", 33845);
        ListadeProductos.Add(p1);

        Producto p2 = new Producto(2, "Laptop Dell Latitude Pro I9, 1tb+32gb, 15.1", 50000);
        ListadeProductos.Add(p2);

        Producto p3 = new Producto(3, "Monitor LG 32 UHD con FreeSyncr", 12000);
        ListadeProductos.Add(p3);

        Producto p4 = new Producto(4, "Logitech ERGO K860, teclado ergonómico inalámbrico, Bluetooth, USB, QWERTY Español , Gris", 2875);
        ListadeProductos.Add(p4);

        Producto p5 = new Producto(5, "Maus Corsair Glaive PRO Ergonómico Sensor óptico de 18.000 ppp", 3749);
        ListadeProductos.Add(p5);

        Producto p6 = new Producto(6, "HyperX Cloud MIX Wired Gaming Headset + Bluetooth", 4024);
        ListadeProductos.Add(p6);
    }

    private void cargarClientes()
    {
        Clientes c1 = new Clientes(1, "Waldina de Zavala", "1618-1984-00253");
        ListadeClientes.Add(c1);

        Clientes c2 = new Clientes(2, "Hannia Trondle", "1407-2008-00106");
        ListadeClientes.Add(c2);

        Clientes c3 = new Clientes(3, "Bryan Zavala", "0512-1985-01596");
        ListadeClientes.Add(c3);
    }

    private void cargarVendedores()
    {
        Vendedor v1 = new Vendedor(1, "Francisco Zavala", "V0001");
        ListadeVendedores.Add(v1);

        Vendedor v2 = new Vendedor(2, "Bily Fernandez", "V0002");
        ListadeVendedores.Add(v2);
    }

    public void ListarProductos()
    {
        Console.Clear();
        Console.WriteLine("========ZavMur========");
        Console.WriteLine("= Lista de Productos =");
        Console.WriteLine("========ZavMur========");
        Console.WriteLine("");
        
        foreach (var producto in ListadeProductos)
        {
            Console.WriteLine(producto.Codigo + " | " + producto.Descripcion + " | " + producto.Precio);
        }

        Console.ReadLine();
    }

    public void ListarClientes()
    {
        Console.Clear();
        Console.WriteLine("========ZavMur=======");
        Console.WriteLine("= Lista de Clientes =");
        Console.WriteLine("========ZavMur=======");
        Console.WriteLine("");
        
        foreach (var cliente in ListadeClientes)
        {
            Console.WriteLine(cliente.Codigo + " | " + cliente.Nombre + " | " + cliente.Telefono);
        }

        Console.ReadLine();
    }

    public void ListarVendedores()
    {
        Console.Clear();
        Console.WriteLine("========ZavMur=========");
        Console.WriteLine("= Lista de Vendedores =");
        Console.WriteLine("========ZavMur=========");
        Console.WriteLine("");
        
        foreach (var vendedor in ListadeVendedores)
        {
            Console.WriteLine(vendedor.Codigo + " | " + vendedor.Nombre + " | " + vendedor.CodigoVendedor);
        }

        Console.ReadLine();
    }

    public void CrearVenta()
    {
        Console.WriteLine("=====ZavMur======");
        Console.WriteLine("= Creando Venta =");
        Console.WriteLine("=====ZavMur======");
        Console.WriteLine("");

        Console.WriteLine("Ingrese el codigo del cliente: ");
        string codigoCliente = Console.ReadLine();

        Clientes cliente = ListadeClientes.Find(c => c.Codigo.ToString() == codigoCliente);        
        if (cliente == null)
        {
            Console.WriteLine("Cliente no encontrado");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Cliente: " + cliente.Nombre);
            Console.WriteLine("");
        }

        Console.WriteLine("Ingrese el codigo del vendedor: ");
        string codigoVendedor = Console.ReadLine();

        Vendedor vendedor = ListadeVendedores.Find(v => v.Codigo.ToString() == codigoVendedor);
        if (vendedor == null) 
        {
            Console.WriteLine("Vendedor no encontrado");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Vendedor: " + vendedor.Nombre);
            Console.WriteLine("");
        }

        int nuevoCodigo = ListaVentas.Count + 1;

        Venta nuevaVenta = new Venta(nuevoCodigo, DateTime.Now, "SPS" + nuevoCodigo, cliente, vendedor);
        ListaVentas.Add(nuevaVenta);

        while(true)
        {
            Console.WriteLine("Ingrese el producto: ");
            string codigoProducto = Console.ReadLine();
            Producto producto = ListadeProductos.Find(p => p.Codigo.ToString() == codigoProducto);        
            if (producto == null)
            {
                Console.WriteLine("Producto no encontrado");
                Console.ReadLine();
            } else {
                Console.WriteLine("Producto agregado: " + producto.Descripcion + " con precio de: " + producto.Precio);
                nuevaVenta.AgregarProducto(producto);
            }

            Console.WriteLine("Desea continuar? s/n");
            string continuar = Console.ReadLine();
            if (continuar.ToLower() == "n") {
                break;
            }
        }

        Console.WriteLine("SubTotal de la venta es de: " + nuevaVenta.SubTotal);

        Console.WriteLine("Impuesto de la venta es de: " + nuevaVenta.Impuesto);

        Console.WriteLine("Total de la venta es de: " + nuevaVenta.Total);
        Console.ReadLine();
    }

    public void ListarVentas()
    {
        Console.Clear();
        Console.WriteLine("======ZavMur=======");
        Console.WriteLine("= Lista de Ventas =");
        Console.WriteLine("======ZavMur=======");
        Console.WriteLine("");  
        Console.WriteLine("=====================ZavMur=====================");
        Console.WriteLine("= Codigo | Fecha | SubTotal | Impuesto | Total =");
        Console.WriteLine("=              Cliente | Vendedor              =");
        Console.WriteLine("=====================ZavMur=====================");
        Console.WriteLine("");  

        foreach (var venta in ListaVentas)
        {
            Console.WriteLine(venta.Codigo + " | " + venta.Fecha + " | " + venta.SubTotal + " | " + venta.Impuesto + " | " + venta.Total);
            Console.WriteLine(venta.Cliente.Nombre + " | " + venta.Vendedor.Nombre);
            
            foreach (var detalle in venta.ListaVentaDetalle)
            {
                Console.WriteLine("     " + detalle.Producto.Descripcion + " | " + detalle.Cantidad + " | " + detalle.Precio);
            }

            Console.WriteLine();
        } 

        Console.ReadLine();
    }
}