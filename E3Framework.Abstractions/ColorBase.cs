using E3Framework.Contracts.Interfaces;

namespace E3Framework.Abstractions;

public abstract class ColorAbstract : IColor
{
    public abstract int[] Values { get; set; }
}