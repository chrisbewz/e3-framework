using E3Framework.Contracts.Interfaces;

namespace E3Framework.Data.Models;

public class SymbolStyle : ISymbolStyle
{
    public IColor HatchColor { get; set;}

    public double HatchDistance { get;set; }

    public string HatchStyle { get; set;}

    public double HatchWidth { get; set;}

    public IColor OutlineColor { get; set;}

    public bool HasOutlineColor { get; set;}

    public string OutlineStyle { get; set;}

    public float OutlineWidth { get; set;}
}