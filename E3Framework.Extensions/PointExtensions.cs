using E3Framework.BaseTypes.Location;
using E3Framework.Contracts.Interfaces;

namespace E3Framework.Extensions;

public static class PointExtensions
{
    public static IPolar FromCartesian(ICartesian cartesianPoint)
    {
        var magnitude = Math.Sqrt(Math.Pow(cartesianPoint.PositionX, cartesianPoint.PositionY));
        var phase = Math.Atan(cartesianPoint.PositionY / cartesianPoint.PositionX);

        return PolarPoint2d.Create(magnitude, phase);
    }

    public static ICartesian FromPolar(IPolar polarPoint)
    {
        var positionX = polarPoint.Magnitude * Math.Cos(polarPoint.Phase);
        var positionY = polarPoint.Magnitude * Math.Sin(polarPoint.Phase);

        return CartesianPoint2d.Create(positionX, positionY);
    }
}