namespace ToolsApp.Models;

public class NewCar : INewCar
{
    public required string Make { get; set; }
    public required string Model { get; set; }
    public int Year { get; set; }
    public required string Color { get; set; }
    public decimal Price { get; set; }
}

public class Car : NewCar, ICar
{
    public int Id { get; set; }
}