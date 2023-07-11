using e3;
using E3Framework.Contracts.Interfaces;

namespace E3Framework.Contracts.Abstractions;

public abstract class DimensionAbstract : ComponentAbstract, IDimensionBase
{
    public IDimensionInterface Instance { get; set; }

    public int Id { get; set; }

    public IEnumerable<IAttributeBase> Attributes { get; set; }

    public IDimensionStyle Style { get; set; }

    public double LineWidth { get; set; }

    public double LineHeight { get; set; }

    public bool IsALongPath { get; set; }

    public string Text { get; set; }

    public int Level { get; set; }
}