// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class Vehiculos
{
    public int Placa;
    public string? Nombre;
    public decimal Precio;
    public bool Funcionalidad;
    public DateTime Fecha;
}

public class Motos
{
    public int Placa;
    public string? Nombre;
    public decimal Precio;
    public Vehiculos? Vehiculo;
}
