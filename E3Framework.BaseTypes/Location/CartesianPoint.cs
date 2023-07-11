using E3Framework.Contracts.Abstractions;
using E3Framework.Contracts.Interfaces;

namespace E3Framework.BaseTypes.Location;

public class CartesianPoint2d : CartesianPointAbstract
{
    public override string ToString()
    {
        return $" X : {PositionX} / Y : {PositionY}";
    }

    private CartesianPoint2d(double posx, double posy)
    {
        PositionX = posx;
        PositionY = posy;
    }

    public static CartesianPoint2d CreateInitial()
    {
        return new CartesianPoint2d(0, 0);
    }

    public static CartesianPoint2d Create(double magnitude, double phase)
    {
        return new CartesianPoint2d(magnitude, phase);
    }
}