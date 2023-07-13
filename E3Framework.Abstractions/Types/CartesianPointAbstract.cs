using E3Framework.Contracts.Interfaces;

namespace E3Framework.Abstractions.Types;

public abstract class CartesianPointAbstract : ICartesian
{
    public double PositionX { get; set; }
    public double PositionY { get; set; }

    public virtual double[] AsArray()
    {
        return new[] { PositionX, PositionY };
    }
}