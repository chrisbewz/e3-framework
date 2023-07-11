using E3Framework.Contracts.Abstractions;
using E3Framework.Contracts.Interfaces;

namespace E3Framework.BaseTypes.Location;

public sealed class PolarPoint2d : PolarPointAbstract
{
    public override string ToString()
    {
        return $" Magnitude : {Magnitude} | Phase : {Magnitude}";
    }

    private PolarPoint2d(double magnitude, double phase)
    {
        Magnitude = magnitude;
        Phase = phase;
    }

    public static PolarPoint2d CreateInitial()
    {
        return new PolarPoint2d(0, 0);
    }

    public static PolarPoint2d Create(double magnitude, double phase)
    {
        return new PolarPoint2d(magnitude, phase);
    }
}