using System.Collections.Generic;
using e3;
using E3Framework.Contracts.Interfaces;

namespace E3Framework.Abstractions;

public abstract class SignalAbstract : ComponentAbstract<ISignalInterface>, ISignalBase
{
    public string Name { get; set;}

    public IEnumerable<IAttributeBase> Attributes { get; set;}
    
    protected SignalAbstract(int id, ISignalInterface instance)
    {
        this.Id = id;
        this.Instance = Instance;
    }
    
    protected SignalAbstract(int id)
    {
        this.Id = id;
    }
}