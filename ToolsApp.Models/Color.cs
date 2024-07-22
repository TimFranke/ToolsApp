namespace ToolsApp.Models;

public class Color : IColor
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string HexCode { get; set; }
}
