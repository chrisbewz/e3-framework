using System.Collections.Generic;
using e3;
using E3Framework.Contracts.Interfaces;

namespace E3Framework.Abstractions.Types;

public abstract class ConnectionAbstract : ComponentAbstract<IConnectionInterface>, IConnectionBase
{
    public IEnumerable<IAttributeBase> Attributes { get; set; }
    
    public IEnumerable<IPinBase> CorePins { get; set; }
    
    public IEnumerable<INetSegmentBase> NetSegments { get; set; }
    
    public int NetConnectionId { get; set; }
    
    protected ConnectionAbstract(int id, IConnectionInterface instance)
    {
        this.Id = id;
        this.Instance = Instance;
    }
    
    protected ConnectionAbstract(int id)
    {
        this.Id = id;
    }
}