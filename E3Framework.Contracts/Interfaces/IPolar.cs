namespace E3Framework.Contracts.Interfaces;

public interface IPolar : IPoint
{
    public double Magnitude { get; set; }

    public double Phase { get; set; }
}