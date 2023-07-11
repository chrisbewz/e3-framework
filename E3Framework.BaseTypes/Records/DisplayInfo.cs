using E3Framework.Contracts.Interfaces;

namespace E3Framework.BaseTypes.Records;

public record DisplayInfo : IDisplayInfo
{
    public DisplayInfo(double length, double width)
    {
        DisplayLength = length;
        DisplayWidth = width;
    }

    public double DisplayLength { get; }
    public double DisplayWidth { get; }
}