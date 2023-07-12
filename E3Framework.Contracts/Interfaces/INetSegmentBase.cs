using e3;

namespace E3Framework.Contracts.Interfaces;

public interface INetSegmentBase
{
    IEnumerable<IAttributeBase> Attributes { get; }

    string Name { get; set;}

    int Level { get; set;}

    double? SchemaLength { get; set;}

    string SignalName { get; set;}

    double? Rotation { get; set;}

    string BusName { get; set;}
}