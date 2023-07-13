using System.Collections.Generic;
using e3;
using E3Framework.Contracts.Interfaces;

namespace E3Framework.Abstractions.Types;

public abstract class NetSegmentAbstract : ComponentAbstract<INetSegmentInterface>, INetSegmentBase
{
    public IEnumerable<IAttributeBase> Attributes { get; }

    public string Name { get; set;}

    public int Level { get; set;}

    public double? SchemaLength { get; set;}

    public string SignalName { get; set;}

    public double? Rotation { get; set;}

    public string BusName { get; set;}
    
    protected NetSegmentAbstract(int id, INetSegmentInterface instance)
    {
        this.Id = id;
        this.Instance = Instance;
    }
    
    protected NetSegmentAbstract(int id)
    {
        this.Id = id;
    }
}