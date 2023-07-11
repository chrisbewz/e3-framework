using e3;

namespace E3Framework.Contracts.Interfaces;

public interface IConnectionBase : IComponentBase<IConnectionInterface>
{
    IEnumerable<IAttributeBase> Attributes { get; set; }

    IEnumerable<IPinBase> CorePins { get; set;}

    IEnumerable<INetSegmentBase> NetSegments { get;set;}

    public int NetConnectionId { get; set;}
}