namespace ToolsApp.Models;

public class NewColor : INewColor
{
    public required string Name { get; set; }
    public required string HexCode { get; set; }
}

public class Color : NewColor, IColor
{
    public int Id { get; set; }
}