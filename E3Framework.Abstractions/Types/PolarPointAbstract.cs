using E3Framework.Contracts.Interfaces;

namespace E3Framework.Abstractions.Types;

public abstract class PolarPointAbstract : IPolar
{
    public double Magnitude { get; set; }
    public double Phase { get; set; }

    public virtual double[] AsArray()
    {
        return new[] { Magnitude, Phase };
    }
}