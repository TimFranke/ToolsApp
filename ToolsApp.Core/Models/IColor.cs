namespace ToolsApp.Core.Models;

public interface IColor
{
    int Id { get; set; }
    string Name { get; set; }
    string HexCode { get; set; }
}
