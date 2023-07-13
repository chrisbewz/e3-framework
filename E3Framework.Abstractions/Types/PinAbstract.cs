using System.Collections.Generic;
using e3;
using E3Framework.Contracts.Interfaces;

namespace E3Framework.Abstractions.Types;

public abstract class PinAbstract : ComponentAbstract<IPinInterface>, IPinBase
{
    public IEnumerable<IAttributeBase> Attributes { get; set;}
    protected PinAbstract(int id, IPinInterface instance)
    {
        this.Id = id;
        this.Instance = Instance;
    }
    
    protected PinAbstract(int id)
    {
        this.Id = id;
    }
}