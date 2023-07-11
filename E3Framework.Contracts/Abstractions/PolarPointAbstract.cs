using E3Framework.Contracts.Interfaces;

namespace E3Framework.Contracts.Abstractions;

public abstract class PolarPointAbstract : IPolar
{
    public double Magnitude { get; set; }
    public double Phase { get; set; }

    public virtual double[] AsArray()
    {
        return new[] { Magnitude, Phase };
    }
}