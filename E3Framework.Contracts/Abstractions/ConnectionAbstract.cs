using e3;
using E3Framework.Contracts.Interfaces;

namespace E3Framework.Contracts.Abstractions;

public class ConnectionAbstract : ComponentAbstract, IConnectionBase
{
    public IConnectionInterface Instance { get; set; }
    
    public int Id { get; set; }
    
    public IEnumerable<IAttributeBase> Attributes { get; set; }
    
    public IEnumerable<IPinBase> CorePins { get; set; }
    
    public IEnumerable<INetSegmentBase> NetSegments { get; set; }
    
    public int NetConnectionId { get; set; }
}