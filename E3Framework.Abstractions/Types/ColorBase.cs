using E3Framework.Contracts.Interfaces;

namespace E3Framework.Abstractions.Types;

public abstract class ColorAbstract : IColor
{
    public abstract int[] Values { get; set; }
}