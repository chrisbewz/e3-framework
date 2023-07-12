using System.Collections.Generic;
using e3;
using E3Framework.Contracts.Interfaces;

namespace E3Framework.Abstractions;

public abstract class AttributeAbstract : ComponentAbstract<IAttributeInterface>, IAttributeBase
{
    public string Value { get; set; }
    public string Name { get; set; }

    public string InternalName { get; set; }
    public string FormattedValue { get; set; }
    public string Owner { get; set; }

    public IEnumerable<int> TextIds { get; set; }
    protected AttributeAbstract(int id, IAttributeInterface instance)
    {
        this.Id = id;
        this.Instance = instance;
    }
    
    protected AttributeAbstract(int id)
    {
        this.Id = id;
    }
}