namespace E3Framework.Contracts.Interfaces;

public interface ICartesian : IPoint
{
    public double PositionX { get; set; }

    public double PositionY { get; set; }
}