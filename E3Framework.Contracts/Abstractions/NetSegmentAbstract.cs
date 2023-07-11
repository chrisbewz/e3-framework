using e3;
using E3Framework.Contracts.Interfaces;

namespace E3Framework.Contracts.Abstractions;

public abstract class NetSegmentAbstract : ComponentAbstract, INetSegmentBase
{
    public INetSegmentInterface Instance { get; set; }

    public int Id { get; set; }

    public IEnumerable<IAttributeBase> Attributes { get; }

    public string Name { get; set;}

    public int Level { get; set;}

    public double? SchemaLength { get; set;}

    public string SignalName { get; set;}

    public double? Rotation { get; set;}

    public string BusName { get; set;}
}