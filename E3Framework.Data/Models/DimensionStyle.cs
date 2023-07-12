using E3Framework.Contracts.Interfaces;

namespace E3Framework.Data.Models;

public class DimensionStyle : IDimensionStyle
{
    public string FontName { get; }

    public IColor FontColor { get; }

    public double TextHeight { get; }

    public double TextOffset { get; }

    public string Prefix { get; }

    public string Sufix { get; }

    public DimensionStyle(string fontName, IColor fontColor, double textHeight, double textOffset, string prefix, string sufix)
    {
        FontName = fontName;
        FontColor = fontColor;
        TextHeight = textHeight;
        TextOffset = textOffset;
        Prefix = prefix;
        Sufix = sufix;
    }
}