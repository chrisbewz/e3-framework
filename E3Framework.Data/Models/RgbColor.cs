namespace E3Framework.Data.Models;

public class RgbColor
{
    private int[] _values;

    private int _red;

    private int _green;

    private int _blue;

    private RgbColor(int red, int green, int blue)
    {
        _red = red;
        _green = green;
        _blue = blue;
    }

    public static RgbColor FromValues(int red, int green, int blue)
    {
        return new RgbColor(red, green, blue);
    }

    public static RgbColor Default()
    {
        return new RgbColor(0, 0, 0);
    }

    public int[] Values
    {
        get => _values;
        set => _values = value;
    }

    public int Red => _red;

    public int Green => _green;

    public int Blue => _blue;
}