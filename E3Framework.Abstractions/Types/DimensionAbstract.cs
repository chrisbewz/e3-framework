using System.Collections.Generic;
using e3;
using E3Framework.Contracts.Interfaces;

namespace E3Framework.Abstractions.Types;

public abstract class DimensionAbstract : ComponentAbstract<IDimensionInterface>, IDimensionBase
{
    public IEnumerable<IAttributeBase> Attributes { get; set; }

    public IDimensionStyle Style { get; set; }

    public double LineWidth { get; set; }

    public double LineHeight { get; set; }

    public bool IsALongPath { get; set; }

    public string Text { get; set; }

    public int Level { get; set; }
    
    protected DimensionAbstract(int id, IDimensionInterface instance)
    {
        this.Id = id;
        this.Instance = Instance;
    }
    
    protected DimensionAbstract(int id)
    {
        this.Id = id;
    }
}