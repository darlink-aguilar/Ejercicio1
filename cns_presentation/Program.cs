// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Motos moto1 = new Motos();
moto1.Placa = 1233;
moto1.Nombre = "Switch";
moto1.Precio = 1.0m;
moto1.Funcionalidad = true;
moto1.Fecha = DateTime.Now;
moto1.Color = "Negro";
public class Vehiculos
{
    public int Placa;
    public string? Nombre;
    public decimal Precio;
    public bool Funcionalidad;
    public DateTime Fecha;
}

public class Motos : Vehiculos
{
    public string? Color;
}

public class Clientes
{
    public int Id;
    public string? Nombre;
    public decimal Estatura;
    public Vehiculos? Vehiculo;
}
