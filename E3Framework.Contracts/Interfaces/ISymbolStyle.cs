namespace E3Framework.Contracts.Interfaces;

public interface ISymbolStyle
{
    IColor HatchColor { get; set;}

    double HatchDistance { get; set;}

    string HatchStyle { get; set;}

    double HatchWidth { get; set;}

    IColor OutlineColor { get; set;}

    bool HasOutlineColor { get;set; }

    string OutlineStyle { get; set;}

    float OutlineWidth { get; set;}
}