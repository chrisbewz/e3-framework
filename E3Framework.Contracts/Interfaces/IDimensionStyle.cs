namespace E3Framework.Contracts.Interfaces;

public class IDimensionStyle
{
    public string FontName { get; set;}

    public IColor FontColor { get; set;}

    public double TextHeight { get; set;}

    public double TextOffset { get; set;}

    public string Prefix { get; set;}

    public string Sufix { get; set;}
}