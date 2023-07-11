using System.Xml.Schema;
using E3Framework.Contracts.Interfaces;

namespace E3Framework.Data.Models;

public class DrawingAreaModel : IArea
{
    private double _maxX;
    private double _maxY;
    private double _minX;
    private double _minY;

    private DrawingAreaModel(double maxX, double maxY, double minX, double minY)
    {
        _maxX = maxX;
        _maxY = maxY;
        _minX = minX;
        _minY = minY;
    }

    public double MaxX => _maxX;

    public double MaxY => _maxY;

    public double MinX => _minX;

    public double MinY => _minY;

    public static IArea CreateInitial()
    {
        return new DrawingAreaModel(0, 0, 0, 0);
    }

    public IArea Create(double maxX, double maxY, double minX, double minY)
    {
        return new DrawingAreaModel(maxX, maxY, minX, minY);
    }
}